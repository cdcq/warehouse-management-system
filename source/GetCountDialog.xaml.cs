﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace warehouse_management_system
{
    /// <summary>
    /// GetCountDialog.xaml 的交互逻辑
    /// </summary>
    public partial class GetCountDialog : Window
    {
        public Item item = new Item();
        public GetCountDialog()
        {
            InitializeComponent();

            Binding countBinding = new Binding();
            countBinding.Source = item;
            countBinding.Path = new PropertyPath("Count");
            countBinding.Mode = BindingMode.OneWayToSource;
            BindingOperations.SetBinding(this.countBox, TextBox.TextProperty, countBinding);
        }
        private void countBox_GotFocus(object sender, RoutedEventArgs e)
        {
            countBox.SelectAll();
        }
        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }

}