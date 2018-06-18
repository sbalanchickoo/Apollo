using System.Collections;
using System.Collections.Generic;
using System.Windows;
using Apollo.PersonLibrary.CS.Concretes;
using Apollo.PersonLibrary.CS.Interfaces;
using Apollo.PersonLibrary.CS.Models;

namespace Apollo.PeopleViewer.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IPersonRepository peopleRepo = new PeopleRepository();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetPeopleConcrete_Click(object sender, RoutedEventArgs e)
        {
            ClearPeopleBox();
            //Person[] people;
            List<Person> people;
            //people = peopleRepo.GetPeople();
            //PeopleBox.ItemsSource = people;
        }

        private void GetPeopleInterface_Click(object sender, RoutedEventArgs e)
        {
            ClearPeopleBox();
            IEnumerable<Person> people;
            people = peopleRepo.GetPeople();
            PeopleBox.ItemsSource = people;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearPeopleBox();
        }

        private void ClearPeopleBox()
        {
            //PeopleBox.Items.Clear();
            PeopleBox.ItemsSource = null;
        }
    }
}
