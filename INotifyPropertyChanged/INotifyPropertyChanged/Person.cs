using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace INotifyPropertyChangeddemo
{
    public class Person: INotifyPropertyChanged
    {
        private String _name = "John";
        private int _age = 24;
        private String _hobby = "food";

        public String Name
        {
            set
            {
                _name = value;
                if(PropertyChanged !=null) //has change
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }
            get
            {
                return _name;
            }
        }

        public int Age
        {
            set
            {
                _age = value;
                if()
            }
        }
    }
}
