using System;
using System.Collections.Generic;
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

namespace Lab17.WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void changeColor()
        {
            byte rr = (byte)SeekR.Value;
            byte gg = (byte)SeekG.Value;
            byte bb = (byte)SeekB.Value;
            Color cc = Color.FromRgb(rr, gg, bb); //Create object of Color class.
            SolidColorBrush colorBrush = new SolidColorBrush(cc); //Creating object of SolidColorBruch class.
            Kvadrat.Background = colorBrush; //Setting background of stack panel.
        }
        private void changeLedIndicatiorColor(object sender, RoutedEventArgs e)
        {
            changeColor();
        }

    }
    public partial class ColorPicker : System.Windows.Controls.UserControl
    { 
    
    }
}
