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

namespace BusStopApp.Views.BusView
{
    /// <summary>
    /// Interaction logic for Bus.xaml
    /// </summary>
    public partial class Bus : Page
    {
        public Bus()
        {
            InitializeComponent();
        }

        public object SeriaNo { get; internal set; }
        public object Vendor { get; internal set; }
        public object Model { get; internal set; }
        public int SeatCount { get; internal set; }
    }
}
