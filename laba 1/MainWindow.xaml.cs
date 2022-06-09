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

namespace dz1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class GG
        {

            public double z;
            public string s;
            public double d;
        }
        GG gg = new GG();
        public MainWindow()
        {
            InitializeComponent();
        }




        private void Time1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Time1.Text != "")

                gg.s = Time1.Text;//name
        }

        private void Time_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Time.Text != "")

                gg.d = Convert.ToInt32(Time.Text);//kol stranic
        }

        private void Time2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Time2.Text != "")

                gg.z = Convert.ToInt32(Time2.Text);//cena
        }
        private void vsec_Click(object sender, RoutedEventArgs e)
        {

            double j = gg.d / gg.z;
            Sec.Text = Convert.ToString(j);


        }
        private void pat_Click(object sender, RoutedEventArgs e)
        {
            double a = gg.z;
            a /= 2;

            Pat.Text = Convert.ToString((double)a);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
    }
}