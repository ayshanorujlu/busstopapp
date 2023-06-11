using BusStopApp.NewFolder1;
using BusStopApp.Views.BusDriverView;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BusStopApp.ViewModels
{
    class AddBusDriverVM:ViewModelBase
    {
        private ObservableCollection<BusDriver> busDrivers;
        private ObservableCollection<Bus> buses;
        private Window window;
        private ObservableCollection<BusDriver> busDrivers1;
        private ObservableCollection<Bus> buses1;

        public AddBusDriverVM(ObservableCollection<BusDriver> busDrivers, ObservableCollection<Bus> buses, Window window)
        {
            BusDriver = new();
            BusDrivers = busDrivers;
            Buses = buses;
            CurrentWindow = window;
        }

        private BusDriver busDriver;
        public BusDriver BusDriver
        {
            get => BusDriver;
            set { Set(ref busDriver, value); }
        }

        private void Set(ref BusDriver busDriver, BusDriver value)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<BusDriver> BusDrivers { get; set; }

        public ObservableCollection<Bus> Buses { get; set; }

        public Bus SelectedItem { get; set; }

        public Window CurrentWindow { get; set; }
        public RelayCommand CreateCommand
        {
            get => new RelayCommand(() =>
            {
                if (busDriver.Address != null && busDriver.Name != null && busDriver.Surname != null && SelectedItem != null)
                {
                    busDriver.Bus = SelectedItem;
                    BusDrivers.Add(busDriver);
                    CurrentWindow.Close();
                }
                else
                    MessageBox.Show("", "BusStopApp", MessageBoxButton.OK, MessageBoxImage.Error);
            });
        }

    }
}
