
using GalaSoft.MvvmLight.Messaging;
using StudyProject.Commands;
using StudyProject.Model;
using StudyProject.Model.BusinessLogic;
using StudyProject.Model.EntitiesForViewModel;

using StudyProject.ViewModels.Abstract;
using System;
using System.Linq;


namespace StudyProject.ViewModels
{
    public class AddInvoiceViewModel : AddViewModel<invoice>
    {
        public AddInvoiceViewModel()
            : base("producent")
        {
            Item = new invoice();
            Messenger.Default.Register<ContractorForViewModel>(this, handleContractor);
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
                    base.OnPropertyChanged(()=>(Item.id));
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
                    base.OnPropertyChanged(()=>(Item.invoice_number));
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
                    base.OnPropertyChanged(()=>(Item.contractor_id));
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
                    base.OnPropertyChanged(()=>(Item.payment_method_id));
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
                    base.OnPropertyChanged(()=>(Item.payment_date));
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
                    base.OnPropertyChanged(()=>(Item.discount));
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
                    base.OnPropertyChanged(()=>(Item.net_value));
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
                    base.OnPropertyChanged(()=>(Item.gross_value));
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
                    base.OnPropertyChanged(()=>(Item.paid_value));
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
                    base.OnPropertyChanged(()=>(Item.pending_payment_value));
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
                    base.OnPropertyChanged(()=>(Item.is_active));
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
                    base.OnPropertyChanged(()=>(Item.create_date));
                }
            }
        }
        public string ContractorName { get; set; }


        private BaseCommand _LookupContractor;
        public BaseCommand LookupContractor
        {
            get
            {
                if (_LookupContractor == null)
                {
                    _LookupContractor = new BaseCommand(() => lookupContractor());
                }
                return _LookupContractor;
            }
        }

        private void handleContractor(ContractorForViewModel contractor)
        {
            ContractorId = contractor.Id;
            Item.contractor_id = ContractorId;
            ContractorName = contractor.Name;
        }
        private void lookupContractor()
        {
            Messenger.Default.Send("lookupContractor");
        }
        public override void Save()
        {
            Item.is_active = true;
            Item.create_date = DateTime.Now;
            Item.sale_date = DateTime.Now;
            Item.payment_date = DateTime.Now;
            DB.invoice.AddObject(Item);
            DB.SaveChanges();

        }
    }
}
