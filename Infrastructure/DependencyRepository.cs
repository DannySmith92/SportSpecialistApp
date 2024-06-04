using Application.Repositories;
using Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class DependencyRepository
    {
        public static void AddRepository(this IServiceCollection services)
        {
            services.AddScoped<I_AppointmentRepository, AppointmentRepository>();
            services.AddScoped<I_CouponRepository, CouponRepository>();
            services.AddScoped<I_DisciplineAndTrainerRepository, DisciplineAndTrainerRepository>();
            services.AddScoped<I_DisciplineRepository, DisciplineRepository>();
            services.AddScoped<I_OrderRepository, OrderRepository>();
            services.AddScoped<I_PackagePlanAndUserRepository, PackagePlanAndUserRepository>();
            services.AddScoped<I_PackagePlanRepository, PackagePlanRepository>();
            services.AddScoped<I_PaymentRepository, PaymentRepository>();
            services.AddScoped<I_ReviewRepository, ReviewRepository>();
            services.AddScoped<I_TrainingAndWorkoutPlanRepository, TrainingAndWorkoutPlanRepository>();
            services.AddScoped<I_TrainingRepository, TrainingRepository>();
            services.AddScoped<I_UserRepository, UserRepository>();
            services.AddScoped<I_WorkoutPlanRepository, WorkoutPlanRepository>();
            
        }
    }
}
