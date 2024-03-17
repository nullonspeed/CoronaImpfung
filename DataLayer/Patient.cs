using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public bool isMale { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Vaccination> Vaccinations { get; set; } = new List<Vaccination>();
    }
}
