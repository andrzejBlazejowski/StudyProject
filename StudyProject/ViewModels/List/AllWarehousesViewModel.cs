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
    public class AllWarehousesViewModel : AllViewModel<warehouse>
    {

        #region Constructor
        public AllWarehousesViewModel()
            : base("magazyny")
        {
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<warehouse>
                (

                  from warehouse in ZaliczenieEntities.warehouses
                  where warehouse.is_active == true
                  select warehouse
                );
        }
        #endregion
    }
}
