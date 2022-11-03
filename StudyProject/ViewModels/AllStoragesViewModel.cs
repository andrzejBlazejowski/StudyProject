
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

namespace StudyProject.ViewModels
{
    public class AllStoragesViewModel : AllViewModel<storage>
    {

        #region Constructor
        public AllStoragesViewModel()
            : base("miejsca w magazynach")
        {
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<storage>
                (
                  
                  from storage in ZaliczenieEntities.storages 
                  where storage.is_active == true
                  select storage 
                );
        }
        #endregion
    }
}
