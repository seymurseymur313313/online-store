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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public string yaxis  { get; set; }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = 1;
            daxil daxil = new daxil(a);
            cola cola = new cola(daxil);
            cola.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int a =2;
            daxil daxil = new daxil(a);
            cola cola = new cola(daxil);
            cola.Show();
            

        }



        public void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string a = "\ncola 1m";
            label.Content += a;
        }

        public void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string a = "\nlays 1.5m";
            label.Content += a;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string a = "\ncorey 65qep";
            label.Content += a;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

            int a = 3;
            daxil daxil = new daxil(a);
            cola cola = new cola(daxil);
            cola.Show();
        }
    }
}
