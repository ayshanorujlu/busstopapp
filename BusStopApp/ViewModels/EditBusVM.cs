using BusStopApp.Views.BusView;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace BusStopApp.ViewModels
{
    class EditBusVM : ViewModelBase
    {
        public Bus? bus;

        private Bus? pickedBus;
        private Window? window;


        public Bus? Bus
        {
            get => bus;
            set { Set(ref bus, value); }
        }
        public Bus TemplateBus { get; set; } = new();

        public Window CurrentWindow { get; set; }
        private void Set(ref Bus? bus, Bus value)
        {
            throw new NotImplementedException();
        }


        public EditBusVM(Bus pickedBus, Window window,Bus templateBus, Window currentWindow)
        {
            this.pickedBus = pickedBus;
            this.window = window;
            Bus = new();
            TemplateBus = templateBus;
            Bus.Model = TemplateBus.Model;
            Bus.Vendor = TemplateBus.Vendor;
            Bus.SeriaNo = TemplateBus.SeriaNo;
            Bus.SeatCount = TemplateBus.SeatCount;
            CurrentWindow = currentWindow;
        }

        public EditBusVM(Bus pickedBus, Window window)
        {
            this.pickedBus = pickedBus;
            this.window = window;
        }
    }

    }

