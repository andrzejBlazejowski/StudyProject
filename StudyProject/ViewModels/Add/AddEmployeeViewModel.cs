
using StudyProject.Model;
using StudyProject.Model.BusinessLogic;
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
    public class AddEmployeeViewModel : AddViewModel<employ>
    {
        public AddEmployeeViewModel()
            : base("pracownik")
        {
            Item = new employ();
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
        public string FirstName
        {
            get
            {
                return Item.first_name;
            }
            set
            {
                if (value != Item.first_name)
                {
                    Item.first_name = value;
                    base.OnPropertyChanged(()=>(Item.first_name));
                }
            }
        }
        public string LastName
        {
            get
            {
                return Item.last_name;
            }
            set
            {
                if (value != Item.last_name)
                {
                    Item.last_name = value;
                    base.OnPropertyChanged(()=>(Item.last_name));
                }
            }
        }
        public string MiddleName
        {
            get
            {
                return Item.middle_name;
            }
            set
            {
                if (value != Item.middle_name)
                {
                    Item.middle_name = value;
                    base.OnPropertyChanged(()=>(Item.middle_name));
                }
            }
        }
        public string PeselNumber
        {
            get
            {
                return Item.pesel_number;
            }
            set
            {
                if (value != Item.pesel_number)
                {
                    Item.pesel_number = value;
                    base.OnPropertyChanged(()=>(Item.pesel_number));
                }
            }
        }
        public int EmployeeTypeId
        {
            get
            {
                return Item.employ_type_id;
            }
            set
            {
                if (value != Item.employ_type_id)
                {
                    Item.employ_type_id = value;
                    base.OnPropertyChanged(()=>(Item.employ_type_id));
                }
            }
        }
        public IQueryable<KeyAndValue> EmployTypes
        {
            get
            {
                return new EmployTypeB(DB).GetActiveEmployType();
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
                    base.OnPropertyChanged(()=>(Item.country));
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
                    base.OnPropertyChanged(()=>(Item.city));
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
                    base.OnPropertyChanged(()=>(Item.street));
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
                    base.OnPropertyChanged(()=>(Item.building_number));
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
                    base.OnPropertyChanged(()=>(Item.flat_number));
                }
            }
        }
        public int WarehouseId
        {
            get
            {
                return Item.warehouse_id;
            }
            set
            {
                if (value != Item.warehouse_id)
                {
                    Item.warehouse_id = value;
                    base.OnPropertyChanged(()=>(Item.warehouse_id));
                }
            }
        }

        public IQueryable<KeyAndValue> Werhouses
        {
            get
            {
                return new WearhousesB(DB).GetActiveWearhouses();
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
            DB.employ.AddObject(Item);
            DB.SaveChanges();

        }
    }
}
