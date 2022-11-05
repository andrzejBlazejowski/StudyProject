
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
    public class AllPaymentMethodsViewModel : AllViewModel<payment_method>
    {

        #region Constructor
        public AllPaymentMethodsViewModel(NavStore navStore, NavigationToolBarViewModel navToolBarvm)
            : base(navStore, navToolBarvm, "metody płatności")
        {
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<payment_method>
                (
                  
                  from payment_method in ZaliczenieEntities.payment_method 
                  where payment_method.is_active == true
                  select payment_method 
                );
        }
        #endregion
    }
}
