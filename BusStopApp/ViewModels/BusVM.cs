using BusStopApp.NewFolder1;
using BusStopApp.Views.BusView;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Bus = BusStopApp.Views.BusView.Bus;

namespace BusStopApp.ViewModels
{
    class BusVM : ViewModelBase
    {
        private ObservableCollection<NewFolder1.Bus> buses;

        public BusVM(ObservableCollection<Bus> buses) { Buses = buses; }

        public BusVM(ObservableCollection<NewFolder1.Bus> buses)
        {
            this.buses = buses;
        }

        public ObservableCollection<Bus> Buses { get; }

        public Bus PickedBus { get; set; } = new();

        public RelayCommand AddBusCommand
        {
            get => new RelayCommand(() =>
            {
                Window window = new AddBus();
                window.DataContext = new AddBusVM(Buses, window);
                window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                window.Show();
            });

        }
        public RelayCommand EditCarCommand
        {
            get => new RelayCommand(() =>
            {
                Window window = new EditBus();
                window.DataContext = new EditBusVM(PickedBus, window);
                window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                window.ShowDialog();
            });
        }

        public RelayCommand RemoveCarCommand
        {
            get => new RelayCommand(() =>
            {
                Buses.Remove(PickedBus);
            });
        }
    }
}
