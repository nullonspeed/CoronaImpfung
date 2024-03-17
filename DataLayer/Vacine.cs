using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Vacine
    {
        public int VacineID { get; set; }
        public string Producer { get; set; }
        public int ChargerID { get; set; }

        public List<Vaccination> Vaccinations { get; set; } = new List<Vaccination>();
    }
}
