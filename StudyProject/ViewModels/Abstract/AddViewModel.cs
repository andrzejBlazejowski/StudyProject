using StudyProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudyProject.ViewModels.Abstract
{
    public abstract class AddViewModel<T> : BaseViewModel
    {
        public ZaliczenieEntities DB { get; set; }
        public T Item { get; set; }
        public AddViewModel(string title)
        {
            base.Title = title;
            DB = new ZaliczenieEntities();
        }
        //private BaseCommand _SaveAndCloseCommand;
        /*public ICommand saveAndCloseCommand
        {
            get
            {
                if (_SaveAndCloseCommand == null)
                {
                    _SaveAndCloseCommand = new BaseCommand(() => saveAndClose());
                }
                return _SaveAndCloseCommand;
            }
        }*/

        public abstract void Save();
        private void saveAndClose()
        {
            Save();
            //base.OnRequestClose();
        }
    }
}
