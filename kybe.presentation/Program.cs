using kybe.presentation.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace kybe.presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services
             .AddControllersWithViews()
             .AddRazorOptions(options =>
             {
                 options.ViewLocationFormats.Add(
                     "/Views/Pages/{1}/{0}.cshtml"
                 );

                 options.ViewLocationFormats.Add(
                     "/Views/Pages/{1}/{0}/Index.cshtml"
                 );

                 // ESSA AQUI
                 options.ViewLocationFormats.Add(
                     "/Views/Pages/{1}/{0}/{0}.cshtml"
                 );
             });
            builder.Services.AddDatabase(builder.Configuration);
            builder.Services.AddScoped();
            builder.Services
            .AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })

            .AddJwtBearer(options =>
            {
                var key = Encoding.UTF8.GetBytes(
                    builder.Configuration["Jwt:SecretKey"]!
                );

                options.TokenValidationParameters =
                    new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,

                        ValidIssuer = builder.Configuration["Jwt:Issuer"],
                        ValidAudience = builder.Configuration["Jwt:Audience"],

                        IssuerSigningKey = new SymmetricSecurityKey(key)
                    };


                options.Events = new JwtBearerEvents
                {
                    OnMessageReceived = context =>
                    {
                        context.Token = context.Request.Cookies["jwt"];

                        return Task.CompletedTask;
                    },

                    OnChallenge = context =>
                    {
                        context.HandleResponse();

                        context.Response.Redirect(
                            "/Auth/Login"
                        );

                        return Task.CompletedTask;
                    }
                };
            });

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
