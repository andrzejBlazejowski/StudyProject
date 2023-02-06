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
    public class AllSizeTypesViewModel : AllViewModel<size_type>
    {

        #region Constructor
        public AllSizeTypesViewModel()
            : base("rozmiary")
        {
            this.FilterField = "nazwa";
            this.SortField = "nazwa";
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<size_type>
                (

                  from size_type in ZaliczenieEntities.size_type
                  where size_type.is_active == true
                  select size_type
                );
        }
        public override List<string> GetFilterFields()
        {
            return new List<string> { "nazwa" };
        }
        public override void Filter()
        {
            switch (FilterField)
            {
                case "country":
                    Data = new ObservableCollection<size_type>(Data.Where(item =>
                        item.name != null && item.name.Contains(FilterValue)));
                    break;
            }
        }
        public override List<string> GetSortFields()
        {
            return new List<string> { "nazwa", "wysokość", "szerokość" };
        }
        public override void Sort()
        {
            switch (SortField)
            {
                case "nazwa":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<size_type>(Data.OrderByDescending(item => item.name));
                    }
                    else
                    {
                        Data = new ObservableCollection<size_type>(Data.OrderBy(item => item.name));
                    }
                    break;
                case "wysokość":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<size_type>(Data.OrderByDescending(item => item.max_height));
                    }
                    else
                    {
                        Data = new ObservableCollection<size_type>(Data.OrderBy(item => item.max_height));
                    }
                    break;
                case "szerokość":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<size_type>(Data.OrderByDescending(item => item.max_width));
                    }
                    else
                    {
                        Data = new ObservableCollection<size_type>(Data.OrderBy(item => item.max_width));
                    }
                    break;
            }
        }
        #endregion
    }
}
