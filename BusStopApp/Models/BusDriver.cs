using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusStopApp.NewFolder1
{
    public class BusDriver : INotifyPropertyChanged
    {
        private string? name;
        private string? surname;
        private string? address;
        private Bus bus;



        public string? Name
        {
            get { return name; }
            set { name = value;
                OnPropertyChanged();
            }
        }

        public string? Surname
        {
            get { return surname; }
            set { surname = value;
                OnPropertyChanged();
            }
        }
        public string? Address
        {
            get { return address; }
            set { address = value;
                OnPropertyChanged();
            }
        }

        public Bus Bus
        {
            get { return bus; }
            set { bus = value;
                OnPropertyChanged();
            }
        }

        public BusDriver() { }

        public BusDriver(string name, string surname, string adress, Bus bus)
        {
            Name = name;
            Surname = surname;
            Address = adress;
            Bus = bus;
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
