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
    public class AllstorageViewModel : AllViewModel<StorageForViewModel>
    {

        #region Constructor
        public AllstorageViewModel()
            : base("miejsca magazynowe")
        {
            this.FilterField = "magazyn";
            this.SortField = "magazyn";
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<StorageForViewModel>
                (

                  from storage in ZaliczenieEntities.storage
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
        public override List<string> GetSortFields()
        {
            return new List<string> { "magazyn", "zajęte", "wolne" };
        }
        public override void Filter()
        {
            switch (FilterField)
            {
                case "magazyn":
                    Data = new ObservableCollection<StorageForViewModel>(Data.Where(item =>
                        item.WarehouseName != null && item.WarehouseName.Contains(FilterValue)));
                    break;
                case "zajęte":
                    Data = new ObservableCollection<StorageForViewModel>(Data.Where(item =>
                        item.TakenCount.Equals(FilterValue)));
                    break;
                case "wolne":
                    Data = new ObservableCollection<StorageForViewModel>(Data.Where(item =>
                        item.FreeCount.Equals(FilterValue)));
                    break;
            }
        }
        public override List<string> GetFilterFields()
        {
            return new List<string> { "zajęte", "wolne", "ilośc miejsc", "magazyn"};
        }
        public override void Sort()
        {
            switch (SortField)
            {
                case "zajęte":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<StorageForViewModel>(Data.OrderByDescending(item => item.TakenCount));
                    }
                    else
                    {
                        Data = new ObservableCollection<StorageForViewModel>(Data.OrderBy(item => item.TakenCount));
                    }
                    break;
                case "wolne":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<StorageForViewModel>(Data.OrderByDescending(item => item.FreeCount));
                    }
                    else
                    {
                        Data = new ObservableCollection<StorageForViewModel>(Data.OrderBy(item => item.FreeCount));
                    }
                    break;
                case "magazyn":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<StorageForViewModel>(Data.OrderByDescending(item => item.WarehouseName));
                    }
                    else
                    {
                        Data = new ObservableCollection<StorageForViewModel>(Data.OrderBy(item => item.WarehouseName));
                    }
                    break;
                case "ilośc miejsc":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<StorageForViewModel>(Data.OrderByDescending(item => item.TotalCount));
                    }
                    else
                    {
                        Data = new ObservableCollection<StorageForViewModel>(Data.OrderBy(item => item.TotalCount));
                    }
                    break;
            }
        }
        #endregion
    }
}
