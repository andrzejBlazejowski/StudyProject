using StudyProject.Model;
using StudyProject.Model.EntitiesForViewModel;
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
    public class AllDeliveryItemsViewModel : AllViewModel<DeliveryItemForViewModel>
    {

        #region Constructor
        public AllDeliveryItemsViewModel(NavStore navStore, NavigationToolBarViewModel navToolBarvm)
            : base(navStore, navToolBarvm, "pozycje dostawy")
        {
            NavigateAddCmd =NavigateAddDeliveryItemsCmd;
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<DeliveryItemForViewModel>
                (

                  from delivery_item in ZaliczenieEntities.delivery_item
                  where delivery_item.is_active == true
                  select new DeliveryItemForViewModel
                  {
                      Id = delivery_item.id,
                      ComodityName = delivery_item.comodity.Name,
                      ComodityUnitPrice = delivery_item.comodity.gross_unit_price,
                      ComodityCategoryName = delivery_item.comodity.comodity_category.name,
                      ComoditySizeName = delivery_item.comodity.size_type.name,
                      Count = delivery_item.count,
                      CurencyName = delivery_item.curency.name,
                      CurrenvySign = delivery_item.curency.sign
                  }
                );
        }
        #endregion
    }
}
