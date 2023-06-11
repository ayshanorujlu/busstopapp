using BusStopApp.NewFolder1;
using System.Collections.ObjectModel;

namespace BusStopApp.ViewModels
{
    internal class PageViewModel
    {
        private ObservableCollection<Bus> buses;

        public PageViewModel(ObservableCollection<Bus> buses)
        {
            this.buses = buses;
        }
    }
}