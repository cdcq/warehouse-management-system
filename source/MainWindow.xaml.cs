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
        public MainWindow()
        {
            InitializeComponent();

            Binding nameBinding = new Binding();
            nameBinding.Source = db;
            nameBinding.Path = new PropertyPath("Name");
            BindingOperations.SetBinding(this.nameBox, TextBlock.TextProperty, nameBinding);

            this.itemList.ItemsSource = db.items;
            //this.itemList.DisplayMemberPath = "Name";

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
    }
}
