using StudyProject.Model;
using StudyProject.Stores;
using StudyProject.ViewModels.Abstract;
using System.Collections.ObjectModel;
using System.Linq;

namespace StudyProject.ViewModels.List
{
    public class AllBrandsViewModel : AllViewModel<brand>
    {
        #region Constructor
        public AllBrandsViewModel(NavStore navStore, NavigationToolBarViewModel navToolBarvm)
            : base(navStore, navToolBarvm, "producenci")
        {
            NavigateAddCmd = NavigateAddBrandsCmd;
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<brand>
                (

                  from brand in ZaliczenieEntities.brands
                  where brand.is_active == true
                  select brand
                );
        }
        #endregion
    }
}
