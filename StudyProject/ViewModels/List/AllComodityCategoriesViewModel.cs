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
    public class AllComodityCategoriesViewModel : AllViewModel<comodity_category>
    {

        #region Constructor
        public AllComodityCategoriesViewModel()
            : base("typy towarów")
        {
            this.FilterField = "nazwa";
            this.SortField = "nazwa";
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
        public override List<string> GetFilterFields()
        {
            return new List<string> { "nazwa", "opis" };
        }
        public override void Filter()
        {
            switch (FilterField)
            {
                case "nazwa":
                    Data = new ObservableCollection<comodity_category>(Data.Where(item =>
                        item.name != null && item.name.Contains(FilterValue)));
                    break;
                case "opis":
                    Data = new ObservableCollection<comodity_category>(Data.Where(item =>
                        item.description != null && item.description.Contains(FilterValue)));
                    break;
            }
        }
        public override List<string> GetSortFields()
        {
            return new List<string> { "nazwa", "stawka Vat sprzedaży" };
        }
        public override void Sort()
        {
            switch (SortField)
            {
                case "stawka Vat sprzedaży":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<comodity_category>(Data.OrderByDescending(item => item.vat_rate));
                    }
                    else
                    {
                        Data = new ObservableCollection<comodity_category>(Data.OrderBy(item => item.vat_rate));
                    }
                    break;
                case "nazwa":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<comodity_category>(Data.OrderByDescending(item => item.name));
                    }
                    else
                    {
                        Data = new ObservableCollection<comodity_category>(Data.OrderBy(item => item.name));
                    }
                    break;
            }
        }
        #endregion
    }
}
