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
    public class AllContractorTypesViewModel : AllViewModel<contractor_type>
    {

        #region Constructor
        public AllContractorTypesViewModel()
            : base("typy kontrachentów")
        {
            this.FilterField = "nazwa";
            this.SortField = "nazwa";
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<contractor_type>
                (

                  from contractor_type in ZaliczenieEntities.contractor_type
                  where contractor_type.is_active == true
                  select contractor_type
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
                    Data = new ObservableCollection<contractor_type>(Data.Where(item =>
                        item.name != null && item.name.Contains(FilterValue)));
                    break;
                case "opis":
                    Data = new ObservableCollection<contractor_type>(Data.Where(item =>
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
                        Data = new ObservableCollection<contractor_type>(Data.OrderByDescending(item => item.name));
                    }
                    else
                    {
                        Data = new ObservableCollection<contractor_type>(Data.OrderBy(item => item.name));
                    }
                    break;
            }
        }
        #endregion
    }
}
