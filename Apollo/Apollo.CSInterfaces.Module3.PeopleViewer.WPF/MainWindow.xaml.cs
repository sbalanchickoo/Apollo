using System.Collections.Generic;
using System.Windows;

namespace Apollo.CSInterfaces.Module3.PeopleViewer.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //IPersonRepository peopleRepo = new PeopleRepository();
        
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
            //PeopleBox.ItemsSource = peopleRepo.GetPeople();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearPeopleBox();
        }

        private void ClearPeopleBox()
        {
            //PeopleBox.Items.Clear();
            //PeopleBox.ItemsSource = null;
        }
    }
}
