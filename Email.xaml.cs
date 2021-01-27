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
    /// Логика взаимодействия для Email.xaml
    /// </summary>
    public partial class Email : Window
    {
        public Email()
        {
            InitializeComponent();
        }

        private void Previous_Button(object sender, RoutedEventArgs e)
        {
            Telephon telephon = new Telephon();
            telephon.Show();
            this.Close();
        }

        private void Next_Button(object sender, RoutedEventArgs e)
        {
            Experience experience = new Experience();
            experience.Show();
            Resume resume = new Resume();
            resume.email = email.Text;
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
