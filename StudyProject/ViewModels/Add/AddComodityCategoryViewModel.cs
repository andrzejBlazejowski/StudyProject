
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
    public class AddComodityCategoryViewModel : AddViewModel<comodity_category>, IDataErrorInfo
    {
        public AddComodityCategoryViewModel()
            : base("typy produktow")
        {
            Item = new comodity_category();
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
                    base.OnPropertyChanged(()=>Item.id);
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
        public decimal vat_rate
        {
            get
            {
                return Item.vat_rate;
            }
            set
            {
                if (value != Item.vat_rate)
                {
                    Item.vat_rate = value;
                    base.OnPropertyChanged(()=>(Item.vat_rate));
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
            DB.comodity_category.AddObject(Item);
            DB.SaveChanges();

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
                if (name == "vat_rate")
                {
                    msg = DecimalValidator.Positive(this.vat_rate);
                }
      

                return msg;
            }
        }
        public override bool isValid()
        {
            if (this["Name"] == null)
                return true;
            if (this["vat_rate"] == null)
                return true;
            return false;
        }
    }
}
