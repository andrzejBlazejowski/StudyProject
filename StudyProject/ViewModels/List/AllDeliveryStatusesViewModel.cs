using StudyProject.Model;

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
        public AllDeliveryStatusesViewModel()
            : base("statusy dostawy")
        {
            this.FilterField = "nazwa";
            this.SortField = "nazwa";
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
        public override List<string> GetFilterFields()
        {
            return new List<string> { "nazwa", "opis" };
        }
        public override void Filter()
        {
            switch (FilterField)
            {
                case "nazwa":
                    Data = new ObservableCollection<delivery_status>(Data.Where(item =>
                        item.Name != null && item.Name.Contains(FilterValue)));
                    break;
                case "opis":
                    Data = new ObservableCollection<delivery_status>(Data.Where(item =>
                        item.description != null && item.description.Contains(FilterValue)));
                    break;
            }
        }
        public override List<string> GetSortFields()
        {
            return new List<string> { "nazwa" };
        }
        public override void Sort()
        {
            switch (SortField)
            {
                case "nazwa":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<delivery_status>(Data.OrderByDescending(item => item.Name));
                    }
                    else
                    {
                        Data = new ObservableCollection<delivery_status>(Data.OrderBy(item => item.Name));
                    }
                    break;
            }
        }
        #endregion
    }
}
