using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

//for MouseAction.xaml
namespace Youtube_WPF.ViewModels
{
    public class MyDataContext
    {
        ICommand msgcommand = new MSGComand();
        public ICommand MessageCommand { get { return msgcommand; } }
    }
}
