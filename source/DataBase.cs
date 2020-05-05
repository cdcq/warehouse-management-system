using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace warehouse_management_system
{
    class Item
    {
        public string name;
        public int count;
        public double worth;
        public ArrayList properties;
    }

    class DataBase:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                if(this.PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }
        public ArrayList items = new ArrayList();

        public void LoadData(string filename)
        {
            StreamReader R = new StreamReader(filename);
            for(string inputS = R.ReadLine(); inputS != null; inputS = R.ReadLine())
            {
                string[] input = inputS.Split(" ");
                Item iItem = new Item();
                iItem.name = input[0];
                iItem.count = Convert.ToInt32(input[1]);
                iItem.worth = Convert.ToDouble(input[2]);
                iItem.properties = new ArrayList();
                for (int i = 3; i < input.Length; i++)
                {
                    iItem.properties.Add(input[i]);
                }
                items.Add(iItem);
            }
            R.Close();
            /*
            //用于测试是否成功输入
            StreamWriter W = new StreamWriter("test.out");
            foreach(Item item in items)
            {
                string outputS = "";
                outputS += item.name + " ";
                outputS += Convert.ToString(item.count) + " ";
                outputS += Convert.ToString(item.worth) + " ";
                foreach(string propS in item.properties)
                {
                    outputS += propS + " ";
                }
                W.WriteLine(outputS);
            }
            W.Close();
            */
        }
    }
}
