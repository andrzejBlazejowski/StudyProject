
using StudyProject.Model;
using StudyProject.Stores;
using StudyProject.ViewModels;
using StudyProject.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;

namespace StudyProject.ViewModels
{
    public class AddInvoiceItemViewModel : AddViewModel<invoice_item>
    {
        public AddInvoiceItemViewModel(NavStore navStore, NavigationToolBarViewModel navToolBarvm)
            : base(navStore, navToolBarvm, "pozycja faktury")
        {
            Item = new invoice_item();
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
        public int ComodityId
        {
            get
            {
                return Item.comodity_id;
            }
            set
            {
                if (value != Item.comodity_id)
                {
                    Item.comodity_id = value;
                    base.OnPropertyChanged(nameof(Item.comodity_id));
                }
            }
        }
        public int Count
        {
            get
            {
                return Item.count;
            }
            set
            {
                if (value != Item.count)
                {
                    Item.count = value;
                    base.OnPropertyChanged(nameof(Item.count));
                }
            }
        }
        public string Discount
        {
            get
            {
                return Item.discount;
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
        public int InvoiceId
        {
            get
            {
                return Item.invoice_id;
            }
            set
            {
                if (value != Item.invoice_id)
                {
                    Item.invoice_id = value;
                    base.OnPropertyChanged(nameof(Item.invoice_id));
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
            DB.invoice_item.AddObject(Item);
            DB.SaveChanges();

        }
    }
}
