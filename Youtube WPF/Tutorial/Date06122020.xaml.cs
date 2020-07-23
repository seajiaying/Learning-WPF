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
    /// Interaction logic for Date06122020.xaml
    /// </summary>
    public partial class Date06122020 : Window
    {
        public Date06122020()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(first.Text!=string.Empty)
            { 
            int a = Convert.ToInt32(first.Text);
            int b = Convert.ToInt32(second.Text);
            int c = a + b;
            MessageBox.Show(c.ToString());
            //MessageBox.Show("Welcome to WPF Button control");
            }
            else
            {
             MessageBox.Show("Please enter any number in first text box");
            }
        }
    }
}
