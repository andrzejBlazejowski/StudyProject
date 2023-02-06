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
    public class AllInvoicesViewModel : AllViewModel<InvoiceForViewModel>
    {

        #region Constructor
        public AllInvoicesViewModel(Boolean lookupMode = false)
            : base("faktury", lookupMode)
        {
            this.FilterField = "adresat";
            this.SortField = "kontrachent";
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<InvoiceForViewModel>
                (

                  from invoice in ZaliczenieEntities.invoices
                  where invoice.is_active == true
                  select new InvoiceForViewModel
                  {
                    Id = invoice.id,
                    InvoiceNumber = invoice.invoice_number,
                    ContractorName = invoice.contractor.name,
                    ContractorCurrency = invoice.contractor.curency.name,
                    ContractorType = invoice.contractor.contractor_type.name,
                    IsContractorVatPayer = invoice.contractor.is_vat_taxpayer,
                    ContractorAddress =
                        invoice.contractor.state + ", " +
                        invoice.contractor.post_office_city + " " +
                        invoice.contractor.zip_code + ", " +
                        invoice.contractor.city + ", " +
                        invoice.contractor.street + ", " +
                        invoice.contractor.building_number + "/" +
                        invoice.contractor.flat_number,
                    SaleDate = invoice.sale_date,
                    Discount = invoice.discount,
                    PaymentDate = invoice.payment_date,
                    PaymentMethod = invoice.payment_method.name,
                    NetValue = invoice.net_value,
                    GrossValue = invoice.gross_value,
                    PaidValue = invoice.paid_value,
                    PendingPayment = invoice.pending_payment_value

                  }
                );
        }
        public override List<string> GetFilterFields()
        {
            return new List<string> { "adres", "kontrachent", "metoda płatności" };
        }
        public override void Filter()
        {
            switch (FilterField)
            {
                case "adres":
                    Data = new ObservableCollection<InvoiceForViewModel>(Data.Where(item =>
                        item.ContractorAddress != null && item.ContractorAddress.Contains(FilterValue)));
                    break;
                case "kontrachent":
                    Data = new ObservableCollection<InvoiceForViewModel>(Data.Where(item =>
                        item.ContractorName != null && item.ContractorName.Contains(FilterValue)));
                    break;
                case "metoda płatności":
                    Data = new ObservableCollection<InvoiceForViewModel>(Data.Where(item =>
                        item.PaymentMethod != null && item.PaymentMethod.Contains(FilterValue)));
                    break;
            }
        }
        public override List<string> GetSortFields()
        {
            return new List<string> { "wartość netto", "zapłacono", "do zapłaty", "kontrachent" };
        }
        public override void Sort()
        {
            switch (SortField)
            {
                case "wartość netto":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<InvoiceForViewModel>(Data.OrderByDescending(item => item.NetValue));
                    }
                    else
                    {
                        Data = new ObservableCollection<InvoiceForViewModel>(Data.OrderBy(item => item.NetValue));
                    }
                    break;
                case "do zapłaty":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<InvoiceForViewModel>(Data.OrderByDescending(item => item.PendingPayment));
                    }
                    else
                    {
                        Data = new ObservableCollection<InvoiceForViewModel>(Data.OrderBy(item => item.PendingPayment));
                    }
                    break;
                case "zapłacono":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<InvoiceForViewModel>(Data.OrderByDescending(item => item.PaidValue));
                    }
                    else
                    {
                        Data = new ObservableCollection<InvoiceForViewModel>(Data.OrderBy(item => item.PaidValue));
                    }
                    break;
                case "kontrachent":
                    if ("malejąco" == SortType)
                    {
                        Data = new ObservableCollection<InvoiceForViewModel>(Data.OrderByDescending(item => item.ContractorName));
                    }
                    else
                    {
                        Data = new ObservableCollection<InvoiceForViewModel>(Data.OrderBy(item => item.ContractorName));
                    }
                    break;
            }
        }
        #endregion
    }
}
