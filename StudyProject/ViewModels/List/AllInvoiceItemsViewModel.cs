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
    public class AllInvoiceItemsViewModel : AllViewModel<InvoiceItemForViewModel>
    {

        #region Constructor
        public AllInvoiceItemsViewModel()
            : base("pozycje faktury")
        {
            this.FilterField = "towar";
            this.SortField = "towar";
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<InvoiceItemForViewModel>
                (

                  from invoice_item in ZaliczenieEntities.invoice_item
                  where invoice_item.is_active == true
                  select new InvoiceItemForViewModel 
                  { 
                    Id = invoice_item.id,
                    Count = invoice_item.count,
                    Discount = invoice_item.discount,
                    ComodityName = invoice_item.comodity.Name,
                    ComodityGrossPrice = invoice_item.comodity.gross_unit_price,
                    ComodityNetPrice = invoice_item.comodity.net_unit_price,
                    CategoryName = invoice_item.comodity.comodity_category.name,
                    SizeTypeName = invoice_item.comodity.size_type.name,
                    PaymentMethod = invoice_item.invoice.payment_method.name,
                    SaleDate = invoice_item.invoice.sale_date
                  }
                );
        }
        public override List<string> GetFilterFields()
        {
            return new List<string> { "towar", "rozmiar", "kategoria", "metoda płatności" };
        }
        public override void Filter()
        {
            switch (FilterField)
            {
                case "towar":
                    Data = new ObservableCollection<InvoiceItemForViewModel>(Data.Where(item =>
                        item.ComodityName != null && item.ComodityName.Contains(FilterValue)));
                    break;
                case "rozmiar":
                    Data = new ObservableCollection<InvoiceItemForViewModel>(Data.Where(item =>
                        item.SizeTypeName != null && item.SizeTypeName.Contains(FilterValue)));
                    break;
                case "kategoria":
                    Data = new ObservableCollection<InvoiceItemForViewModel>(Data.Where(item =>
                        item.CategoryName != null && item.CategoryName.Contains(FilterValue)));
                    break;
                case "metoda płatności":
                    Data = new ObservableCollection<InvoiceItemForViewModel>(Data.Where(item =>
                        item.PaymentMethod != null && item.PaymentMethod.Contains(FilterValue)));
                    break;
            }
        }
        public override List<string> GetSortFields()
        {
            return new List<string> { "Cena jednostkowa netto", "ilość", "towar" };
        }
        public override void Sort()
        {
            switch (SortField)
            {
                case "Cena jednostkowa netto":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<InvoiceItemForViewModel>(Data.OrderByDescending(item => item.ComodityNetPrice));
                    }
                    else
                    {
                        Data = new ObservableCollection<InvoiceItemForViewModel>(Data.OrderBy(item => item.ComodityNetPrice));
                    }
                    break;
                case "ilość":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<InvoiceItemForViewModel>(Data.OrderByDescending(item => item.Count));
                    }
                    else
                    {
                        Data = new ObservableCollection<InvoiceItemForViewModel>(Data.OrderBy(item => item.Count));
                    }
                    break;
                case "towar":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<InvoiceItemForViewModel>(Data.OrderByDescending(item => item.ComodityName));
                    }
                    else
                    {
                        Data = new ObservableCollection<InvoiceItemForViewModel>(Data.OrderBy(item => item.ComodityName));
                    }
                    break;
            }
        }
        #endregion
    }
}
