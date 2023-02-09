
using StudyProject.Model;
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
    public class AddDeliveryStatusViewModel : AddViewModel<delivery_status>, IDataErrorInfo
    {
        public AddDeliveryStatusViewModel()
            : base("statusy dostawy")
        {
            Item = new delivery_status();
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
                return Item.Name;
            }
            set
            {
                if (value != Item.Name)
                {
                    Item.Name = value;
                    base.OnPropertyChanged(()=>(Item.Name));
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
                if (name == "Name")
                {
                    msg = StringValidator.NotEmpty(this.Name);
                }
                return msg;
            }
        }
        public override bool isValid()
        {
            if (this["Name"] == null)
                return true;
            return false;
        }

        public override void Save()
        {
            Item.is_active = true;
            Item.create_date = DateTime.Now;
            DB.delivery_status.AddObject(Item);
            DB.SaveChanges();

        }
    }
}
