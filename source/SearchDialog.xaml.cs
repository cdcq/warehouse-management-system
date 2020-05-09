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
    /// SearchDialog.xaml 的交互逻辑
    /// </summary>
    public partial class SearchDialog : Window
    {
        DataBase sdb = new DataBase();
        public DataBase db;
        public SearchDialog()
        {
            InitializeComponent();

            sdb.name = "";

            Binding nameBinding = new Binding();
            nameBinding.Source = sdb;
            nameBinding.Path = new PropertyPath("Name");
            BindingOperations.SetBinding(this.InputBox, TextBox.TextProperty, nameBinding);

            this.itemList.ItemsSource = sdb.items;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            sdb.items.Clear();
            foreach(Item item in db.items)
            {
                bool flag = false;
                foreach(String property in item.properties)
                {
                    if(property == sdb.name)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    sdb.items.Add(item);
                }
            }
        }
    }
}
