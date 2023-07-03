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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for cola.xaml
    /// </summary>
    public partial class cola : Window
    {

        public cola(daxil a)
        {
            InitializeComponent();

            if (a.ad == 1)
            {
                item1.Content = "cola clasic";
                item2.Content = "cola zero";

            }
            else if (a.ad == 2)
            {
                item1.Content = "lays clasic";
                item2.Content = "yasi oglan lays";
            }

            else if (a.ad == 3)
            {
                item1.Content = "zavod coreyi";
                item2.Content = "tendir coreyi";
            }
            

        }

        public void  Button_Click(object sender, RoutedEventArgs e)
        {
            
            string a = com.Text;
      
            

            if (!string.IsNullOrEmpty(a))
            {
                la.Content = a;
                MessageBox.Show("Test");
            }
            else
            {
                MessageBox.Show("tesufler olsun");
            }
            

        }
    }
}
