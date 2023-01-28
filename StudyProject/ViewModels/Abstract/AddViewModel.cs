using StudyProject.Commands;
using StudyProject.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudyProject.ViewModels.Abstract
{
    public abstract class AddViewModel<T> : TabVM
    {
        public ZaliczenieEntities DB { get; set; }
        private ICommand _SaveCommand;
        public ICommand saveCommand
        {
            get
            {
                if (_SaveCommand == null)
                {
                    //_SaveCommand = new SaveCmd(() => Save());
                }
                return _SaveCommand;
            }
        }
        /*public abstract ICommand saveAndCloseCommand();*/
       
        public T Item { get; set; }
        public AddViewModel(string title)
        {
            base.Title = title;
            DB = new ZaliczenieEntities();
        }

        public abstract void Save();
        private void saveAndClose()
        {
            Save();
        }
    }
}
