using System.Windows;
using Apollo.DIOnRamp.Module5.PeopleViewer.WPF.Models;
using Apollo.DIOnRamp.Shared.Interfaces;
using Unity;
using Unity.Lifetime;

namespace Apollo.DIOnRamp.Module5.PeopleViewer.WPF.Views
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        IUnityContainer Container;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ConfigureContainer();
            ComposeObjects();
            Application.Current.MainWindow.Show();
            Application.Current.MainWindow.Title = "Loose Coupling - People Viewer - DI Unity";
        }

        private void ConfigureContainer()
        {
            Container = new UnityContainer();
            Container.RegisterType<IPersonRepository, ServiceRepoDecorator>(
                new ContainerControlledLifetimeManager());
            Container.RegisterType<IPersonRepositorySource, ServiceRepo>(
                new ContainerControlledLifetimeManager());
        }

        private void ComposeObjects()
        {
            Application.Current.MainWindow = Container.Resolve<PeopleViewerWindow>();
        }
    }
}
