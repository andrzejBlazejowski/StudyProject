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
    public class AllComoditiesViewModel : AllViewModel<ComodityForViewModel>
    {

        #region Constructor
        public AllComoditiesViewModel(Boolean lookupMode = false)
            : base("towary", lookupMode)
        {
            
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<ComodityForViewModel>
                (

                  from comodity in ZaliczenieEntities.comodities
                  where comodity.is_active == true
                  select new ComodityForViewModel
                  {
                      Id = comodity.brand_id,
                      Name = comodity.Name,
                      Description = comodity.Description,
                      NetUnitPrice = comodity.net_unit_price,
                      VatRate = comodity.vat_rate,
                      GrossUnitPrice = comodity.gross_unit_price,
                      CategoryName = comodity.comodity_category.name,
                      SizeType = comodity.size_type.name,
                      BrandName = comodity.brand.name,
                      BrandAddres = 
                        comodity.brand.country + ", " +
                        comodity.brand.state + ", " +
                        comodity.brand.city
                  }
                );
        }
        #endregion
    }
}
