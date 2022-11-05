
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
    public class AllComodityCategoriesViewModel : AllViewModel<comodity_category>
    {

        #region Constructor
        public AllComodityCategoriesViewModel(NavStore navStore, NavigationToolBarViewModel navToolBarvm)
            : base(navStore, navToolBarvm, "kategorie towarow")
        {
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<comodity_category>
                (
                  
                  from comodity_category in ZaliczenieEntities.comodity_category 
                  where comodity_category.is_active == true
                  select comodity_category 
                );
        }
        #endregion
    }
}
