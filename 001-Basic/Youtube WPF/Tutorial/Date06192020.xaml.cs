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

namespace Youtube_WPF.Tutorial
{
    /// <summary>
    /// Interaction logic for Date06192020.xaml
    /// </summary>
    public partial class Date06192020 : Window
    {
        SolidColorBrush Off = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        SolidColorBrush On = new SolidColorBrush(Color.FromRgb(240, 222, 45));

        public Date06192020()
        {
            InitializeComponent();
        }

        private void Bu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Bu.Toggled1 == true)
            {
                Light.Fill = On;

            }
            else
            {
                Light.Fill = Off;
            }
        }
    }
}
