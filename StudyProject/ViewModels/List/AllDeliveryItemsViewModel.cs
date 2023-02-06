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
    public class AllDeliveryItemsViewModel : AllViewModel<DeliveryItemForViewModel>
    {

        #region Constructor
        public AllDeliveryItemsViewModel()
            : base("pozycje dostawy")
        {
            this.FilterField = "liczba";
            this.SortField = "towar";
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
                      DeliveryNumber = delivery_item.delivery.number,
                      Count = delivery_item.count,
                      CurencyName = delivery_item.curency.name,
                      CurrenvySign = delivery_item.curency.sign
                  }
                );
        }
        public override List<string> GetFilterFields()
        {
            return new List<string> { "liczba" };
        }
        public override void Filter()
        {
            switch (FilterField)
            {
                case "liczba":
                    Data = new ObservableCollection<DeliveryItemForViewModel>(Data.Where(item =>
                       item.Count.Equals(FilterValue)));
                    break;
            }
        }
        public override List<string> GetSortFields()
        {
            return new List<string> { "towar", "rozmiar towaru", "waluta", "kategoria towaru" };
        }
        public override void Sort()
        {
            switch (SortField)
            {
                case "towar":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<DeliveryItemForViewModel>(Data.OrderByDescending(item => item.ComodityName));
                    }
                    else
                    {
                        Data = new ObservableCollection<DeliveryItemForViewModel>(Data.OrderBy(item => item.ComodityName));
                    }
                    break;
                case "rozmiar towaru":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<DeliveryItemForViewModel>(Data.OrderByDescending(item => item.ComoditySizeName));
                    }
                    else
                    {
                        Data = new ObservableCollection<DeliveryItemForViewModel>(Data.OrderBy(item => item.ComoditySizeName));
                    }
                    break;
                case "kategoria towaru":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<DeliveryItemForViewModel>(Data.OrderByDescending(item => item.ComodityCategoryName));
                    }
                    else
                    {
                        Data = new ObservableCollection<DeliveryItemForViewModel>(Data.OrderBy(item => item.ComodityCategoryName));
                    }
                    break;
                case "waluta":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<DeliveryItemForViewModel>(Data.OrderByDescending(item => item.CurencyName));
                    }
                    else
                    {
                        Data = new ObservableCollection<DeliveryItemForViewModel>(Data.OrderBy(item => item.CurencyName));
                    }
                    break;
            }
        }
        #endregion
    }
}
