
using StudyProject.Model;
using StudyProject.Stores;
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
    public class AllEmplyeesViewModel : AllViewModel<employ>
    {

        #region Constructor
        public AllEmplyeesViewModel(NavStore navStore, NavigationToolBarViewModel navToolBarvm)
            : base(navStore, navToolBarvm, "pracownicy")
        {
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<employ>
                (
                  
                  from employ in ZaliczenieEntities.employs 
                  where employ.is_active == true
                  select employ 
                );
        }
        #endregion
    }
}
