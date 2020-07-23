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
    /// Interaction logic for Date06102020.xaml
    /// </summary>
    public partial class Date06102020 : Window
    {
        public Date06102020()
        {
            InitializeComponent();
            //Border b1 = new Border();
            //b1.Width = 200;
            //b1.Height = 30;
            //b1.BorderBrush = Brushes.BlueViolet;
            //b1.BorderThickness = new Thickness(2);
            //b1.Child = new Button() { Content = "Hello World" };
            //this.Content = b1;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Label1.Content = "First Manu Item";
        }
    }
}
