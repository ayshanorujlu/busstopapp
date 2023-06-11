using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusStopApp.NewFolder1
{
    public class Student : INotifyPropertyChanged
    {
        private int id;

        private string? name;

        private string? surname;

        private string? schoolNo;

        private string? address;

        public int Id
        {
            get { return id; }
            set { id = value;
                OnPropertyChanged();
            }
        }
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
        public string? SchoolNo
        {
            get { return schoolNo; }
            set { schoolNo = value;
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

     

        public Student()
        {

        }

        public Student( int id,string name, string surname, string schoolNo, string adress)
        {
            Id = id;
            Name = name;
            Surname = surname;
            SchoolNo = schoolNo;
            Address = adress;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
