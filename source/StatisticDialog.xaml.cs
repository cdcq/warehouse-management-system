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
    /// StatisticDialog.xaml 的交互逻辑
    /// </summary>
    public partial class StatisticDialog : Window
    {
        public StatisticDialog(DataBase db)
        {
            InitializeComponent();

            GetStatistic(db);
        }

        void GetStatistic(DataBase db)
        {
            double totalWorthCal = 0;
            int maxCountCal = 0;
            foreach(Item item in db.items)
            {
                totalWorthCal += item.worth;
                if(item.count > maxCountCal)
                {
                    maxCountCal = item.count;
                }
            }

            this.itemsCount.Text = db.items.Count.ToString();
            this.totalWorth.Text = totalWorthCal.ToString();
            this.maxCount.Text = maxCountCal.ToString();
        }
    }
}
