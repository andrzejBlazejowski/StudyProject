using StudyProject.Commands;
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
using System.Windows.Navigation;

namespace StudyProject.ViewModels.List
{
    public class AllCurenciesViewModel : AllViewModel<curency>
    {
        #region Constructor
        public AllCurenciesViewModel()
            : base("waluty")
        {
            this.FilterField = "nazwa";
            this.SortField = "nazwa";
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<curency>
                (

                  from curency in ZaliczenieEntities.curencies
                  where curency.is_active == true
                  select curency
                );
        }
        public override List<string> GetFilterFields()
        {
            return new List<string> { "nazwa", "znak" };
        }
        public override void Filter()
        {
            switch (FilterField)
            {
                case "nazwa":
                    Data = new ObservableCollection<curency>(Data.Where(item =>
                        item.name != null && item.name.Contains(FilterValue)));
                    break;
                case "znak":
                    Data = new ObservableCollection<curency>(Data.Where(item =>
                        item.sign != null && item.sign.Contains(FilterValue)));
                    break;
            }
        }
        public override List<string> GetSortFields()
        {
            return new List<string> { "nazwa", "przelicznik" };
        }
        public override void Sort()
        {
            switch (SortField)
            {
                case "nazwa":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<curency>(Data.OrderByDescending(item => item.name));
                    }
                    else
                    {
                        Data = new ObservableCollection<curency>(Data.OrderBy(item => item.name));
                    }
                    break;
                case "przelicznik":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<curency>(Data.OrderByDescending(item => item.convert_rate));
                    }
                    else
                    {
                        Data = new ObservableCollection<curency>(Data.OrderBy(item => item.convert_rate));
                    }
                    break;
            }
        }
        #endregion
    }
}
