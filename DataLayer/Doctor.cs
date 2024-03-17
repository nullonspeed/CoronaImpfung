
namespace DataLayer
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string Title { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public List<Vaccination> Vaccinations { get; set; } = new List<Vaccination>();
    }

}
