using StudyProject.Model;
using StudyProject.Stores;
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
        public AllContractorTypesViewModel(NavStore navStore, NavigationToolBarViewModel navToolBarvm)
            : base(navStore, navToolBarvm, "typy kontrachentów")
        {
            NavigateAddCmd = NavigateAddContractorTypesCmd;
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
        #endregion
    }
}
