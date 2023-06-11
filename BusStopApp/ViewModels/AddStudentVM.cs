using BusStopApp.NewFolder1;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BusStopApp.ViewModels
{
    public class AddStudentVM:ViewModelBase
    {
        private Student student = new();

        public ObservableCollection<Student> Students;

        public Window CurrentWindow { get; set; }

        public AddStudentVM(ObservableCollection<Student> students, Window window)
        {
            CurrentWindow = window;
            Students = students;
        }

        public Student Student
        {
            get { return student; }
            set { Set(ref student, value); }
        }

        public RelayCommand CreateCommand
        {
            get => new RelayCommand(() =>
            {
                if (Student.Name != string.Empty  && Student.Address != string.Empty && Student.Surname != string.Empty && Student.Id > 0 && Student.SchoolNo != string.Empty)
                {
                    Students.Add(Student);
                    CurrentWindow.Close();
                }
                else
                    MessageBox.Show("", "BusStopApp", MessageBoxButton.OK, MessageBoxImage.Error);
            });
        }
    }
}
