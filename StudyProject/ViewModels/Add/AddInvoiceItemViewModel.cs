﻿
using GalaSoft.MvvmLight.Messaging;
using StudyProject.Commands;
using StudyProject.Model;
using StudyProject.Model.EntitiesForViewModel;
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
        public AddInvoiceItemViewModel()
            : base("pozycja faktury")
        {
            Item = new invoice_item();
            Messenger.Default.Register<InvoiceForViewModel>(this, handleInvoice);
            Messenger.Default.Register<ComodityForViewModel>(this, handleComodity);
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
                    base.OnPropertyChanged(()=>(Item.comodity_id));
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
                    base.OnPropertyChanged(()=>(Item.count));
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
                    base.OnPropertyChanged(()=>(Item.discount));
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
                    base.OnPropertyChanged(()=>(Item.invoice_id));
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
        public string InvoiceNumber { get; set; }
        public string ComodityName { get; set; }

        public override void Save()
        {
            Item.is_active = true;
            Item.create_date = DateTime.Now;
            DB.invoice_item.AddObject(Item);
            DB.SaveChanges();

        }

        private BaseCommand _LookupInvoice;
        public BaseCommand LookupInvoice
        {
            get
            {
                if (_LookupInvoice == null)
                {
                    _LookupInvoice = new BaseCommand(() => lookupInvoice());
                }
                return _LookupInvoice;
            }
        }

        public string comodityName { get; set; }

        private void handleInvoice(InvoiceForViewModel invoice)
        {
            InvoiceId = invoice.Id;
            Item.invoice_id = InvoiceId;
            InvoiceNumber = invoice.InvoiceNumber;
        }
        private void lookupInvoice()
        {
            Messenger.Default.Send("lookupInvoice");
        }

        private BaseCommand _LookupComodity;
        public BaseCommand LookupComodity
        {
            get
            {
                if (_LookupComodity == null)
                {
                    _LookupComodity = new BaseCommand(() => lookupComodity());
                }
                return _LookupComodity;
            }
        }

        private void handleComodity(ComodityForViewModel comodity)
        {
            ComodityId = comodity.Id;
            Item.comodity_id = comodity.Id;
            ComodityName = comodity.Name;
        }
        private void lookupComodity()
        {
            Messenger.Default.Send("lookupComodity");
        }
    }
}
