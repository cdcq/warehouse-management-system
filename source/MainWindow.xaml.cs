using System;
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
        HistoryBase hb = new HistoryBase();
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

            db.Name = "./InitWare.war";
            if (!File.Exists(db.name))
            {
                var file = File.Create(db.name);
                file.Close();
            }
            db.LoadData(db.name);

            hb.name = db.name + ".his";
            if (!File.Exists(hb.name))
            {
                var file = File.Create(hb.name);
                file.Close();
            }
            hb.LoadData();
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
                hb.name = filename + ".his";
                hb.LoadData();
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
                var file = File.Create(filename);
                file.Close();
                db.Name = filename;
                db.items.Clear();
                hb.name = filename + ".his";
                hb.histories.Clear();
            }
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OpenAdd_Click(object sender, RoutedEventArgs e)
        {
            AddDialog dlg = new AddDialog();
            dlg.Owner = this;
            dlg.ShowDialog();

            if(dlg.DialogResult == true)
            {
                if (db.Exist(dlg.item.name))
                {
                    string messageBoxText = "名称已存在";
                    string caption = "警告";
                    MessageBoxButton button = MessageBoxButton.YesNo;
                    MessageBoxImage icon = MessageBoxImage.Warning;
                    MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon);
                }
                else
                {
                    db.items.Add(dlg.item);
                    db.StoreData(db.name);
                    String date = DateTime.Now.ToString();
                    History history = new History("add", dlg.item.name, dlg.item.count, dlg.item.worth, date);
                    hb.histories.Add(history);
                    hb.StoreData();
                }
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
                    String date = DateTime.Now.ToString();
                    History history = new History("remove", item.name, item.count, item.worth, date);
                    hb.histories.Add(history);
                    hb.StoreData();
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
                int count = GetCount();
                db.items[db.items.IndexOf(item)].Count += count;
                db.StoreData(db.name);
                String date = DateTime.Now.ToString();
                History history = new History("input", item.name, count, item.worth, date);
                hb.histories.Add(history);
                hb.StoreData();
            }
        }
        private void Output_Click(object sender, RoutedEventArgs e)
        {
            Item item = itemList.SelectedItem as Item;
            if (item != null)
            {
                int count = GetCount();
                if(db.items[db.items.IndexOf(item)].Count >= count)
                {
                    db.items[db.items.IndexOf(item)].Count -= count;
                    db.StoreData(db.name);
                    String date = DateTime.Now.ToString();
                    History history = new History("output", item.name, count, item.worth, date);
                    hb.histories.Add(history);
                    hb.StoreData();
                }
                else
                {
                    string messageBoxText = "库存不足";
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

        private void Statistic_Click(object sender, RoutedEventArgs e)
        {
            StatisticDialog dlg = new StatisticDialog(db);
            dlg.ShowDialog();
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            HistoryDialog dlg = new HistoryDialog(hb);
            dlg.ShowDialog();
        }

        private void Document_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
