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
    public class AllEmplyeeTypesViewModel : AllViewModel<employ_type>
    {

        #region Constructor
        public AllEmplyeeTypesViewModel()
            : base("typy pracowników")
        {
            this.FilterField = "nazwa";
            this.SortField = "nazwa";
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<employ_type>
                (

                  from employ_type in ZaliczenieEntities.employ_type
                  where employ_type.is_active == true
                  select employ_type
                );
        }
        public override List<string> GetFilterFields()
        {
            return new List<string> { "opis", "nazwa"};
        }
        public override void Filter()
        {
            switch (FilterField)
            {
                case "opis":
                    Data = new ObservableCollection<employ_type>(Data.Where(item =>
                        item.description != null && item.description.Contains(FilterValue)));
                    break;
                case "nazwa":
                    Data = new ObservableCollection<employ_type>(Data.Where(item =>
                        item.name != null && item.name.Contains(FilterValue)));
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
                        Data = new ObservableCollection<employ_type>(Data.OrderByDescending(item => item.name));
                    }
                    else
                    {
                        Data = new ObservableCollection<employ_type>(Data.OrderBy(item => item.name));
                    }
                    break;
            }
        }
        #endregion
    }
}
