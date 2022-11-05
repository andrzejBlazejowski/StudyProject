
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
    public class AllDeliveryViewModel : AllViewModel<delivery>
    {

        #region Constructor
        public AllDeliveryViewModel(NavStore navStore, NavigationToolBarViewModel navToolBarvm)
            : base(navStore, navToolBarvm, "dostawy")
        {
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<delivery>
                (
                  
                  from delivery in ZaliczenieEntities.deliveries 
                  where delivery.is_active == true
                  select delivery 
                );
        }
        #endregion
    }
}
