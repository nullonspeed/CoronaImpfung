using DataLayer;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViewModel;

namespace CoronaImpfung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public VaccinationContext context { get; set; }
        int countofvaccines=0;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                context = new VaccinationContext();
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                this.DataContext = new Viewmodel().Init(context);
                Title = context.Vacines.Count().ToString();
                countofvaccines = context.Vacine.Count();
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex);
            }

           
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (test1.SelectedItem!=null && test2.SelectedItem != null && test3.SelectedDate != null && test4.SelectedItem != null) 
            { 
                buttoneinfuegen.IsEnabled = true;
            }
            else
            {
                buttoneinfuegen.IsEnabled = false;
            }


        }

        private void buttoneinfuegen_Click(object sender, RoutedEventArgs e)
        {
            countofvaccines++;
            //context.Vacine.Add(new Vaccination() {AdverseEffects="test",VaccinationID=countofvaccines, VacDateTime = test3.DisplayDate, DoctorDoctorID=((Doctor)test2.SelectedItem).DoctorID, PatientPatientID = ((DisplayPatient)test4.SelectedItem).patientID , VacineVacineID = ((Vacine)test1.SelectedItem).VacineID});
            ((Viewmodel)this.DataContext).newVaccine(new Vaccination() { AdverseEffects = "test", VaccinationID = countofvaccines, VacDateTime = test3.DisplayDate, DoctorDoctorID = ((Doctor)test2.SelectedItem).DoctorID, PatientPatientID = ((DisplayPatient)test4.SelectedItem).patientID, VacineVacineID = ((Vacine)test1.SelectedItem).VacineID });

        }
    }
}