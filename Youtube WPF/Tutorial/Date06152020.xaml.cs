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
    /// Interaction logic for Date06152020.xaml
    /// </summary>
    public partial class Date06152020 : Window
    {
        public Date06152020()
        {
            InitializeComponent();
            //ComboBox cmb = new ComboBox();
            //cmb.Items.Add("Apple");
            //cmb.Items.Add("Orange");
            //this.Content = cmb;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("Please specify your message on each selection");
        }
    }
        
    
}
