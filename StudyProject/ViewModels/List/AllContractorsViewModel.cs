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
        public AllContractorsViewModel(Boolean lookupMode = false)
            : base("kontrachenci", lookupMode)
        {
            this.FilterField = "nazwa";
            this.SortField = "nazwa";
        }
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
        public override List<string> GetFilterFields()
        {
            return new List<string> { "nazwa", "nip", "dodatkowe informacje" };
        }
        public override void Filter()
        {
            switch (FilterField)
            {
                case "nazwa":
                    Data = new ObservableCollection<ContractorForViewModel>(Data.Where(item =>
                        item.Name != null && item.Name.Contains(FilterValue)));
                    break;
                case "nip":
                    Data = new ObservableCollection<ContractorForViewModel>(Data.Where(item =>
                        item.TaxName != null && item.TaxName.Contains(FilterValue)));
                    break;
                case "dodatkowe informacje":
                    Data = new ObservableCollection<ContractorForViewModel>(Data.Where(item =>
                        item.AdditionalInfo != null && item.AdditionalInfo.Contains(FilterValue)));
                    break;
            }
        }
        public override List<string> GetSortFields()
        {
            return new List<string> { "nazwa", "nazwa księgowa", "czy płaci Vat", "typ kontrachenta" };
        }
        public override void Sort()
        {
            switch (SortField)
            {
                case "nazwa":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<ContractorForViewModel>(Data.OrderByDescending(item => item.Name));
                    }
                    else
                    {
                        Data = new ObservableCollection<ContractorForViewModel>(Data.OrderBy(item => item.Name));
                    }
                    break;
                case "nazwa księgowa":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<ContractorForViewModel>(Data.OrderByDescending(item => item.TaxName));
                    }
                    else
                    {
                        Data = new ObservableCollection<ContractorForViewModel>(Data.OrderBy(item => item.TaxName));
                    }
                    break;
                case "czy płaci Vat":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<ContractorForViewModel>(Data.OrderByDescending(item => item.IsVatTaxpayer));
                    }
                    else
                    {
                        Data = new ObservableCollection<ContractorForViewModel>(Data.OrderBy(item => item.IsVatTaxpayer));
                    }
                    break;
                case "typ kontrachenta":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<ContractorForViewModel>(Data.OrderByDescending(item => item.ContractorType));
                    }
                    else
                    {
                        Data = new ObservableCollection<ContractorForViewModel>(Data.OrderBy(item => item.ContractorType));
                    }
                    break;
            }
        }
        #endregion
    }
}
