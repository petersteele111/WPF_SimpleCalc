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

namespace WPF_SimpleCalc
{
    /// <summary>
    /// Interaction logic for ModalHelpWindow.xaml
    /// </summary>
    public partial class ModalHelpWindow : Window
    {
        public ModalHelpWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Help_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
