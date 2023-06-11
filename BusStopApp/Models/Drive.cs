using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusStopApp.NewFolder1
{
    public class Drive: INotifyPropertyChanged
    {
        public bool ToSchool { get; set; } = true;
        public string AdressSchool { get; set; } = "Baku";
        private BusDriver busDriver = new();
        public BusDriver BusDriver
        {
            get => busDriver;
            set
            {
                busDriver = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Student> Students { get; set; } = new();

        private DateTime creationTime;

        public event PropertyChangedEventHandler? PropertyChanged;

        public DateTime CreationTime
        {
            get => creationTime; set
            {
                creationTime = value;
                OnPropertyChanged();
            }
        }

        void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
