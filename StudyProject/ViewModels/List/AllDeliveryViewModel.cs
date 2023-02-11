using StudyProject.Model;
using StudyProject.Model.EntitiesForViewModel;

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
        public AllDeliveryViewModel(Boolean lookupMode = false)
            : base("dostawy", lookupMode)
        {
            this.FilterField = "Adresat";
            this.SortField = "numer";
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<DeliveryForViewModel>
                (
                  from delivery in ZaliczenieEntities.delivery
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
        public override List<string> GetFilterFields()
        {
            return new List<string> { "Adresat", "Nadawca - nazwa", "Nadawca - kontrachent", "status", "Sposób płatności" };
        }
        public override void Filter()
        {
            switch (FilterField)
            {
                case "Adresat":
                    Data = new ObservableCollection<DeliveryForViewModel>(Data.Where(item =>
                        item.destinationWarehouseName != null && item.destinationWarehouseName.Contains(FilterValue)));
                    break;
                case "Nadawca - nazwa":
                    Data = new ObservableCollection<DeliveryForViewModel>(Data.Where(item =>
                        item.sourceContractorName != null && item.sourceContractorName.Contains(FilterValue)));
                    break;
                case "Nadawca - kontrachent":
                    Data = new ObservableCollection<DeliveryForViewModel>(Data.Where(item =>
                        item.sourceContractorName != null && item.sourceContractorName.Contains(FilterValue)));
                    break;
                case "status":
                    Data = new ObservableCollection<DeliveryForViewModel>(Data.Where(item =>
                        item.DeliveryStatus != null && item.DeliveryStatus.Contains(FilterValue)));
                    break;
                case "Sposób płatności":
                    Data = new ObservableCollection<DeliveryForViewModel>(Data.Where(item =>
                        item.paymentMethod != null && item.paymentMethod.Contains(FilterValue)));
                    break;
            }
        }
        public override List<string> GetSortFields()
        {
            return new List<string> { "numer", "data dostawy", "data stworzenia" };
        }
        public override void Sort()
        {
            switch (SortField)
            {
                case "numer":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<DeliveryForViewModel>(Data.OrderByDescending(item => item.number));
                    }
                    else
                    {
                        Data = new ObservableCollection<DeliveryForViewModel>(Data.OrderBy(item => item.number));
                    }
                    break;
                case "data dostawy":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<DeliveryForViewModel>(Data.OrderByDescending(item => item.dueDate));
                    }
                    else
                    {
                        Data = new ObservableCollection<DeliveryForViewModel>(Data.OrderBy(item => item.dueDate));
                    }
                    break;
                case "data stworzenia":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<DeliveryForViewModel>(Data.OrderByDescending(item => item.createDate));
                    }
                    else
                    {
                        Data = new ObservableCollection<DeliveryForViewModel>(Data.OrderBy(item => item.createDate));
                    }
                    break;
            }
        }
        #endregion
    }
}
