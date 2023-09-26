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
using SelHoz.VM;

namespace SelHoz.Page
{
    /// <summary>
    /// Логика взаимодействия для SotrudnikMainWindow.xaml
    /// </summary>
    public partial class SotrudnikMainWindow : Window
    {
        public SotrudnikMainWindow()
        {
            InitializeComponent();
            Service.Service.frame = MainFrame;
            DataContext =  new SotrudnikMainVM();
        }
        private void closeButton_Click(object sender, RoutedEventArgs e) =>
        this.Close();

    }
}
