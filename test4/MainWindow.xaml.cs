using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
    public partial class MainWindow : Window
    {
        ObservableCollection<WrapPanel> wrapPans;
        VM vm;
        WrapPanel wrapPanel;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new VM(7);
            wrapPans = new ObservableCollection<WrapPanel>();
            for(int i = 0; i<6; i++)
            {
                vm = new VM(7);
                wrapPanel = vm.wrapPan;
                myGrid.RowDefinitions.Add(new RowDefinition());
                myGrid.Children.Add(wrapPanel);
                Grid.SetRow(wrapPanel, i);
                
                
            }

            myScroll.Content = myGrid;
            
        }


        public void MyFunc()
        {
            
        }


    }
}
