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
            this.FilterField = "nazwa";
            this.SortField = "nazwa";

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
        public override List<string> GetFilterFields()
        {
            return new List<string> { "nazwa", "cena netto", "opis" };
        }
        public override void Filter()
        {
            switch (FilterField)
            {
                case "nazwa":
                    Data = new ObservableCollection<ComodityForViewModel>(Data.Where(item =>
                        item.Name != null && item.Name.Contains(FilterValue)));
                    break;
                case "opis":
                    Data = new ObservableCollection<ComodityForViewModel>(Data.Where(item =>
                        item.Description != null && item.Description.Contains(FilterValue)));
                    break;
                case "cena netto":
                    if (decimal.TryParse(FilterValue, out decimal decimalValue))
                    {
                        Data = new ObservableCollection<ComodityForViewModel>(Data.Where(item =>
                            item.NetUnitPrice.Equals(decimalValue)));
                    }
                    else
                    {
                        Console.WriteLine("The string could not be parsed into a decimal.");
                    };
                    break;
            }
        }
        public override List<string> GetSortFields()
        {
            return new List<string> { "nazwa", "cena netto" };
        }
        public override void Sort()
        {
            switch (SortField)
            {
                case "nazwa":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<ComodityForViewModel>(Data.OrderByDescending(item => item.Name));
                    }
                    else
                    {
                        Data = new ObservableCollection<ComodityForViewModel>(Data.OrderBy(item => item.Name));
                    }
                    break;
                case "cena netto":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<ComodityForViewModel>(Data.OrderByDescending(item => item.NetUnitPrice));
                    }
                    else
                    {
                        Data = new ObservableCollection<ComodityForViewModel>(Data.OrderBy(item => item.NetUnitPrice));
                    }
                    break;
            }
        }
        #endregion
    }
}
