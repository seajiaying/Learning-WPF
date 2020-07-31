using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace Youtube_WPF.Tutorial
{
    /// <summary>
    /// Interaction logic for Date0708.xaml
    /// </summary>
    public partial class Date0708 : Window
    {
        public Date0708()
        {
            InitializeComponent();
        }

        //How to open multiple files using OpenFileDialog in WPF （ https://www.youtube.com/watch?v=TwKtAE7qbew)
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            ofd.Multiselect = true;
            //ofd.Filter = "Text Files(*.txt)|*.txt";
            //ofd.Filter = "Data Sources (*.ini)|*.ini*|All Files|*.*";
            ofd.Filter = "Data Sources (*.ini)|*.ini|All Files|*.*|Text Files(*.txt)|*.txt";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach(string item in ofd.FileNames)
                {
                    listBox.Items.Add(item);
                }
            }
            
        }

        //Use of OpenFileDialog in WPF also read the TextFile (https://www.youtube.com/watch?v=36nGYzrnJFk)
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog ofd_1 = new Microsoft.Win32.OpenFileDialog();
            ofd_1.DefaultExt = ".txt";
            ofd_1.Filter = "Text Document (.txt)|*.txt";
            if(ofd_1.ShowDialog()==true)
            {
                string filename = ofd_1.FileName;
                listBox1.Text = filename;
                textBox.Text = System.IO.File.ReadAllText(filename);//加上所有file list
            }

        }
    }
}
