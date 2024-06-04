using Domain.Entities;
using Application;
using Infrastructure;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi
{
    public static class ConfigureService
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {

            //string? firebaseProjectName = configuration.GetValue<string>("FirebaseProjectName");
            //string? firebaseApiKey = configuration.GetValue<string>("FirebaseApiKey");
            //string? firebaseAppId = configuration.GetValue<string>("FirebaseAppId");

            //Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "google_cloud_credentials.json");
            //services.AddSingleton(FirebaseApp.Create());
            //services.AddSingleton(FirestoreDb.Create(firebaseAppId));



            #region Swagger
            services.AddSwaggerGen(c =>
            {
                c.IncludeXmlComments(string.Format(@"{0}/WebApi.xml", AppDomain.CurrentDomain.BaseDirectory));
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "U-Wander",
                });

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Bearer {token}\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                },
                new string[] { }
            }
        });
            });
            #endregion
            #region Api Versioning
            services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
            });
            #endregion

            #region Jwt

            #endregion
            #region User Identity
            services.AddIdentity<User, IdentityRole>(cfg =>
            {
                cfg.Tokens.AuthenticatorTokenProvider = TokenOptions.DefaultAuthenticatorProvider;
                cfg.SignIn.RequireConfirmedEmail = true;
                cfg.User.RequireUniqueEmail = true;
                cfg.Password.RequireDigit = false;
                cfg.Password.RequiredUniqueChars = 0;
                cfg.Password.RequireLowercase = false;
                cfg.Password.RequireNonAlphanumeric = false;
                cfg.Password.RequireUppercase = false;
                cfg.Password.RequiredLength = 6;
            })
            .AddDefaultTokenProviders()
            .AddEntityFrameworkStores<DataContext>();
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("sport-specialist-federicocarminedannysportspecilisT")),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = "https://SportSpecialist.com",
                    ValidAudience = "https://SportSpecialist.com"
                };
            });
            services.AddDbContext<DataContext>(cfg =>
            {
                cfg.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            #endregion
            //services.AddApplication(firebaseApiKey, firebaseAppId, configuration);
            services.AddRepository();
            services.AddJwtInt();
            services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            });
            services.AddEndpointsApiExplorer();

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/NotAuthorized";
                options.AccessDeniedPath = "/Account/NotAuthorized";
            });
        }

        public static void Configure(WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
            #region Swagger
            app.UseSwagger(c =>
            {
                c.PreSerializeFilters.Add((swaggerDoc, httpRequest) =>
                {
                    if (!httpRequest.Headers.ContainsKey("X-Forwarded-Host")) return;
                    var basePath = "proxy";
                    var serverUrl = $"{httpRequest.Scheme}://{httpRequest.Headers["X-Forwarded-Host"]}/{basePath}";
                    swaggerDoc.Servers = new List<OpenApiServer> { new OpenApiServer { Url = serverUrl } };
                });
            });
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "SportSpecialist");
            });
            #endregion
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();
            app.MapControllers();


        }
    }
}
