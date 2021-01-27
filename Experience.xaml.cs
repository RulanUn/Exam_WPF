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

namespace Exam_Unaibayev
{
    /// <summary>
    /// Логика взаимодействия для Experience.xaml
    /// </summary>
    public partial class Experience : Window
    {
        public Experience()
        {
            InitializeComponent();
        }

        private void Previous_Button(object sender, RoutedEventArgs e)
        {
            Email email = new Email();
            email.Show();
            this.Close();
        }

        private void Save_Button(object sender, RoutedEventArgs e)
        {
            Resume resume = new Resume();
            resume.expirienceFirst = experienceOne.Text;
            resume.expirienceSecond = experienceTwo.Text;
            resume.expirienceThird = experienceThree.Text;
            ShowInfo showInfo = new ShowInfo();
            showInfo.Show();
        }

        private void NewResume_Button(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Close_Button(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
