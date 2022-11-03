
using StudyProject.Model;

using StudyProject.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace StudyProject.ViewModels
{
    public class AllCurenciesViewModel : AllViewModel<curency>
    {

        #region Constructor
        public AllCurenciesViewModel()
            : base("waluty")
        {
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<curency>
                (
                  
                  from curency in ZaliczenieEntities.curencies 
                  where curency.is_active == true
                  select curency 
                );
        }
        #endregion
    }
}
