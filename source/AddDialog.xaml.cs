using System;
using System.Collections.Generic;
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
    /// CreatDialog.xaml 的交互逻辑
    /// </summary>
    public partial class AddDialog : Window
    {
        public Item item = new Item();
        public AddDialog()
        {
            InitializeComponent();

            Binding nameBinding = new Binding();
            nameBinding.Source = item;
            nameBinding.Path = new PropertyPath("Name");
            BindingOperations.SetBinding(this.nameBox, TextBox.TextProperty, nameBinding);
            
            Binding countBinding = new Binding();
            countBinding.Source = item;
            countBinding.Path = new PropertyPath("Count");
            countBinding.Mode = BindingMode.OneWayToSource;
            BindingOperations.SetBinding(this.countBox, TextBox.TextProperty, countBinding);
            
            Binding worthBinding = new Binding();
            worthBinding.Source = item;
            worthBinding.Path = new PropertyPath("Worth");
            worthBinding.Mode = BindingMode.OneWayToSource;
            BindingOperations.SetBinding(this.worthBox, TextBox.TextProperty, worthBinding);
            
            Binding propertyBinding = new Binding();
            propertyBinding.Source = item;
            propertyBinding.Path = new PropertyPath("Properties");
            BindingOperations.SetBinding(this.propertyBox, TextBox.TextProperty, propertyBinding);

            nameBox.Focus();
        }
        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void nameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            nameBox.SelectAll();
        }

        private void countBox_GotFocus(object sender, RoutedEventArgs e)
        {
            countBox.SelectAll();
        }

        private void worthBox_GotFocus(object sender, RoutedEventArgs e)
        {
            worthBox.SelectAll();
        }

        private void propertyBox_GotFocus(object sender, RoutedEventArgs e)
        {
            propertyBox.SelectAll();
        }
    }
}
