using Apollo.DIOnRamp.Module2.PeopleViewer.WPF.ViewModels;
using System.Windows;
using Apollo.DIOnRamp.Module2.Shared.Interfaces;

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
            var viewModel = new PeopleViewModel();
            Application.Current.MainWindow = new PeopleViewer(viewModel);
            Application.Current.MainWindow.Show();
        }
    }
}
