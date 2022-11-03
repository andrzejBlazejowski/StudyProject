
using StudyProject.Model;
using StudyProject.ViewModels.Abstract;
using System.Collections.ObjectModel;
using System.Linq;

namespace StudyProject.ViewModels
{
    public class AllBrandsViewModel : AllViewModel<brand>
    {

        #region Constructor
        public AllBrandsViewModel()
            : base("producenci")
        {
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
