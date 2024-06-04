using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Persistence
{
    public partial class DataContext : IdentityDbContext<User>
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<Coupon> Coupon { get; set; }
        public virtual DbSet<Discipline> Discipline { get; set; }
        public virtual DbSet<DisciplineAndTrainer> DisciplineAndTrainer { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<PackagePlan> PackagePlan { get; set; }
        public virtual DbSet<PackagePlanAndUser> PackagePlanAndUser { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Review> Review { get; set; }
        public virtual DbSet<Training> Training { get; set; }
        public virtual DbSet<TrainingAndWorkoutPlan> TrainingAndWorkoutPlan { get; set; }
        public virtual DbSet<WorkoutPlan> WorkoutPlan { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseSqlServer(
        //"Server=SportSpecialistDB;Database=sport_specialist_db;User Id=sa;Password=adminSql2023;TrustServerCertificate=true;");
        "Data Source=PC-SMITH\\SQLEXPRESS;Initial Catalog=sport_specialist_db;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}