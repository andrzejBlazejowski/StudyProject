﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudyProject.Commands
{
    public abstract class CommandBase:ICommand
    {
        public event EventHandler CanExecuteChanged;
        public virtual bool CanExecute(object param) 
        {
            return true; 
        }
        public abstract void Execute(object param);

        protected void OnExecuteedChanged() 
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
