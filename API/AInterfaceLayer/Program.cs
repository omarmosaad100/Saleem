using BBussinesLogicLayer.Managers.Admin;
using CDataAccessLayer.Data;
using CDataAccessLayer.Repos;
using Microsoft.EntityFrameworkCore;

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
            #endregion

            #region Managers
            builder.Services.AddScoped<IAdminManager, AdminManager>();
            #endregion

            #region CORS
            builder.Services.AddCors();
            #endregion


            var app = builder.Build();

            //// Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //app.UseHttpsRedirection();

            //app.UseAuthorization();

            #region CORS 
            app.UseCors(policyBuilder => policyBuilder.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200"));
            #endregion

            app.MapControllers();

            app.Run();
        }
    }
}