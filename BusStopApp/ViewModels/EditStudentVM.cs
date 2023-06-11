using BusStopApp.NewFolder1;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BusStopApp.ViewModels
{
    public class EditStudentVM:ViewModelBase
    {
        public Student? Student { get; set; }

        public Student? TemplateStudent { get; set; }

        public Window CurrentWindow { get; set; }

        public EditStudentVM(Student? templateStudent, Window window)
        {
            Student = new();
            CurrentWindow = window;
            TemplateStudent = templateStudent;
            Student.Name = templateStudent.Name;
            Student.Surname = templateStudent.Surname;
            Student.Address = templateStudent.Address;
            Student.Id = templateStudent.Id;
            Student.SchoolNo = templateStudent.SchoolNo;

        }

        public RelayCommand SaveCommand
        {
            get => new RelayCommand(
            () =>
            {
                if (Student.Name != string.Empty  && Student.Address != string.Empty && Student.Surname != string.Empty && Student.Id > 0 && Student.SchoolNo != string.Empty)
                {
                    TemplateStudent.Name = Student.Name;
                    TemplateStudent.Surname = Student.Surname;

                    TemplateStudent.Address = Student.Address;
                    TemplateStudent.SchoolNo = Student.SchoolNo;
                    TemplateStudent.Id = Student.Id;
                    CurrentWindow.Close();
                }

                else
                {
                    MessageBox.Show("", "BusStopApp", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            });
        }
    }
}
