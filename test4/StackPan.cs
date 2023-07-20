using System;
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
    internal class StackPan : INotifyPropertyChanged
    {
        
        private StackPanel myPanel;
        private MyToolTip myTip;
        private Random rnd = new Random();
        

        public StackPan(List<string> list)
        {
            myPanel  = new StackPanel();
            myTip = new MyToolTip(list[0], list[1], list[2]);
            myPanel.ToolTip = myTip.tip;
            myPanel.Margin = new System.Windows.Thickness(50, 1, 0, 0);
            myPanel.Height = 100;
            myPanel.Width = rnd.Next(10, 101);
            Button b = new Button();
            b.Content = myPanel.Width;
            myPanel.Children.Add(b);
            OnPropertyChanged("myPanel");
        }


        public StackPanel MyPanel
        {
            get { return myPanel; }
        }






        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
