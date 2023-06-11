using BusStopApp.Views.BusView;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Windows;

namespace BusStopApp.ViewModels
{
    public class AddBusVM : ViewModelBase
    {
        private Bus bus = new();


        public ObservableCollection<Bus> buses;

        private Window CurrentWindow { get; set; }

        public AddBusVM(ObservableCollection<Bus> buses, Window window)
        {
            this.Buses = buses;
            this.CurrentWindow = window;
        }

        public Bus Bus
        {
            get { return bus; }
            set { Set(ref bus, value); }
        }
        public ObservableCollection<Bus> Buses { get => buses; set => buses = value; }

        public RelayCommand CreateCommand
        {
            get => new RelayCommand(() =>
            {
                Regex regex = new("([A-Za-z0-9]+(-[A-Za-z0-9]+)+)");
                if (bus.SeriaNo != null && bus.Vendor != null && bus.Model != null)
                {
                    if (regex.IsMatch((string)bus.SeriaNo) && bus.SeatCount > 0 && bus.Vendor != string.Empty && bus.Model != string.Empty)
                    {
                        buses.Add(bus);
                        CurrentWindow.Close();
                    }
                    else
                        MessageBox.Show("", "BusStopApp", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                    MessageBox.Show("", "BusStopApp", MessageBoxButton.OK, MessageBoxImage.Error);
            });
        }
    }
}