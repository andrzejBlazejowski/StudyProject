
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
    public class AddBrandViewModel : AddViewModel<brand>
    {
        public AddBrandViewModel(NavStore navStore, NavigationToolBarViewModel navToolBarvm)
            : base(navStore, navToolBarvm, "producent")
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
                    base.OnPropertyChanged(nameof(Item.id));
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
                    base.OnPropertyChanged(nameof(Item.name));
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
                    base.OnPropertyChanged(nameof(Item.description));
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
                    base.OnPropertyChanged(nameof(Item.country));
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
                    base.OnPropertyChanged(nameof(Item.state));
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
                    base.OnPropertyChanged(nameof(Item.city));
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
                    base.OnPropertyChanged(nameof(Item.street));
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
                    base.OnPropertyChanged(nameof(Item.building_number));
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
                    base.OnPropertyChanged(nameof(Item.flat_number));
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
            DB.brands.AddObject(Item);
            DB.SaveChanges();

        }
    }
}
