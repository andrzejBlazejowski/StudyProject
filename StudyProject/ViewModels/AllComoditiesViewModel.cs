
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
    public class AllComoditiesViewModel: AllViewModel<comodity>
    {
        
        #region Constructor
        public AllComoditiesViewModel(NavStore navStore, NavigationToolBarViewModel navToolBarvm)
            : base(navStore, navToolBarvm, "towary")
        {
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<comodity>
                (
                
                  from comodity in ZaliczenieEntities.comodities 
                  where comodity.is_active==true
                  select comodity 
                );
        }
        #endregion
    }
}
