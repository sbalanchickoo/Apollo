using Apollo.DIOnRamp.Module2.PeopleViewer.WPF.ViewModels;
using System.Windows;
using Apollo.DIOnRamp.Module2.PeopleViewer.WPF.Models;

namespace Apollo.DIOnRamp.Module2.PeopleViewer.WPF.Views
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var repo = RepositoryFactory.GetRepository();
            var viewModel = new PeopleViewModel(repo);
            Application.Current.MainWindow = new PeopleViewerWindow(viewModel);
            Application.Current.MainWindow.Show();
            Application.Current.MainWindow.Title = "Loose Coupling - People Viewer";
        }
    }
}
