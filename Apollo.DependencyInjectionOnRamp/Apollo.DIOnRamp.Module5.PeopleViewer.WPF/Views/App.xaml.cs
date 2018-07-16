using System.Windows;
using Apollo.DIOnRamp.Module5.PeopleViewer.WPF.Models;
using Apollo.DIOnRamp.Shared.Interfaces;
using Unity;
using Unity.Lifetime;
using Ninject;
using Microsoft.Practices.Unity.Configuration;

namespace Apollo.DIOnRamp.Module5.PeopleViewer.WPF.Views
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        IUnityContainer Container;
        //IKernel Container2;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ConfigureContainer();
            ComposeObjects();
            Application.Current.MainWindow.Show();
        }

        private void ConfigureContainer()
        {
            Container = new UnityContainer();
            //Container.LoadConfiguration();
            Container.RegisterType<IPersonRepository, ServiceRepoDecorator>(
                new ContainerControlledLifetimeManager());
            Container.RegisterType<IPersonRepositorySource, ServiceRepo>(
                new ContainerControlledLifetimeManager());

            //Container2 = new StandardKernel();
            //Container2.Bind<IPersonRepository>().To<ServiceRepoDecorator>()
            //    .InSingletonScope();
            //Container2.Bind<IPersonRepositorySource>().To<ServiceRepo>()
            //    .InSingletonScope();
        }

        private void ComposeObjects()
        {
            Application.Current.MainWindow = Container.Resolve<PeopleViewerWindow>();
            Application.Current.MainWindow.Title = "Loose Coupling - People Viewer - DI Unity";

            //Application.Current.MainWindow = Container2.Get<PeopleViewerWindow>();
            //Application.Current.MainWindow.Title = "Loose Coupling - People Viewer - DI Ninject";
        }
    }
}
