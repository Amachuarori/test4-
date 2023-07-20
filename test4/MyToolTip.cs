using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace test4
{
    internal class MyToolTip: INotifyPropertyChanged
    {
        private string _taskName;
        private string _reservedTime;
        private string _executor;
        private TextBlock myBlock;
        private StackPanel panel = new StackPanel();
        public ToolTip tip;

        public MyToolTip(string taskName, string reservedTime, string executor)
        {
            panel = new StackPanel();
            tip = new ToolTip();
            TaskName = taskName;
            ReservedTime = reservedTime;
            Executor = executor;
            tip.Content = panel;
        }

        public ToolTip Tip
        {
            get { return tip; }
        }



        public string TaskName
        {
            get { return _taskName; }
            set
            {

                
                _taskName = value;
                myBlock = new TextBlock();
                myBlock.Text = value;
                panel.Children.Add(myBlock);
                OnPropertyChanged("TaskName");
            }
        }

        public string ReservedTime
        {
            get { return _reservedTime; }
            set
            {
                _reservedTime = value;
                myBlock = new TextBlock();
                myBlock.Text = value;
                panel.Children.Add(myBlock);
                OnPropertyChanged("ReservedTime");
            }
        }

        public string Executor
        {
            get { return _executor; }
            set
            {
                _executor = value;
                myBlock = new TextBlock();
                myBlock.Text = value;
                panel.Children.Add(myBlock);
                OnPropertyChanged("Executor");
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
