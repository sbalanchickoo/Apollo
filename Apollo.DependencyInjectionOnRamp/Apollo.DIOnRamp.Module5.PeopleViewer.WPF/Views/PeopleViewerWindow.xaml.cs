using Apollo.DIOnRamp.Module3.PeopleViewer.WPF.ViewModels;
using System.Windows;

namespace Apollo.DIOnRamp.Module3.PeopleViewer.WPF.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class PeopleViewerWindow : Window
    {
        
        public PeopleViewerWindow(PeopleViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
