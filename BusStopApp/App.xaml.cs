using BusStopApp.ViewModels;
using BusStopApp.Views.StudentView;
using BusStopApp.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;

namespace BusStopApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container? Container { get; set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            Register();
            var window = Container.GetInstance<MainView>();
            window.DataContext = new MainViewModel();
            window.VerticalAlignment = VerticalAlignment.Center;
            window.HorizontalAlignment = HorizontalAlignment.Center;
            window.ShowDialog();
            Current.Shutdown();
        }

        private void Register()
        {
            Container = new();

            Container.RegisterSingleton<MainView>();
            Container.RegisterSingleton<Driver>();
            Container.Register<EditDriver>();
            Container.Register<AddDriver>();
            Container.Register<EditCar>();
            Container.RegisterSingleton<Car>();
            Container.Register<AddCar>();
            Container.Register<AddStudent>();
            Container.RegisterSingleton<StudentView>();
            Container.Register<EditStudent>();
            Container.RegisterSingleton<CreateRide>();
            Container.RegisterSingleton<Rides>();
            Container.Register<EditRide>();
            Container.Register<RideStart>();

            Container.Verify();
        }
    }
}
}
