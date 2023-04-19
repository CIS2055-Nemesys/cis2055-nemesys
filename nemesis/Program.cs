using Microsoft.EntityFrameworkCore;
using nemesis.Models.Contexts;
using nemesis.Models.Interfaces;
using nemesis.Models.Repositories;

namespace nemesis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DevDbConnection") ?? throw new InvalidOperationException("missing connection string"));
            });

            /*if (builder.Environment.IsDevelopment())
            {
                builder.Services.AddSingleton<IReportRepository, MockReportRepository>();
                builder.Services.AddSingleton<IInvestigationRepository,MockInvestigationRepository>();
                builder.Services.AddSingleton<IUserRepository,MockUserRepository>();

            }
            if (builder.Environment.IsProduction())
            {
                builder.Services.AddSingleton<IReportRepository, MockReportRepository>();
                builder.Services.AddSingleton<IInvestigationRepository, MockInvestigationRepository>();
                builder.Services.AddSingleton<IUserRepository, MockUserRepository>();
            }*/

            builder.Services.AddTransient<IReportRepository, ReportRepository>();


            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}