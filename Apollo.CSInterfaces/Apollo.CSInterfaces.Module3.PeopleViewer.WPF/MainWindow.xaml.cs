using Apollo.CSInterfaces.Module3.Interfaces.CS;
using System.Windows;

namespace Apollo.CSInterfaces.Module3.PeopleViewer.WPF
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

        private void GetPeopleCSV_Click(object sender, RoutedEventArgs e)
        {
            ClearPeopleBox();
            IPersonRepository peopleRepo = FetchRepo("CSV");
            PeopleBox.ItemsSource = peopleRepo.GetPeople();
            ShowRepositoryType(peopleRepo);
        }

        private void GetPeopleService_Click(object sender, RoutedEventArgs e)
        {
            ClearPeopleBox();
            IPersonRepository peopleRepo = FetchRepo("Service");
            PeopleBox.ItemsSource = peopleRepo.GetPeople();
            ShowRepositoryType(peopleRepo);
        }

        private IPersonRepository FetchRepo(string repoType)
        {
            IPersonRepository peopleRepo;
            peopleRepo = RepositoryFactory.GetRepository(repoType);
            return peopleRepo;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearPeopleBox();
        }

        private void ClearPeopleBox()
        {
            PeopleBox.ItemsSource = null;
        }

        private void ShowRepositoryType(IPersonRepository repository)
        {
            MessageBox.Show(string.Format("Repository Type:\n{0}",
                repository.GetType().ToString()));
        }
    }
}
