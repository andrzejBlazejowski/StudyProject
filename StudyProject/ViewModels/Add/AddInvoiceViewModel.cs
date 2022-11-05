
using StudyProject.Model;
using StudyProject.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;

namespace Firma.ViewModels
{
    public class AddInvoiceViewModel : AddViewModel<invoice>
    {
        public AddInvoiceViewModel()
            : base("producent")
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
                return (decimal)Item.discount;
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
            DB.invoices.AddObject(Item);
            DB.SaveChanges();

        }
    }
}
