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
            { "code review"  , "2 hours",  "Jhon" },
                {"team building"  ,  "3 hours", "Jack" },
                {"break"  ,  "1 hour", "Kate"},
                {"write some code"  ,  "5 hours", "Ann" },
                {"code"  ,  "6 hours", "Joe"},
                { "review"  , "2 min",  "pablo" },
                {"building"  ,  "30 mins", "hue" },
                {"Dancing"  ,  "45 mins", "Mol" },
                {"write "  ,  "25 mins", "Lam" },
                {"write some "  ,  "30 mins", "jim"  },
        }; 
        private StackPan selectedPan;
        public ObservableCollection<StackPan> Tasks;
        public WrapPanel wrapPan;
        Random rnd;
        public int taskCompletion;
        List<string> list;
        private int counter = 0;
        private int _pending = 0;
        private int _jeopardy = 0;
        private int _completed = 0;

        public StackPanel SelectedPan
        {
            get { return selectedPan.MyPanel; }
        }

        public VM(int num)
        {
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
                Tasks = new ObservableCollection<StackPan>();
                list = new List<string>();
                rnd = new Random();
                for (int i = 0; i < rnd.Next(20, 100); i++)
                {
                    int column = rnd.Next(0, parts.GetLength(0) - 1);
                    for (int j = 0; j < parts.GetLength(1); j++)
                    {
                        list.Add(parts[column, j]);
                    }
                    taskCompletion = rnd.Next(0, 3);
                    CheckTask(taskCompletion);
                    Tasks.Add(new StackPan(list, rnd.Next(10, 100), taskCompletion));
                    list.Clear();
                }
                counter++;
                Recursion(num);
            }
        }

        public void CheckTask(int num)
        {
            if(num == 0)
            {
                _pending += 1;
            }
            else if(num == 1)
            {
                _completed += 1;
            }
            else if(num == 2)
            {
                _jeopardy += 1;
            }
        }

        public int Pending
        {
            get { return _pending; }
        }

        public int Completed
        {
            get { return _completed; }
        }

        public int Jeopardy
        {
            get { return _jeopardy; }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


    }
}
