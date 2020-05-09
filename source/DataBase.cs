using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace warehouse_management_system
{
    public class Item:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string name;
        public int count;
        public double worth;
        public ArrayList properties;
        public Item()
        {
            properties = new ArrayList();
        }
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
        public int Count
        {
            get { return count; }
            set
            {
                count = value;
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }
        public double Worth
        {
            get { return worth; }
            set
            {
                worth = value;
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }
        public string Properties
        {
            get
            {
                string propertiesList = "";
                foreach(string property in properties)
                {
                    propertiesList += property + "  ";
                }
                return propertiesList;
            }
            set
            {
                string[] propertiesList = value.Split(" ");
                properties.Clear();
                foreach(string property in propertiesList)
                {
                    properties.Add(property);
                }
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Properties"));
                }
            }
        }
    }

    public class DataBase:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string name;
        public ObservableCollection<Item> items = new ObservableCollection<Item>();
        public DataBase()
        {
            name = "./InitWare.war";
        }
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
        public void LoadData(string filename)
        {
            items.Clear();
            StreamReader R = new StreamReader(filename);
            for(string inputS = R.ReadLine(); inputS != null; inputS = R.ReadLine())
            {
                //string[] input = inputS.Split(@" +");
                string[] input = System.Text.RegularExpressions.Regex.Split(inputS, @" +");
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
        }
        public void StoreData(string filename)
        {
            StreamWriter W = new StreamWriter(filename);
            foreach(Item item in items)
            {
                string outputS = "";
                outputS += item.name + " ";
                outputS += Convert.ToString(item.count) + " ";
                outputS += Convert.ToString(item.worth) + " ";
                for(int i = 0; i < item.properties.Count; i++)
                {
                    string propS = item.properties[i] as string;
                    outputS += propS;
                    if(i != item.properties.Count - 1)
                    {
                        outputS = outputS + " ";
                    }
                }
                W.WriteLine(outputS);
            }
            W.Close();
        }
    }
}
