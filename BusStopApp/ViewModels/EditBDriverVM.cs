using BusStopApp.NewFolder1;
using BusStopApp.Views.BusDriverView;
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

namespace BusStopApp.ViewModels
{
    public class EditBDriverVM : ViewModelBase
    {
        private BusDriver? pickedDriver;
        private ObservableCollection<Bus>? buses;
        

        private BusDriver? busDriver;

        public Bus? PickedBus
        { get; set; }

        public BusDriver? BusDriver { get => busDriver; set => Set(ref busDriver, value); }

        public ObservableCollection<Bus>? Buses { get; set; }

        public BusDriver? TemplateBusDriver { get; set; }

        public Window? Window { get; set; }
        public EditBDriverVM(BusDriver? busDriver, ObservableCollection<Bus> buses, Window window)
        {
            this.buses = buses;
            TemplateBusDriver = busDriver;
            PickedBus = busDriver.Bus;
            busDriver.Bus = busDriver.Bus;
            BusDriver.Name = busDriver.Name;
            BusDriver.Surname = busDriver.Surname;
            BusDriver.Address = busDriver.Address;
            BusDriver = new();
            Window = window;
        }
        public RelayCommand SaveCommand
        {
            get => new RelayCommand(() =>
            {
                if (BusDriver?.Address != string.Empty && BusDriver?.Name != string.Empty && BusDriver?.Surname != string.Empty && PickedBus != null)
                {
                    TemplateBusDriver.Bus = PickedBus;
                    TemplateBusDriver.Name = BusDriver.Name;
                    TemplateBusDriver.Surname = BusDriver.Surname;
                    TemplateBusDriver.Address = BusDriver.Address;
                    Window.Close();
                }
                else
                    MessageBox.Show("", "BusStopApp", MessageBoxButton.OK, MessageBoxImage.Error);
            });
        }
    }
}
