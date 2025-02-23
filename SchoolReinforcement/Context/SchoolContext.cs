using Microsoft.EntityFrameworkCore;
using SchoolReinforcement.Entities;
using System.Data.Entity;

namespace SchoolReinforcement.Context
{
    public class SchoolContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<Student> Students { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<AcademicHistory> AcademicHistories { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Subject> Subjects { get; set; }

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.AcademicHistory)
                .WithOne()
                .HasForeignKey<Student>(s => s.AcademicHistoryId);

            modelBuilder.Entity<AcademicHistory>()
                .HasMany(a => a.Subjects)
                .WithOne(s => s.AcademicHistory)
                .HasForeignKey(s => s.AcademicHistoryId);
        }
    }
}
