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
    public class AllInvoiceItemsViewModel : AllViewModel<InvoiceItemForViewModel>
    {

        #region Constructor
        public AllInvoiceItemsViewModel(NavStore navStore, NavigationToolBarViewModel navToolBarvm)
            : base(navStore, navToolBarvm, "pozycje faktury")
        {
            NavigateAddCmd =NavigateAddInvoiceItemsCmd;
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
        #endregion
    }
}
