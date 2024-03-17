using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class DisplayPatient
    {
        public int patientID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public bool isMale { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int countVacines { get; set; }

    }
}
