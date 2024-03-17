using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class VacDBSeedExtention
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Console.WriteLine("Db seeding:...");
            Patient p1 = new Patient { PatientID = 1, Firstname = "Sebastian", Lastname = "L-Schneider", DateOfBirth = new DateTime(1987, 01, 01), isMale = true };
            Patient p2 = new Patient { PatientID = 2, Firstname = "Celina", Lastname = "Weisenböck", DateOfBirth = new DateTime(2004, 06, 17), isMale = false };

            modelBuilder.Entity<Patient>().HasData(p1);
            modelBuilder.Entity<Patient>().HasData(p2);

            Doctor d1 = new Doctor { DoctorID = 1, Firstname = "Hannes", Lastname = "Sekoti", Title = "Dr. Oberchecker" };
            Doctor d2 = new Doctor { DoctorID = 2, Firstname = "Ben", Lastname = "Haupert", Title = "Dr. Oberchecker" };

            modelBuilder.Entity<Doctor>().HasData(d1);
            modelBuilder.Entity<Doctor>().HasData(d2);

            Vacine v1 = new Vacine { VacineID = 1, Producer = "Onkel Sepi", ChargerID = 1 };
            Vacine v2 = new Vacine { VacineID = 2, Producer = "Kesko20", ChargerID = 2 };

            modelBuilder.Entity<Vacine>().HasData(v1);
            modelBuilder.Entity<Vacine>().HasData(v2);

            modelBuilder.Entity<Vaccination>().HasData(new Vaccination
            {
                VaccinationID = 1,
                VacineVacineID = 1,
                VacDateTime = new DateTime(2024, 01, 17),
                DoctorDoctorID = 1,
                PatientPatientID = 1,
                AdverseEffects = "de gibts a"
            }
            );

            modelBuilder.Entity<Vaccination>().HasData(new Vaccination
            {
                VaccinationID = 2,
                VacineVacineID = 2,
                VacDateTime = new DateTime(2024, 01, 17),
                DoctorDoctorID = 2,
                PatientPatientID = 2,
                AdverseEffects = "de gibts a"

                
            }
            );
        }
    }
}
