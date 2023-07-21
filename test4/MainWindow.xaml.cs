using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace test4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        ObservableCollection<WrapPanel> wrapPans;
        VM vm;
        ObservableCollection<VM> vms;
        WrapPanel wrapPanel;
        public int pending = 0;
        public int completed = 0;
        public int jeopardy = 0;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new VM(7);
            Creation();
            MyFunc();
            Pending.Text = pending.ToString();
            Completed.Text = completed.ToString();
            Jeopardy.Text = jeopardy.ToString();
            OnPropertyChanged();
        }

        public void Creation()
        {
            wrapPans = new ObservableCollection<WrapPanel>();
            for (int i = 0; i < 100; i++)
            {
                vm = new VM(7);
                vms = new ObservableCollection<VM>();
                wrapPanel = vm.wrapPan;
                wrapPanel.ItemHeight = 20;
                myGrid.RowDefinitions.Add(new RowDefinition());
                myGrid.Children.Add(wrapPanel);
                vms.Add(vm);
                Grid.SetRow(wrapPanel, i);

            }

            myScroll.Content = myGrid;
        }


        public void MyFunc()
        {
            for(int i = 0; i<vms.Count; i++)
            {
                pending += vms[i].Pending;
                completed += vms[i].Completed;
                jeopardy += vms[i].Jeopardy;
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
