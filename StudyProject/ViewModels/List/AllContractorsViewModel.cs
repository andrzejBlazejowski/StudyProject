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
    public class AllContractorsViewModel : AllViewModel<ContractorForViewModel>
    {

        #region Constructor
        public AllContractorsViewModel()
            : base("kontrachenci") { }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<ContractorForViewModel>
                (

                  from contractors in ZaliczenieEntities.contractors
                  where contractors.is_active == true
                  select new ContractorForViewModel {
                    Id = contractors.id,
                    Name = contractors.name,
                    TaxNumber = contractors.tax_number,
                    TaxName = contractors.tax_name,
                    Address = 
                        contractors.state + ", " +
                        contractors.post_office_city + " " +
                        contractors.zip_code + ", " +
                        contractors.city + ", " +
                        contractors.street + ", " +
                        contractors.building_number + "/" +
                        contractors.flat_number,
                    AdditionalInfo = contractors.additional_info,
                    IsVatTaxpayer = contractors.is_vat_taxpayer,
                    CurrencyName = contractors.curency.name,
                    CurrencySign = contractors.curency.sign,
                    ContractorType = contractors.contractor_type.name
                  }
                );
        }
        #endregion
    }
}
