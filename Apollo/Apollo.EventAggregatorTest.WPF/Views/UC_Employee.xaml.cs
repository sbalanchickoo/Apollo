using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EventAggregatorTest.ViewModels;
using Prism.Events;
using EventAggregatorTest.Models;

namespace EventAggregatorTest.Views
{
    /// <summary>
    /// Interaction logic for UC_Employee.xaml
    /// </summary>
    public partial class UC_Employee : UserControl
    {
        public UC_Employee()
        {
            InitializeComponent();
            this.DataContext = new UC_Employee_ViewModel(Event.EventInstance.EventAggregator);
        }
    }
}
