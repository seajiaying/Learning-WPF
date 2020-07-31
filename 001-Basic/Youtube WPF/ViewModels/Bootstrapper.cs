using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Youtube_WPF.ViewModels
{
    public class Bootstrapper : Caliburn.Micro.BootstrapperBase

    {
        public Bootstrapper()
        {
            Initialize();
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}
