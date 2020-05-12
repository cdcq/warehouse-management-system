using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace warehouse_management_system
{
    class History
    {
        public String discription;
        public String name;
        public int count;
        public double worth;
        public String date;
        public History(String newDiscription, String newName, int newCount, double newWorth, String newDate)
        {
            discription = newDiscription;
            name = newName;
            count = newCount;
            worth = newWorth;
            date = newDate;
        }
    }
    public class HistoryBase
    {
        public String name;
        public ArrayList histories = new ArrayList();
        public void LoadData()
        {
            histories.Clear();
            StreamReader R = new StreamReader(name);
            for (string inputS = R.ReadLine(); inputS != null; inputS = R.ReadLine())
            {
                //string[] input = inputS.Split(@" +");
                string[] input = System.Text.RegularExpressions.Regex.Split(inputS, @" +");
                History history = new History(input[0], input[1], Convert.ToInt32(input[2]), Convert.ToDouble(input[3])
                    , input[4] + " " + input[5]);
                histories.Add(history);
            }
            R.Close();
        }
        public void StoreData()
        {
            StreamWriter W = new StreamWriter(name);
            foreach (History history in histories)
            {
                string outputS = "";
                outputS += history.discription + " ";
                outputS += history.name + " ";
                outputS += Convert.ToString(history.count) + " ";
                outputS += Convert.ToString(history.worth) + " ";
                outputS += history.date;
                W.WriteLine(outputS);
            }
            W.Close();
        }
    }
}
