using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Exam_Unaibayev;

namespace Exam_Unaibayev
{
    /// <summary>
    /// Логика взаимодействия для Name.xaml
    /// </summary>
    public partial class Name : Window
    {
        public Name()
        {
            InitializeComponent();
        }

        private void Previous_Button(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Next_Button(object sender, RoutedEventArgs e)
        {
            DateOfBirth dateOfBirth = new DateOfBirth();
            dateOfBirth.Show();
            Resume resume = new Resume();
            resume.name = name.Text;

            this.Close();
        }

        private void Close_Button(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void NewResume_Button(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
