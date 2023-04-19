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
using BBussinesLogicLayer.Managers.Patient;
using CDataAccessLayer.Repos.Patient;
using CDataAccessLayer.Data.Models;
using BBussinesLogicLayer.Dtos.Patients;

namespace AInterfaceLayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
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
            builder.Services.AddScoped<IPatientService, PatientService>();
            builder.Services.AddScoped<IPatientRepo, PatientRepe>();
            #endregion

            #region Identity Managers

            //builder.Services.AddIdentity<PatientRegisterDto, IdentityRole>(options =>
            //{
            //    options.Password.Requireduniquechars = 3;
            //    options.Password.Requireuppercase = false;
            //    options.Password.Requirelowercase = false;
            //    options.Password.Requirenonalphanumeric = false;

            //    options.User.RequireUniqueEmail = true;
            //})
            //    .AddEntityFrameworkStores<DataContext>();

            #endregion

            #region Authentication

            builder.Services.AddAuthentication(options =>
            {
                //Used Authentication Scheme
                options.DefaultAuthenticateScheme = "CoolAuthentication";

                //Used Challenge Authentication Scheme
                options.DefaultChallengeScheme = "CoolAuthentication";
            })
                .AddJwtBearer("CoolAuthentication", options =>
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
                options.AddPolicy("PatientData", policy => policy
                    .RequireClaim(ClaimTypes.Role, UserRoles.Patient, UserRoles.Doctor));
            });

            #endregion

            #region Managers
            //builder.Services.AddScoped<IUsersManager , UsersManager>();

            builder.Services.AddIdentity<IdentityUser, IdentityRole>()
                    .AddEntityFrameworkStores<DataContext>()
                    .AddDefaultTokenProviders();

            builder.Services.AddScoped<UserManager<IdentityUser>>();
            builder.Services.AddScoped<SignInManager<IdentityUser>>();
            builder.Services.AddScoped<RoleManager<IdentityRole>>();

            builder.Services.AddScoped<IAdminManager, AdminManager>();
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