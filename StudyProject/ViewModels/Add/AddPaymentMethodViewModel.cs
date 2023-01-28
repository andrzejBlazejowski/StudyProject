
using StudyProject.Model;

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
    public class AddPaymentMethodViewModel : AddViewModel<payment_method>
    {
        public AddPaymentMethodViewModel()
            : base("metody patnosci")
        {
            Item = new payment_method();
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
        public string Name
        {
            get
            {
                return Item.name;
            }
            set
            {
                if (value != Item.name)
                {
                    Item.name = value;
                    base.OnPropertyChanged(()=>(Item.name));
                }
            }
        }
        public string Description
        {
            get
            {
                return Item.description;
            }
            set
            {
                if (value != Item.description)
                {
                    Item.description = value;
                    base.OnPropertyChanged(()=>(Item.description));
                }
            }
        }
        public bool IsAvailabelInternally
        {
            get
            {
                return Item.is_available_internally;
            }
            set
            {
                if (value != Item.is_available_internally)
                {
                    Item.is_available_internally = value;
                    base.OnPropertyChanged(()=>(Item.is_available_internally));
                }
            }
        }
        public bool IsAvailabelExternally
        {
            get
            {
                return Item.is_available_externally;
            }
            set
            {
                if (value != Item.is_available_externally)
                {
                    Item.is_available_externally = value;
                    base.OnPropertyChanged(()=>(Item.is_available_externally));
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

        public override void Save()
        {
            Item.is_active = true;
            Item.create_date = DateTime.Now;
            DB.payment_method.AddObject(Item);
            DB.SaveChanges();

        }
    }
}
