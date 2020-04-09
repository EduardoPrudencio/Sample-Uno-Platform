using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace UnoSample.Shared.Command
{
    public class LoginCommand : ICommand
    {
        private SimpleEventHandler handler;
        public event EventHandler CanExecuteChanged;
        public delegate void SimpleEventHandler();

        //public event EventHandler CanExecuteChanged;

        public LoginCommand(SimpleEventHandler handler)
        {
            this.handler = handler;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.handler();
        }
    }
}
