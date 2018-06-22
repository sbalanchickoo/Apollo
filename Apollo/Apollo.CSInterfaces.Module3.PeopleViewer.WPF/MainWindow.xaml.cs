using Apollo.CSInterfaces.Module3.Interfaces.CS;
using System.Collections.Generic;
using System.Windows;
using Apollo.CSInterfaces.Module3.ServiceRepository.CS.ServiceReference1;

namespace Apollo.CSInterfaces.Module3.PeopleViewer.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IPersonRepository peopleRepo;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetPeopleConcrete_Click(object sender, RoutedEventArgs e)
        {
            ClearPeopleBox();
            //IEnumerable<Person> people = peopleRepo.GetPeople();
            //PeopleBox.ItemsSource = people;
        }

        private void GetPeopleInterface_Click(object sender, RoutedEventArgs e)
        {
            ClearPeopleBox();
            peopleRepo = new ServiceRepository.CS.ServiceRepository();
            PeopleBox.ItemsSource = peopleRepo.GetPeople();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearPeopleBox();
        }

        private void ClearPeopleBox()
        {
            PeopleBox.ItemsSource = null;
        }
    }
}
