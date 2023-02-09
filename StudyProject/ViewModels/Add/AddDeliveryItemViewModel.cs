
using GalaSoft.MvvmLight.Messaging;
using StudyProject.Commands;
using StudyProject.Model;
using StudyProject.Model.BusinessLogic;
using StudyProject.Model.EntitiesForViewModel;
using StudyProject.Model.Validators;
using StudyProject.ViewModels;
using StudyProject.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;

namespace StudyProject.ViewModels
{
    public class AddDeliveryItemViewModel : AddViewModel<delivery_item>, IDataErrorInfo
    {
        public AddDeliveryItemViewModel()
            : base("pozycja dostawy")
        {
            Item = new delivery_item();
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
        public int comodity_id
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
        public int count
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
        public decimal unit_cost
        {
            get
            {
                return Item.unit_cost;
            }
            set
            {
                if (value != Item.unit_cost)
                {
                    Item.unit_cost = value;
                    base.OnPropertyChanged(()=>(Item.unit_cost));
                }
            }
        }
        public int delivery_id
        {
            get
            {
                return Item.delivery_id;
            }
            set
            {
                if (value != Item.delivery_id)
                {
                    Item.delivery_id = value;
                    base.OnPropertyChanged(()=>(Item.delivery_id));
                }
            }
        }
        public int curency_id
        {
            get
            {
                return Item.curency_id;
            }
            set
            {
                if (value != Item.curency_id)
                {
                    Item.curency_id = value;
                    base.OnPropertyChanged(()=>(Item.curency_id));
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
        public IQueryable<KeyAndValue> Curencies
        {
            get
            {
                return new CurencyB(DB).GetActiveCurencies();
            }
        }

        public override void Save()
        {
            Item.is_active = true;
            Item.create_date = DateTime.Now;
            DB.delivery_item.AddObject(Item);
            DB.SaveChanges();

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

        public string comodityName { get; set; }

        public string Error
        {
            get
            {
                return null;
            }
        }
        public string this[string name]
        {
            get
            {
                string msg = null;
                if (name == "count")
                {
                    msg = IntValidator.Positive(this.count);
                }
                if (name == "unit_cost")
                {
                    msg = DecimalValidator.Positive(this.unit_cost);
                }

                return msg;
            }
        }
        public override bool isValid()
        {
            if (this["count"] == null)
                return true;
            if (this["unit_cost"] == null)
                return true;
            return false;
        }
        private void handleComodity(ComodityForViewModel comodity)
        {
            comodity_id = comodity.Id;
            Item.comodity_id = comodity.Id;
            comodityName = comodity.Name;
        }
        private void lookupComodity()
        {
            Messenger.Default.Send("lookupComodity");
        }
    }
}
