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
        #endregion
    }
}
