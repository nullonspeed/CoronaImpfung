
using DataLayer;
using System.Windows.Input;

namespace ViewModel
{
    public class Viewmodel :ObservableObject
    {
        public VaccinationContext? DB { get; set; }
        public Viewmodel Init(VaccinationContext newDB)
        { 
            DB = newDB;
            VacineList = DB.Vacines.OrderByDescending(x=>x.Producer).ToList();
            Doctors= DB.Doctors.OrderByDescending(x => x.Lastname).ToList();
            Patienten = DB.Patients.Select(x=> new DisplayPatient() {
            patientID = x.PatientID,
            Firstname = x.Firstname, Lastname = x.Lastname,
            isMale = x.isMale,
            DateOfBirth=x.DateOfBirth,
            countVacines =x.Vaccinations.Count()
            }
            ).ToList();
            return this; 
        }

        public void newVaccine(Vaccination vc)
        {
            if (DB != null)
            {
                DB.Vacine.Add(vc);
                Patienten.Where(x=>x.patientID==vc.PatientPatientID).First().countVacines= DB.Patients.Where(x => x.PatientID == vc.PatientPatientID).First().Vaccinations.Count();
               
                
                RaisePropertyChangedEvent(nameof(VacineList));
                RaisePropertyChangedEvent(nameof(Doctors));
                RaisePropertyChangedEvent(nameof(Patienten));
            }
            
        }
       

        private ICollection<Vacine> vacineList;

        public ICollection<Vacine> VacineList
        {
            get { return vacineList; }
            set { 
                vacineList = value;
                RaisePropertyChangedEvent(nameof(VacineList));
            }
            
        }

        private Vacine selectedVacine;

        public Vacine SelectedVacine
        {
            get { return selectedVacine; }
            set {
                selectedVacine = value;
                RaisePropertyChangedEvent(nameof(SelectedVacine));
            }
        }

        private ICollection<Doctor> doctors;

        public ICollection<Doctor> Doctors
        {
            get { return doctors; }
            set { doctors = value;
            RaisePropertyChangedEvent(nameof(Doctors));
            }
        }

        private Doctor selectedDoctor;

        public Doctor SelectedDoctor
        {
            get { return selectedDoctor; }
            set { selectedDoctor = value;
            RaisePropertyChangedEvent(nameof(SelectedDoctor));
            }
        }

        private DateTime selectedDateTime;

        public DateTime SelectedDateTime
        {
            get { return selectedDateTime; }
            set { selectedDateTime = value;
                RaisePropertyChangedEvent(nameof(SelectedDateTime));

            }
        }

        private ICollection<DisplayPatient> patienten;

        public ICollection<DisplayPatient> Patienten
        {
            get { return patienten; }
            set { patienten = value; 
            RaisePropertyChangedEvent(nameof(Patienten));
            }
        }

        private DisplayPatient selectedPatient;

        public DisplayPatient SelectedPatient
        {
            get { return selectedPatient; }
            set { selectedPatient = value;
            RaisePropertyChangedEvent(nameof(SelectedPatient));        
            }
        }

        





    }

}
