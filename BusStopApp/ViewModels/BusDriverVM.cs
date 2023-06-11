using BusStopApp.NewFolder1;
using BusStopApp.Views.BusDriverView;
using BusStopApp.Views.BusView;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BusStopApp.ViewModels
{
    class BusDriverVM : ViewModelBase
    {
        public ObservableCollection<NewFolder1.Bus> Buses { get; set; } 
        public ObservableCollection<BusDriver> BusDrivers { get; set; } 
        

        public BusDriver? PickedDriver { get; set; }

        public BusDriverVM(ObservableCollection<NewFolder1.Bus> buses,ObservableCollection<BusDriver>busDrivers) { BusDrivers = busDrivers; Buses = buses; }

        public RelayCommand AddDriverCommand => new RelayCommand(
                () =>
                {
                    Window window = new AddDriver();
                    window.DataContext = new AddBusDriverVM(BusDrivers, Buses, window);
                    window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    window.Show();
                });

        public RelayCommand EditDriverCommand
        {
            get => new RelayCommand(
                () => {
                    Window window = new EditDriver();
                    window.DataContext = new EditBDriverVM(PickedDriver, Buses, window);
                    window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    window.Show();
                });
        }

        public RelayCommand RemoveDriverCommand
        {
            get => new RelayCommand(
                () => {
                    BusDrivers.Remove(PickedDriver);
                });
        }

    }

    internal class EditBusDriverVM
    {
        private BusDriver? PickedDriver;
        private ObservableCollection<NewFolder1.Bus> buses;
        private Window window;

        public EditBusDriverVM(BusDriver? pickedDriver, ObservableCollection<NewFolder1.Bus> buses, Window window)
        {
            this.PickedDriver = pickedDriver;
            this.buses = buses;
            this.window = window;
        }

      

        public ObservableCollection<NewFolder1.Bus> Buses { get; }
    }

  
}
