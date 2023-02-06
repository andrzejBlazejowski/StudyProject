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
    public class AllEmplyeesViewModel : AllViewModel<EmployeeForViewModel>
    {

        #region Constructor
        public AllEmplyeesViewModel()
            : base("pracownicy")
        {
            this.FilterField = "magazyn w którym pracuje";
            this.SortField = "imie";
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<EmployeeForViewModel>
                (

                  from employ in ZaliczenieEntities.employs
                  where employ.is_active == true
                  select new EmployeeForViewModel
                  {
                      Id = employ.id,
                      FirstName = employ.first_name,
                      LastName = employ.last_name,
                      peselNumber = employ.pesel_number,
                      WarehouseName = employ.warehouse.name
                  }
                );
        }
        public override List<string> GetFilterFields()
        {
            return new List<string> { "magazyn w którym pracuje" };
        }
        public override void Filter()
        {
            switch (FilterField)
            {
                case "magazyn w którym pracuje":
                    Data = new ObservableCollection<EmployeeForViewModel>(Data.Where(item =>
                        item.WarehouseName != null && item.WarehouseName.Contains(FilterValue)));
                    break;
            }
        }
        public override List<string> GetSortFields()
        {
            return new List<string> { "imie", "nazwisko", "pesel" };
        }
        public override void Sort()
        {
            switch (SortField)
            {
                case "imie":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<EmployeeForViewModel>(Data.OrderByDescending(item => item.FirstName));
                    }
                    else
                    {
                        Data = new ObservableCollection<EmployeeForViewModel>(Data.OrderBy(item => item.FirstName));
                    }
                    break;
                case "nazwisko":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<EmployeeForViewModel>(Data.OrderByDescending(item => item.LastName));
                    }
                    else
                    {
                        Data = new ObservableCollection<EmployeeForViewModel>(Data.OrderBy(item => item.LastName));
                    }
                    break;
                case "pesel":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<EmployeeForViewModel>(Data.OrderByDescending(item => item.peselNumber));
                    }
                    else
                    {
                        Data = new ObservableCollection<EmployeeForViewModel>(Data.OrderBy(item => item.peselNumber));
                    }
                    break;
            }
        }
        #endregion
    }
}
