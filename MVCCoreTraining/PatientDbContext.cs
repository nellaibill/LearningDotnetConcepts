using Microsoft.EntityFrameworkCore;
using MVCCoreTraining.Models;

namespace MVCCoreTraining
{
    public class PatientDbContext :DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Patient>().ToTable("tblPatient");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-C27U7D67\\SQLEXPRESS;Initial Catalog=EfCore;Integrated Security=True");
        }

        public DbSet<Patient> Patients { get; set; }
    }
}
