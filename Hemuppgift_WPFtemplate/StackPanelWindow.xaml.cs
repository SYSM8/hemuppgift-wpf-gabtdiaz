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

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for StackPanelWindow.xaml
    /// </summary>
    public partial class StackPanelWindow : Window
    {
        public StackPanelWindow()
        {
            InitializeComponent();
        }

        private void RadioButtonHorizontal(object sender, RoutedEventArgs e)
        {
            radioBtnHorizontal.IsChecked = true;
            stackRectangle.Orientation = Orientation.Horizontal;
        }

        private void RadioButtonVertical(object sender, RoutedEventArgs e)
        {
            radioBtnVertical.IsChecked = true;
            stackRectangle.Orientation = Orientation.Vertical;   
        }
    }
}
