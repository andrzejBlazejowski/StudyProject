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

namespace StudyProject.ViewModels.List
{
    public class AllDeliveryStatusesViewModel : AllViewModel<delivery_status>
    {

        #region Constructor
        public AllDeliveryStatusesViewModel(NavStore navStore, NavigationToolBarViewModel navToolBarvm)
            : base(navStore, navToolBarvm, "pozycje dostawy")
        {
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<delivery_status>
                (

                  from delivery_status in ZaliczenieEntities.delivery_status
                  where delivery_status.is_active == true
                  select delivery_status
                );
        }
        #endregion
    }
}
