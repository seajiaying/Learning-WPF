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
using System.Windows.Media.Animation;

namespace Youtube_WPF.Tutorial
{
    /// <summary>
    /// Interaction logic for Progressbar.xaml
    /// </summary>
    public partial class Progressbar : Window
    {
        public Progressbar()
        {
            InitializeComponent();

            loadprogressbar();
            createprogressbar();
        }

        private void createprogressbar()
        {
            ProgressBar pb2 = new ProgressBar();
            pb2.IsIndeterminate = false;
            pb2.Orientation = Orientation.Horizontal;
            pb2.Width = 100;
            pb2.Height = 25;
            //loadprogressbar();
            Duration dur = new Duration(TimeSpan.FromSeconds(30));
            DoubleAnimation dblani = new DoubleAnimation(200.0, dur);
            pb2.BeginAnimation(ProgressBar.ValueProperty, dblani);
            sbar1.Items.Add(pb2);
        }

        private void loadprogressbar()
        {
            Duration dur = new Duration(TimeSpan.FromSeconds(30));
            DoubleAnimation dblani = new DoubleAnimation(200.0, dur);
            pb1.BeginAnimation(ProgressBar.ValueProperty, dblani);

        }
    }
}
