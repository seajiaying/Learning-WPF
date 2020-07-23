using System;
using System.Collections.Generic;
using System.Collections;
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
    /// Interaction logic for Date07072020.xaml
    /// </summary>
    public partial class Date07072020 : Window
    {
        ArrayList mylist;
        string currentitem = string.Empty;
        int index = 0;

        public Date07072020()
        {
           
            InitializeComponent();
            mylist=loadlistbox();
            listBox.ItemsSource = mylist;
        }

        private ArrayList loadlistbox()
        {
            ArrayList List = new ArrayList();
            
            List.Add("Apple");
            List.Add("Orange");
            List.Add("Grapes");
            List.Add("Mango");
            return List;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            currentitem = listBox.SelectedValue.ToString();
            index = listBox.SelectedIndex;
            //MessageBox.Show(currentitem);
            //MessageBox.Show(index.ToString());
            listBox1.Items.Add(currentitem);
            if(mylist!=null)
            {
                mylist.RemoveAt(index);
            }
            bindnewlist();
        }

        private void bindnewlist()
        {
            listBox.ItemsSource = null;
            listBox.ItemsSource = mylist;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            currentitem = listBox1.SelectedValue.ToString();
            index = listBox1.SelectedIndex;
            mylist.Add(currentitem);
            listBox1.Items.RemoveAt(listBox1.Items.IndexOf(listBox1.SelectedItem));
            bindnewlist();
        }
    }
}
