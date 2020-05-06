using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace warehouse_management_system
{
    class Item:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string name;
        public int count;
        public double worth;
        public ArrayList properties;
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
        public ObservableCollection<Item> items = new ObservableCollection<Item>();
        public void LoadData(string filename)
        {
            items.Clear();
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
                foreach(string propS in item.properties)
                {
                    outputS += propS + " ";
                }
                W.WriteLine(outputS);
            }
            W.Close();
        }
    }
}
