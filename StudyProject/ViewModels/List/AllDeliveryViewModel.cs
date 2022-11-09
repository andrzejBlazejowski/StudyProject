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
    public class AllDeliveryViewModel : AllViewModel<DeliveryForViewModel>
    {

        #region Constructor
        public AllDeliveryViewModel(NavStore navStore, NavigationToolBarViewModel navToolBarvm)
            : base(navStore, navToolBarvm, "dostawy")
        {
            NavigateAddCmd = NavigateAddDeliveryCmd;
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<DeliveryForViewModel>
                (
                  from delivery in ZaliczenieEntities.deliveries
                  where delivery.is_active == true
                  select new DeliveryForViewModel 
                  { 
                    Id = delivery.id,
                    number = delivery.number,
                    destinationWarehouseName = delivery.warehouse.name,
                    sourceContractorName = delivery.contractor.name,
                    sourceWarehouseName = delivery.warehouse1.name,
                    sourceContractorAddress =
                        delivery.contractor.state + ", " +
                        delivery.contractor.city,
                    paymentMethod = delivery.payment_method.name,
                    DeliveryStatus = delivery.delivery_status.Name,
                    createDate = delivery.create_date,
                    dueDate = delivery.due_date
                  }
                );
        }
        #endregion
    }
}
