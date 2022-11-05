
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
    public class AllInvoicesViewModel : AllViewModel<invoice>
    {

        #region Constructor
        public AllInvoicesViewModel(NavStore navStore, NavigationToolBarViewModel navToolBarvm)
            : base(navStore, navToolBarvm, "faktury")
        {
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<invoice>
                (
                  
                  from invoice in ZaliczenieEntities.invoices 
                  where invoice.is_active == true
                  select invoice 
                );
        }
        #endregion
    }
}
