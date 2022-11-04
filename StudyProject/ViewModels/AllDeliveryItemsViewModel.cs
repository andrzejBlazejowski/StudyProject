
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
    public class AllDeliveryItemsViewModel : AllViewModel<delivery_item>
    {

        #region Constructor
        public AllDeliveryItemsViewModel(NavStore navStore)
            : base(navStore, "pozycje dostawy")
        {
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<delivery_item>
                (
                  
                  from delivery_item in ZaliczenieEntities.delivery_item 
                  where delivery_item.is_active == true
                  select delivery_item 
                );
        }
        #endregion
    }
}
