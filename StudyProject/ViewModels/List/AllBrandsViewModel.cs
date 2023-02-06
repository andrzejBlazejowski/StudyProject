using StudyProject.Model;

using StudyProject.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace StudyProject.ViewModels.List
{
    public class AllBrandsViewModel : AllViewModel<brand>
    {
        #region Constructor
        public AllBrandsViewModel(Boolean lookupMode = false)
            : base("producenci", lookupMode)
        {
            this.FilterField = "nazwa";
            this.SortField = "nazwa";
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<brand>
                (

                  from brand in ZaliczenieEntities.brands
                  where brand.is_active == true
                  select brand
                );
        }
        public override void Filter()
        {
            switch (FilterField)
            {
                case "kraj":
                    Data = new ObservableCollection<brand>(Data.Where(item =>
                        item.country != null && item.country.Contains(FilterValue)));
                    break;
                case "nazwa":
                    Data = new ObservableCollection<brand>(Data.Where(item =>
                        item.name != null && item.name.Contains(FilterValue)));
                    break;
                case "województwo":
                    Data = new ObservableCollection<brand>(Data.Where(item =>
                        item.state != null && item.state.Contains(FilterValue)));
                    break;
                case "opis":
                    Data = new ObservableCollection<brand>(Data.Where(item =>
                        item.description != null && item.description.Contains(FilterValue)));
                    break;
            }
        }
        public override List<string> GetFilterFields()
        {
            return new List<string> { "kraj", "opis", "nazwa", "województwo"  };
        }
        public override List<string> GetSortFields()
        {
            return new List<string> { "kraj", "nazwa", "województwo" };
        }
        public override void Sort()
        {
            switch (SortField)
            {
                case "nazwa":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<brand>(Data.OrderByDescending(item => item.name));
                    }
                    else
                    {
                        Data = new ObservableCollection<brand>(Data.OrderBy(item => item.name));
                    }
                    break;
                case "województwo":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<brand>(Data.OrderByDescending(item => item.state));
                    }
                    else
                    {
                        Data = new ObservableCollection<brand>(Data.OrderBy(item => item.state));
                    }
                    break;
                case "kraj":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<brand>(Data.OrderByDescending(item => item.country));
                    }
                    else 
                    {
                        Data = new ObservableCollection<brand>(Data.OrderBy(item => item.country));
                    }
                    break;
            }
        }
        #endregion
    }
}
