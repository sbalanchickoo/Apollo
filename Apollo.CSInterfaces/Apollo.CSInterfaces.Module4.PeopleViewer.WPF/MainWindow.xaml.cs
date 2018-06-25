using Apollo.CSInterfaces.Module4.Interfaces.CS;
using System.Windows;

namespace Apollo.CSInterfaces.Module4.PeopleViewer.WPF
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

        private void GetPeople_Click(object sender, RoutedEventArgs e)
        {
            ClearPeopleBox();
            IPersonRepository peopleRepo;
            peopleRepo = RepositoryFactory.GetRepository();
            PeopleBox.ItemsSource = peopleRepo.GetPeople();
            ShowRepositoryType(peopleRepo);
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
