﻿using Cinema_proyekt.ViewModels;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cinema_proyekt
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var viewmodel = new MainViewModel();
            this.DataContext = viewmodel;
            searchbtn.Visibility = Visibility.Hidden;
        }

        public  void mauseenter(object sender, MouseEventArgs e)
        {
            if (nametextbox.Text=="admin" & surnametextbox.Text=="admin")
            {
                searchbtn.Visibility = Visibility.Visible;
            }
        }
    }
}
