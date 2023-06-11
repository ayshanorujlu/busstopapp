using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusStopApp.NewFolder1
{
    public class Bus : INotifyPropertyChanged
    {
        private string vendor;
        private string model;
        private int seatCount;
        private string seriaNo;
        public string Vendor
        {
            get => vendor;
            set
            {
                vendor = value;
                OnPropertyChanged();
            }
        }
        public string Model
        {
            get => model;
            set
            {
                model = value;
                OnPropertyChanged();
            }
        }

        public int SeatCount
        {
            get => seatCount;
            set
            {
                seatCount = value;
                OnPropertyChanged();
                
            }
        }
        public string SeriaNo
        {
            get => seriaNo;
            set
            {
                seriaNo = value;
                OnPropertyChanged();
            }
        }

        public Bus() { }
        public Bus(string model, string vendor, string seriaNo, int seatCount)
        {
            Model = model;
            Vendor = vendor;
            SeriaNo = seriaNo;
            SeatCount = seatCount;
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}