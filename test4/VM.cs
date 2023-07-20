using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;

namespace test4
{
    internal class VM : INotifyPropertyChanged
    {
        private string[,] parts = 
        {
            { "code review"  , "2 hours",  "Jhon", "50" },
                {"team building"  ,  "3 hours", "Jack", "100" },
                {"break"  ,  "1 hour", "Kate", "20" },
                {"write some code"  ,  "5 hours", "Ann" , "200" },
                {"code"  ,  "6 hours", "Joe" , "80" },
                { "review"  , "2 min",  "pablo", "20" },
                {"building"  ,  "30 mins", "hue", "40" },
                {"Dancing"  ,  "45 mins", "Mol", "80" },
                {"write "  ,  "25 mins", "Lam" , "10" },
                {"write some "  ,  "30 mins", "jim" , "80" },
        }; 
        private StackPan selectedPan;
        public ObservableCollection<StackPan> Tasks;
        public WrapPanel wrapPan;
        Random rnd;
        List<string> list;
        private int counter = 0;

        public StackPanel SelectedPan
        {
            get { return selectedPan.MyPanel; }
        }

        public VM(int num)
        {
            Tasks = new ObservableCollection<StackPan>();
            list = new List<string>();
            Recursion(7);


            wrapPan = new WrapPanel();
            for (int i = 0; i < Tasks.Count; i++)
            {
                wrapPan.Children.Add(Tasks[i].MyPanel);
            }
        }

        public void Recursion(int num)
        {
            if(counter < num)
            {
                rnd = new Random();
                for (int i = 0; i < rnd.Next(6, 10); i++)
                {
                    int column = rnd.Next(0, parts.GetLength(0) - 1);
                    for (int j = 0; j < parts.GetLength(1); j++)
                    {
                        list.Add(parts[column, j]);
                    }
                    Tasks.Add(new StackPan(list));
                    list.Clear();
                }
                counter++;
                Recursion(num);
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


    }
}
