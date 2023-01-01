
using StudyProject.Model;
using StudyProject.Model.BusinessLogic;
using StudyProject.Model.EntitiesForViewModel;
using StudyProject.Stores;
using StudyProject.ViewModels.Abstract;
using System;
using System.Linq;


namespace StudyProject.ViewModels
{
    public class AddInvoiceViewModel : AddViewModel<invoice>
    {
        public AddInvoiceViewModel(NavStore navStore, NavigationToolBarViewModel navToolBarvm)
            : base(navStore, navToolBarvm, "producent")
        {
            Item = new invoice();
        }
        public int Id {
            get 
            {
                return Item.id;
            }
            set 
            {
                if (value != Item.id) { 
                    Item.id = value;
                    base.OnPropertyChanged(nameof(Item.id));
                }
            }
        }
        public string Number
        {
            get
            {
                return Item.invoice_number;
            }
            set
            {
                if (value != Item.invoice_number)
                {
                    Item.invoice_number = value;
                    base.OnPropertyChanged(nameof(Item.invoice_number));
                }
            }
        }
        public int ContractorId
        {
            get
            {
                return Item.contractor_id;
            }
            set
            {
                if (value != Item.contractor_id)
                {
                    Item.contractor_id = value;
                    base.OnPropertyChanged(nameof(Item.contractor_id));
                }
            }
        }
        public int PaymentMethodId
        {
            get
            {
                return Item.payment_method_id;
            }
            set
            {
                if (value != Item.payment_method_id)
                {
                    Item.payment_method_id = value;
                    base.OnPropertyChanged(nameof(Item.payment_method_id));
                }
            }
        }

        public IQueryable<KeyAndValue> PaymentMethods
        {
            get
            {
                return new PaymentMethodsB(DB).GetActivePaymentMethods();
            }
        }
        public DateTime PaymentDate
        {
            get
            {
                return Item.payment_date;
            }
            set
            {
                if (value != Item.payment_date)
                {
                    Item.payment_date = value;
                    base.OnPropertyChanged(nameof(Item.payment_date));
                }
            }
        }
        public decimal Discount
        {
            get
            {
                if (Item.discount != null) return (decimal)Item.discount;
                else return 0;
            }
            set
            {
                if (value != Item.discount)
                {
                    Item.discount = value;
                    base.OnPropertyChanged(nameof(Item.discount));
                }
            }
        }
        public decimal NetValue
        {
            get
            {
                return Item.net_value;
            }
            set
            {
                if (value != Item.net_value)
                {
                    Item.net_value = value;
                    base.OnPropertyChanged(nameof(Item.net_value));
                }
            }
        }
        public decimal GrossValue
        {
            get
            {
                return Item.gross_value;
            }
            set
            {
                if (value != Item.gross_value)
                {
                    Item.gross_value = value;
                    base.OnPropertyChanged(nameof(Item.gross_value));
                }
            }
        }
        public decimal PaidValue
        {
            get
            {
                return Item.paid_value;
            }
            set
            {
                if (value != Item.paid_value)
                {
                    Item.paid_value = value;
                    base.OnPropertyChanged(nameof(Item.paid_value));
                }
            }
        }
        public decimal PendingValue
        {
            get
            {
                return Item.pending_payment_value;
            }
            set
            {
                if (value != Item.pending_payment_value)
                {
                    Item.pending_payment_value = value;
                    base.OnPropertyChanged(nameof(Item.pending_payment_value));
                }
            }
        }
        public Boolean IsActive
        {
            get
            {
                return Item.is_active;
            }
            set
            {
                if (value != Item.is_active)
                {
                    Item.is_active = value;
                    base.OnPropertyChanged(nameof(Item.is_active));
                }
            }
        }
        public DateTime CreateDate
        {
            get
            {
                return Item.create_date;
            }
            set
            {
                if (value != Item.create_date)
                {
                    Item.create_date = value;
                    base.OnPropertyChanged(nameof(Item.create_date));
                }
            }
        }

        public override void Save()
        {
            Item.is_active = true;
            Item.create_date = DateTime.Now;
            Item.sale_date = DateTime.Now;
            Item.payment_date = DateTime.Now;
            DB.invoices.AddObject(Item);
            DB.SaveChanges();

        }
    }
}
