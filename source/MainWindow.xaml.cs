﻿using System;
using System.Collections.Generic;
using System.IO;
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

namespace warehouse_management_system
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataBase db = new DataBase();
        public MainWindow()
        {
            InitializeComponent();

            Init();
        }
        void CreatBinding()
        {
            Binding nameBinding = new Binding();
            nameBinding.Source = db;
            nameBinding.Path = new PropertyPath("Name");
            BindingOperations.SetBinding(this.nameBox, TextBlock.TextProperty, nameBinding);

            this.itemList.ItemsSource = db.items;
            //this.itemList.DisplayMemberPath = "Name";
        }
        void Init()
        {
            CreatBinding();

            if (!File.Exists(db.name))
            {
                File.Create(db.name);
            }
            db.LoadData(db.name);
        }
        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            ofd.DefaultExt = ".war";
            ofd.AddExtension = true;
            ofd.Filter = "仓库数据文件|*.war";
            Nullable<bool> result = ofd.ShowDialog();
            if(result == true)
            {
                string filename = ofd.FileName;
                db.Name = filename;
                db.LoadData(filename);
            }
        }
        private void NewFile_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog sfd = new Microsoft.Win32.SaveFileDialog();
            sfd.FileName = "新建仓库.war";
            sfd.DefaultExt = ".war";
            sfd.AddExtension = true;
            sfd.Filter = "仓库数据文件|*.war";
            Nullable<bool> result = sfd.ShowDialog();
            if(result == true)
            {
                string filename = sfd.FileName;
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }
                File.Create(filename);
                db.Name = filename;
                db.items.Clear();
            }
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OpenCreat_Click(object sender, RoutedEventArgs e)
        {
            CreatDialog dlg = new CreatDialog();
            dlg.Owner = this;
            dlg.ShowDialog();

            if(dlg.DialogResult == true)
            {
                db.items.Add(dlg.item);
                db.StoreData(db.name);
            }
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            string messageBoxText = "确认要删除吗";
            string caption = "警告";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon);
            if(result == MessageBoxResult.Yes)
            {
                Item item = itemList.SelectedItem as Item;
                if (item != null)
                {
                    db.items.Remove(item);
                }
            }
            db.StoreData(db.name);
        }

        private int GetCount()
        {
            GetCountDialog dlg = new GetCountDialog();
            dlg.Owner = this;
            dlg.ShowDialog();

            if(dlg.DialogResult == true && dlg.item.count > 0)
            {
                return dlg.item.count;
            }
            return 0;
        }

        private void Input_Click(object sender, RoutedEventArgs e)
        {
            Item item = itemList.SelectedItem as Item;
            if(item != null)
            {
                db.items[db.items.IndexOf(item)].Count += GetCount();
                db.StoreData(db.name);
                db.LoadData(db.name);
            }
            db.StoreData(db.name);
        }
        private void Output_Click(object sender, RoutedEventArgs e)
        {
            Item item = itemList.SelectedItem as Item;
            if (item != null)
            {
                if(db.items[db.items.IndexOf(item)].Count >= GetCount())
                {
                    db.items[db.items.IndexOf(item)].Count -= GetCount();
                    db.StoreData(db.name);
                    db.LoadData(db.name);
                }
                else
                {
                    string messageBoxText = "数量不能为负";
                    string caption = "警告";
                    MessageBoxButton button = MessageBoxButton.OK;
                    MessageBoxImage icon = MessageBoxImage.Warning;
                    MessageBox.Show(messageBoxText, caption, button, icon);
                }
            }
            db.StoreData(db.name);
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            SearchDialog dlg = new SearchDialog();
            dlg.db = db;
            dlg.ShowDialog();
        }
    }
}
