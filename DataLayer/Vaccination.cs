using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Vaccination
    {
        public int VaccinationID { get; set; }
        public DateTime VacDateTime { get; set; }
        public string AdverseEffects { get; set; }

        public int PatientPatientID { get; set; }
        public Patient? Patient_Patient { get; set; }
        public int DoctorDoctorID { get; set; }
        public Doctor? Doctor_Doctor { get; set; }

        public int VacineVacineID { get; set; }
        public Vacine? Vacine_Vacine { get; set; }
    }
}
