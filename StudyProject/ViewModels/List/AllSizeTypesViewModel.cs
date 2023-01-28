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
    public class AllSizeTypesViewModel : AllViewModel<size_type>
    {

        #region Constructor
        public AllSizeTypesViewModel()
            : base("dostępne rozmiary")
        {
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<size_type>
                (

                  from size_type in ZaliczenieEntities.size_type
                  where size_type.is_active == true
                  select size_type
                );
        }
        #endregion
    }
}
