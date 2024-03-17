using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class VaccinationContext :DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Vacine> Vacines { get; set; }
        public DbSet<Vaccination> Vacine { get; set; }

        public VaccinationContext(DbContextOptions<VaccinationContext> options):base(options)
        {
            
        }
        public VaccinationContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Console.WriteLine($"DB OnConfiguring: IsConfigured={optionsBuilder.IsConfigured}");
            if(optionsBuilder!=null&& !optionsBuilder.IsConfigured)
            {
                string conStr = @"server=(LocalDB)\mssqllocaldb;attachdbfilename=
                                C:\Users\Anwender\source\repos\CoronaImpfung\DataLayer\HosDBGrpA.mdf; 
                                database=HosDBGRpB;integrated security=True;MultipleActiveResultSets=True;";
                Console.WriteLine($"Using ConnStr ={conStr}");
                optionsBuilder.UseSqlServer(conStr);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
