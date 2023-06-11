using BusStopApp.NewFolder1;
using BusStopApp.Views.StudentView;
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
    public class StudentVM : ViewModelBase
    {
        public ObservableCollection<Student>? Students { get; set; }

        public Student SelectedStudent { get; set; }

        public StudentVM(ObservableCollection<Student>? students)
        {
            Students = students;
        }

        public RelayCommand AddStudentCommand => new RelayCommand(() =>
                                                          {
                                                              Window window = new Window();
                                                              window = App.Container.GetInstance<AddStudent>();
                                                              window.DataContext = new AddStudentVM(Students, window);
                                                              window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                                                              window.Show();
                                                          });
        public RelayCommand EditStudentCommand
        {
            get => new RelayCommand(() =>
            {
                Window window = App.Container.GetInstance<EditStudent>();
                window.DataContext = new EditStudentVM(SelectedStudent, window);
                window.Show();
            });
        }

        public RelayCommand RemoveStudentCommand
        {
            get => new RelayCommand(() =>
            {
                Students.Remove(SelectedStudent);
            });

        }
    }
}
