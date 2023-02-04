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
    public class AllStoragesViewModel : AllViewModel<StorageForViewModel>
    {

        #region Constructor
        public AllStoragesViewModel()
            : base("miejsca magazynowe")
        {
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<StorageForViewModel>
                (

                  from storage in ZaliczenieEntities.storages
                  where storage.is_active == true
                  select new StorageForViewModel 
                  { 
                    Id = storage.id,
                    Number = storage.number,
                    TotalCount = storage.total_count,
                    FreeCount = storage.free_count,
                    TakenCount = storage.taken_count,
                    WarehouseName = storage.warehouse.name,
                    SizeTypeName = storage.size_type.name
                  }
                );
        }
        #endregion
    }
}
