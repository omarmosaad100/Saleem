using System.Text;
using BBussinesLogicLayer;
using BBussinesLogicLayer.Managers.Admin;
using CDataAccessLayer.Data;
using CDataAccessLayer.Repos;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using BBussinesLogicLayer.Managers.Doctor;
using BBussinesLogicLayer.Managers.Patient;
using CDataAccessLayer.Repos.Patient;

namespace AInterfaceLayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers().AddNewtonsoftJson(o => o.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            

            #region Database
            builder.Services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            #endregion

            #region Repos
            builder.Services.AddScoped<IAdminRepo, AdminRepo>();
            builder.Services.AddScoped<IDoctorRepo, DoctorRepo>();
            builder.Services.AddScoped<IPatientRepo, PatientRepe>();
            #endregion

            #region Identity Managers

            builder.Services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<DataContext>()
                .AddDefaultTokenProviders();

            builder.Services.AddScoped<UserManager<IdentityUser>>();
            builder.Services.AddScoped<SignInManager<IdentityUser>>();
            builder.Services.AddScoped<RoleManager<IdentityRole>>();

            #endregion

            #region Managers

            builder.Services.AddScoped<IAdminManager, AdminManager>();
            builder.Services.AddScoped<IPatientService, PatientService>();
            builder.Services.AddScoped<IDoctorManager, DoctorManager>();

            #endregion

            #region Authentication

            builder.Services.AddAuthentication(options =>
            {
                //Used Authentication Scheme
                options.DefaultAuthenticateScheme = "Authentication";

                //Used Challenge Authentication Scheme
                options.DefaultChallengeScheme = "Authentication";
            })
                .AddJwtBearer("Authentication", options =>
                {
                    var secretKeyString = builder.Configuration.GetValue<string>("SecretKey") ?? string.Empty;
                    var secretKeyInBytes = Encoding.ASCII.GetBytes(secretKeyString);
                    var secretKey = new SymmetricSecurityKey(secretKeyInBytes);

                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        IssuerSigningKey = secretKey,
                        ValidateIssuer = false,
                        ValidateAudience = false,
                    };
                });

            #endregion

            #region Authorization

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("Patient", policy =>
                    policy.RequireClaim(ClaimTypes.Role, "Patient")

                  );

                options.AddPolicy("Admin", policy =>
                    policy.RequireClaim(ClaimTypes.Role, "Admin")

                  );

                options.AddPolicy("Doctor", policy =>
                    policy.RequireClaim(ClaimTypes.Role, "Doctor"));
            });

            
            #endregion

            #region CORS
            builder.Services.AddCors();
            #endregion

            #region AutoMapper
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            #endregion

       

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            #region CORS 
            app.UseCors(policyBuilder => policyBuilder.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200"));
            #endregion

            app.MapControllers();

            app.Run();
        }
    }
}