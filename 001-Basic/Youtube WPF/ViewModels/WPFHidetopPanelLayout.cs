using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Youtube_WPF.ViewModels
{
    class WPFHidetopPanelLayout
    {
    }

    public class ViewModel : INotifyPropertyChanged
    {
        public ViewModel()
        {
            SetInitialState();
        }
        void SetInitialState()
        {
            buttonState = ButtonState.Shown;
            GridVisibility = Visibility.Visible;
            ButtonText = "Hide";
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this,
                    new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }

        private string buttonText;
        public string ButtonText
        {
            get
            {
                return buttonText;
            }
            set
            {
                buttonText = value;
                OnPropertyChanged("ButtonText");
            }
        }

        private Visibility gridVisibility;
        public Visibility GridVisibility
        {
            get
            {
                return gridVisibility;
            }
            set
            {
                gridVisibility = value;
                OnPropertyChanged("GridVisibility");
            }
        }

        private MyCommand showHideCommand;
        public MyCommand ShowHidecommand
        {
            get { return showHideCommand ?? (showHideCommand = new MyCommand((o) => OnShowHideCommand(o), () => true)); }
        }

        public void OnShowHideCommand(object obj)
        {
            if (buttonState == ButtonState.Shown)
            {
                buttonState = ButtonState.Hidden;
                GridVisibility = Visibility.Collapsed;
                ButtonText = "Show";
            }
            else
            {
                buttonState = ButtonState.Shown;
                GridVisibility = Visibility.Visible;
                ButtonText = "Hide";
            }

        }

        ButtonState buttonState;
        enum ButtonState
        {
            Shown,
            Hidden
        }
    }


    //My Command.cs
    public class MyCommand : ICommand
    {
        Action<object> executeAction;
        Func<bool> canExecute;

        public MyCommand(Action<object> executeAction, Func<bool> canExecute)
        {
            this.executeAction = executeAction;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (canExecute != null)
                return canExecute();
            else
                return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (executeAction != null)
                executeAction(parameter);
        }
    }
}
