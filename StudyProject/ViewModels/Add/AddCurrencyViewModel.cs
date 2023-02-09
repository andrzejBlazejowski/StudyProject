
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
    public class AddCurrencyViewModel : AddViewModel<curency>, IDataErrorInfo
    {
        public AddCurrencyViewModel()
            : base("waluta")
        {
            Item = new curency();
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
        public decimal ConvertRate
        {
            get
            {
                return Item.convert_rate;
            }
            set
            {
                if (value != Item.convert_rate)
                {
                    Item.convert_rate = value;
                    base.OnPropertyChanged(()=>(Item.convert_rate));
                }
            }
        }
        public string isDefault
        {
            get
            {
                return Item.is_default;
            }
            set
            {
                if (value != Item.is_default)
                {
                    Item.is_default = value;
                    base.OnPropertyChanged(()=>(Item.is_default));
                }
            }
        }
        public string Sign
        {
            get
            {
                return Item.sign;
            }
            set
            {
                if (value != Item.sign)
                {
                    Item.sign = value;
                    base.OnPropertyChanged(()=>(Item.sign));
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
                if (name == "ConvertRate")
                {
                    msg = DecimalValidator.Positive(this.ConvertRate);
                }
                if (name == "Sign")
                {
                    msg = StringValidator.NotEmpty(this.Sign);
                }


                return msg;
            }
        }
        public override bool isValid()
        {
            if (this["Name"] == null)
                return true;
            if (this["ConvertRate"] == null)
                return true;
            if (this["Sign"] == null)
                return true;
            return false;
        }

    public override void Save()
        {
            Item.is_active = true;
            Item.create_date = DateTime.Now;
            DB.curencies.AddObject(Item);
            DB.SaveChanges();

        }
    }
}
