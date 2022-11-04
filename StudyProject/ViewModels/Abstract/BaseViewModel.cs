using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.ViewModels.Abstract
{
    public class BaseViewModel:INotifyPropertyChanged
    {
        #region Fields
        public String Title { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null) PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
