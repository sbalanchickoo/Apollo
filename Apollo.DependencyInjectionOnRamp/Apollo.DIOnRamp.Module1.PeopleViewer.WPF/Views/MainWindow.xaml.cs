using Apollo.DIOnRamp.Module1.PeopleViewer.WPF.ViewModels;
using System.Windows;

namespace Apollo.DIOnRamp.Module1.PeopleViewer.WPF.Views
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
    }
}
