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
        #endregion
    }
}
