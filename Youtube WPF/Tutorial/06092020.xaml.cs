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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void button0610_Click(object sender, RoutedEventArgs e)
        {
            Date06102020 sw = new Date06102020();
            //this.visibility = visibility.hidden;//这句话隐藏第一个窗口
            sw.Show();
            this.Close();//这句话关闭第一个窗口
        }

        private void Button0612_Click(object sender, RoutedEventArgs e)
        {
            Date06122020 sw = new Date06122020();
            //this.visibility = visibility.hidden;//这句话隐藏第一个窗口
            sw.Show();
            this.Close();//这句话关闭第一个窗口
        }

        private void Button0615_Click(object sender, RoutedEventArgs e)
        {
            Date06152020 sw = new Date06152020();
            //this.visibility = visibility.hidden;//这句话隐藏第一个窗口
            sw.Show();
            this.Close();//这句话关闭第一个窗口
        }

        private void Button0617_Click(object sender, RoutedEventArgs e)
        {
            Views.ShellView sw = new Views.ShellView();
            //this.visibility = visibility.hidden;//这句话隐藏第一个窗口
            sw.Show();
            this.Close();//这句话关闭第一个窗口
        }
        private void Button0619_Click(object sender, RoutedEventArgs e)
        {
            Date06192020 sw = new Date06192020();
            //this.visibility = visibility.hidden;//这句话隐藏第一个窗口
            sw.Show();
            this.Close();//这句话关闭第一个窗口
        }


        private void TabControl_Click(object sender, RoutedEventArgs e)
        {
            TabControl sw = new TabControl();
            //this.visibility = visibility.hidden;//这句话隐藏第一个窗口
            sw.Show();
            this.Close();//这句话关闭第一个窗口
        }



        private void Button0630_Click(object sender, RoutedEventArgs e)
        {
            Date0630 sw = new Date0630();
            //this.visibility = visibility.hidden;//这句话隐藏第一个窗口
            sw.Show();
            this.Close();//这句话关闭第一个窗口
        }

        
         private void labelcontrol_click(object sender, RoutedEventArgs e)
        {
            labelcontrol sw = new labelcontrol();
            //this.visibility = visibility.hidden;//这句话隐藏第一个窗口
            sw.Show();
            this.Close();//这句话关闭第一个窗口
        }
        private void Progressbar_click(object sender, RoutedEventArgs e)
        {
            Progressbar sw = new Progressbar();
            //this.visibility = visibility.hidden;//这句话隐藏第一个窗口
            sw.Show();
            this.Close();//这句话关闭第一个窗口
        }

        private void Button0707_Click(object sender, RoutedEventArgs e)
        {
            Date07072020 sw = new Date07072020();
            //this.visibility = visibility.hidden;//这句话隐藏第一个窗口
            sw.Show();
            this.Close();//这句话关闭第一个窗口
        }

        private void Button0708_Click(object sender, RoutedEventArgs e)
        {
            Date0708 sw = new Date0708();
            //this.visibility = visibility.hidden;//这句话隐藏第一个窗口
            sw.Show();
            this.Close();//这句话关闭第一个窗口
        }

        private void MouseAction_Click(object sender, RoutedEventArgs e)
        {
            MouseAction sw = new MouseAction();
            //this.visibility = visibility.hidden;//这句话隐藏第一个窗口
            sw.Show();
            this.Close();//这句话关闭第一个窗口
        }
    }

}
