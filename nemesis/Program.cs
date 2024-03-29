using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using nemesis.Models.Contexts;
using nemesis.Models.Interfaces;
using nemesis.Models.Repositories;
using nemesis.Services;

namespace nemesis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddLogging(options =>
            {
                options.ClearProviders();
                options.AddConsole();
            });

            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DevDbConnection") ?? throw new InvalidOperationException("missing connection string"));
            });

            builder.Services.AddDefaultIdentity<IdentityUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 8;


                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                options.User.RequireUniqueEmail = true;
                
            }).AddRoles<IdentityRole>().AddEntityFrameworkStores<AppDbContext>();

            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                options.SlidingExpiration = true;
            });

            builder.Services.AddTransient<IEmailSender, EmailSender>();
            builder.Services.Configure<AuthMessageSenderOptions>(builder.Configuration);

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
            builder.Services.AddTransient<IInvestigationRepository, InvestigationRepository>();
            builder.Services.AddTransient<IHallOfFameRepository, HallOfFameRepository>();


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
            app.UseStatusCodePages();
            app.UseRouting();

            app.UseAuthentication(); 
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapRazorPages();
            app.Run();
        }
    }
}