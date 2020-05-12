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
    /// HistoryDialog.xaml 的交互逻辑
    /// </summary>
    public partial class HistoryDialog : Window
    {
        class Comparer
        {
            DateTime now = DateTime.Now;
            bool DayComparer(DateTime date)
            {
                return now.Day == date.Day && now.Month == date.Month && now.Year == date.Year;
            }
            bool MonthComparer(DateTime date)
            {
                return now.Month == date.Month && now.Year == date.Year;
            }
            bool YearComparer(DateTime date)
            {
                return now.Year == date.Year;
            }
            public bool Compare(int type, DateTime date)
            {
                if(type == 0)
                {
                    return DayComparer(date);
                }
                else if(type == 1)
                {
                    return MonthComparer(date);
                }
                else if(type == 2)
                {
                    return YearComparer(date);
                }
                return false;
            }
        }
       
        public HistoryBase hb;
        public HistoryDialog(HistoryBase newhb)
        {
            InitializeComponent();

            hb = newhb;
            this.comboBox.SelectedIndex = 1;
        }


        void Update(int type)
        {
            Comparer comparer = new Comparer();
            int inputCountCal = 0;
            double inputWorthCal = 0;
            int outputCountCal = 0;
            double outputWorthCal = 0;
            foreach(History history in hb.histories)
            {
                if(history.discription == "add" || history.discription == "input")
                {
                    DateTime date = Convert.ToDateTime(history.date);
                    if (comparer.Compare(type, date))
                    {
                        inputCountCal += history.count;
                        inputWorthCal += history.worth;
                    }
                }
                if (history.discription == "remove" || history.discription == "output")
                {
                    DateTime date = Convert.ToDateTime(history.date);
                    if (comparer.Compare(type, date))
                    {
                        outputCountCal += history.count;
                        outputWorthCal += history.worth;
                    }
                }
            }
            this.inputCount.Text = inputCountCal.ToString();
            this.inputWorth.Text = inputWorthCal.ToString();
            this.outputCount.Text = outputCountCal.ToString();
            this.outputWorth.Text = outputWorthCal.ToString();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update(this.comboBox.SelectedIndex);
        }
    }
}
