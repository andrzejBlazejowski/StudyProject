
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
    public class AddBrandViewModel : AddViewModel<brand>, IDataErrorInfo
    {
        public AddBrandViewModel()
            : base("producent")
        {
            Item = new brand();
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
                    base.OnPropertyChanged(() => (Item.id));
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
                    base.OnPropertyChanged(() => (Item.name));
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
                    base.OnPropertyChanged(() => (Item.description));
                }
            }
        }
        public string Country
        {
            get
            {
                return Item.country;
            }
            set
            {
                if (value != Item.country)
                {
                    Item.country = value;
                    base.OnPropertyChanged(() => (Item.country));
                }
            }
        }
        public string State
        {
            get
            {
                return Item.state;
            }
            set
            {
                if (value != Item.state)
                {
                    Item.state = value;
                    base.OnPropertyChanged(() => (Item.state));
                }
            }
        }
        public string City
        {
            get
            {
                return Item.city;
            }
            set
            {
                if (value != Item.city)
                {
                    Item.city = value;
                    base.OnPropertyChanged(() => (Item.city));
                }
            }
        }
        public string Street
        {
            get
            {
                return Item.street;
            }
            set
            {
                if (value != Item.street)
                {
                    Item.street = value;
                    base.OnPropertyChanged(() => (Item.street));
                }
            }
        }
        public string Building_number
        {
            get
            {
                return Item.building_number;
            }
            set
            {
                if (value != Item.building_number)
                {
                    Item.building_number = value;
                    base.OnPropertyChanged(() => (Item.building_number));
                }
            }
        }
        public string Flat_number
        {
            get
            {
                return Item.flat_number;
            }
            set
            {
                if (value != Item.flat_number)
                {
                    Item.flat_number = value;
                    base.OnPropertyChanged(() => (Item.flat_number));
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
                    base.OnPropertyChanged(() => (Item.is_active));
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
                    base.OnPropertyChanged(() => (Item.create_date));
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
                if (name == "Country")
                {
                    msg = StringValidator.NotEmpty(this.Country);
                }
                if (name == "State")
                {
                    msg = StringValidator.NotEmpty(this.State);
                }
                if (name == "City")
                {
                    msg = StringValidator.NotEmpty(this.City);
                }
                if (name == "Street")
                {
                    msg = StringValidator.NotEmpty(this.Street);
                }
                if (name == "Building_number")
                {
                    msg = StringValidator.NotEmpty(this.Building_number);
                }
                if (name == "Flat_number")
                {
                    msg = StringValidator.NotEmpty(this.Flat_number);
                }
                
                return msg;
            }
        }
        public override bool isValid() 
        {
            if (this["Name"] == null)
                return true;
            if (this["Country"] == null)
                return true;
            if (this["State"] == null)
                return true;
            if (this["City"] == null)
                return true;
            if (this["Street"] == null)
                return true;
            if (this["Building_number"] == null)
                return true;
            if (this["Flat_number"] == null)
                return true;
            return false;
        }
        public override void Save()
        {
            Item.is_active = true;
            Item.create_date = DateTime.Now;
            DB.brands.AddObject(Item);
            DB.SaveChanges();
        }
    }
}
