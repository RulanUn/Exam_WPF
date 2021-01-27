﻿using System;
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
    /// Логика взаимодействия для DateOfBirth.xaml
    /// </summary>
    public partial class DateOfBirth : Window
    {
        public DateOfBirth()
        {
            InitializeComponent();
        }

        private void Previous_Button(object sender, RoutedEventArgs e)
        {
            Name name = new Name();
            name.Show();
            this.Close();
        }

        private void Next_Button(object sender, RoutedEventArgs e)
        {
            Foto foto = new Foto();
            foto.Show();
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
