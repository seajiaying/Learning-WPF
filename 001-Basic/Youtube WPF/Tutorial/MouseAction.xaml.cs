﻿using System;
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

namespace Youtube_WPF.Tutorial
{
    /// <summary>
    /// Interaction logic for MouseAction.xaml
    /// </summary>
    public partial class MouseAction : Window
    {
        public MouseAction()
        {
            InitializeComponent();
            DataContext = new MyDataContext();
        }
    }
}
