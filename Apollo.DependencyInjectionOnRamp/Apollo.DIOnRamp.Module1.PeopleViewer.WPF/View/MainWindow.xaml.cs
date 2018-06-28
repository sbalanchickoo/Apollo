using Apollo.DIOnRamp.Module1.PeopleViewer.WPF.Model;
using Apollo.DIOnRamp.Module1.Shared.Interface;
using Apollo.DIOnRamp.Module1.ViewModel.CS;
using System.Windows;

namespace Apollo.DIOnRamp.Module1.PeopleViewer.WPF.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new PeopleViewModel();
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
