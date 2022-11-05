
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

namespace StudyProject.ViewModels
{
    public class AllContractorsViewModel : AllViewModel<contractor>
    {

        #region Constructor
        public AllContractorsViewModel(NavStore navStore, NavigationToolBarViewModel navToolBarvm)
            : base(navStore, navToolBarvm, "kontrachenci")
        {
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<contractor>
                (
                  
                  from contractors in ZaliczenieEntities.contractors 
                  where contractors.is_active == true
                  select contractors 
                );
        }
        #endregion
    }
}
