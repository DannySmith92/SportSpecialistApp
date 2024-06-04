
using Application.Services.Authorization;
using Domain.Services.Authorization;
using Microsoft.Extensions.DependencyInjection;


namespace Application
{
    public static class Dependency_Auth
    {
        public static void AddJwtInt(this IServiceCollection services)
        {
            services.AddScoped<IJwtAuthenticationManager, JwtAuthenticationManager>();
        }
    }
}