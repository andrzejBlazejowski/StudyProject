using StudyProject.Model;
using StudyProject.Model.EntitiesForViewModel;
using StudyProject.Stores;
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
        public AllInvoicesViewModel(NavStore navStore, NavigationToolBarViewModel navToolBarvm)
            : base(navStore, navToolBarvm, "faktury")
        {
            NavigateAddCmd = NavigateAddInvoicesCmd;
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
        #endregion
    }
}
