using BusStopApp.NewFolder1;
using BusStopApp.ViewModels;
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
using System.Windows.Controls;

namespace BusStopApp.ViewModels
{
    class MainViewModel:ViewModelBase
    {
        public ObservableCollection<Bus> Buses { get; set; } = new();
        public ObservableCollection<BusDriver> BusDrivers { get; set; } = new();
        public ObservableCollection<Student> Students { get; set; } = new();
        public ObservableCollection<Drive> Drives { get; set; } = new();


        private Page? cPage;

        public Page? CPage
        {
            get => cPage;
            set => Set(ref cPage, value);
        }


        public MainViewModel()
        {
            Buses = new() {
                new Bus("Volvo","XC 90","42-zz-042",15),
                new Bus("Bmw","327","10-zz-010",12),
                new Bus("Tesla","model x","77-zz-777",10),
            };
            BusDrivers = new() {
                new BusDriver("Kamil","Agayev","Baku",new Bus("Volvo","XC 90","42-zz-042",15)),
                new BusDriver("Nergiz","Mustafazade","Baku",new Bus("Bmw","327","10-zz-010",12)),
                new BusDriver("Ayshan","Oruclu","Baku",new Bus("Tesla","model x","77-zz-777",10))
            };

            Students = new()
            {
                new Student(2,"Huseyn","Aliyev","200","Ziya,04,Baku"),
                new Student(1,"ALi","Aliyev","100","Qara Qarayev,Nizami, Baku"),
                new Student(3,"Aqil","Qarayev","300","27 Afiyəddin Cəlilov, Baku, Baku"),
            };
            CPage = new Page() { DataContext = this };
        }

        public RelayCommand BusPageCommand
        {
            get => new RelayCommand(() => {
                CPage = App.Container.GetInstance<Bus>();
                CPage.DataContext = new PageViewModel(Buses);
            });
        }
    }
}
