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
using Youtube_WPF.ViewModels;

namespace Youtube_WPF.Views
{
    /// <summary>
    /// Interaction logic for WPFHidetopPanelLayout.xaml
    /// </summary>
    public partial class WPFHidetopPanelLayout : Window
    {
        public WPFHidetopPanelLayout()
        {
            InitializeComponent();
            DataContext = new ViewModel();
        }
    }
}
