﻿using SelHoz.VM.AdminVM;
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

namespace SelHoz.Pages.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для AddAreaWindow.xaml
    /// </summary>
    public partial class AddAreaWindow : Window
    {
        public AddAreaWindow()
        {
            InitializeComponent();
            DataContext = new AddAreaVM();      
        }       
    }
}
