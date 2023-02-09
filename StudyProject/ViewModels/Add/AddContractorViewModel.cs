
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
    public class AddContractorViewModel : AddViewModel<contractor>, IDataErrorInfo
    {
        public AddContractorViewModel()
            : base("kontrachent")
        {
            Item = new contractor();
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
        public string TaxNumber
        {
            get
            {
                return Item.tax_number;
            }
            set
            {
                if (value != Item.tax_number)
                {
                    Item.tax_number = value;
                    base.OnPropertyChanged(() => (Item.tax_number));
                }
            }
        }
        public string TaxName
        {
            get
            {
                return Item.tax_name;
            }
            set
            {
                if (value != Item.tax_name)
                {
                    Item.tax_name = value;
                    base.OnPropertyChanged(()=>(Item.tax_name));
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
                    base.OnPropertyChanged(()=>(Item.state));
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
        public string ZipCode
        {
            get
            {
                return Item.zip_code;
            }
            set
            {
                if (value != Item.zip_code)
                {
                    Item.zip_code = value;
                    base.OnPropertyChanged(()=>(Item.zip_code));
                }
            }
        }
        public string PostOfficeCity
        {
            get
            {
                return Item.post_office_city;
            }
            set
            {
                if (value != Item.post_office_city)
                {
                    Item.post_office_city = value;
                    base.OnPropertyChanged(()=>(Item.post_office_city));
                }
            }
        }
        public string AdditionalInfo
        {
            get
            {
                return Item.additional_info;
            }
            set
            {
                if (value != Item.additional_info)
                {
                    Item.additional_info = value;
                    base.OnPropertyChanged(()=>(Item.additional_info));
                }
            }
        }
        public bool IsVatTaxpayer
        {
            get
            {
                return Item.is_vat_taxpayer;
            }
            set
            {
                if (value != Item.is_vat_taxpayer)
                {
                    Item.is_vat_taxpayer = value;
                    base.OnPropertyChanged(()=>(Item.is_vat_taxpayer));
                }
            }
        }
        public bool ShouldIncludeVat27
        {
            get
            {
                return Item.should_include_vat_27;
            }
            set
            {
                if (value != Item.should_include_vat_27)
                {
                    Item.should_include_vat_27 = value;
                    base.OnPropertyChanged(()=>(Item.should_include_vat_27));
                }
            }
        }
        public int ContractorTypeId
        {
            get
            {
                return Item.contractor_type_id;
            }
            set
            {
                if (value != Item.contractor_type_id)
                {
                    Item.contractor_type_id = value;
                    base.OnPropertyChanged(()=>(Item.contractor_type_id));
                }
            }
        }
        public IQueryable<KeyAndValue> ContractorTypes
        {
            get
            {
                return new ContractorTypeB(DB).GetActiveContractorTypes();
            }
        }
        public int CurrencyId
        {
            get
            {
                return Item.currency_id;
            }
            set
            {
                if (value != Item.currency_id)
                {
                    Item.currency_id = value;
                    base.OnPropertyChanged(()=>(Item.currency_id));
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
                if (name == "TaxNumber")
                {
                    msg = BusinesValidator.IsValidNIP(this.TaxNumber);
                }
                if (name == "TaxName")
                {
                    msg = StringValidator.NotEmpty(this.TaxName);
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
                if (name == "ZipCode")
                {
                    msg = StringValidator.NotEmpty(this.ZipCode);
                }
                if (name == "PostOfficeCity")
                {
                    msg = StringValidator.NotEmpty(this.PostOfficeCity);
                }

                return msg;
            }
        }
        public override bool isValid()
        {
            if (this["Name"] == null)
                return true;
            if (this["TaxName"] == null)
                return true;
            if (this["TaxNumber"] == null)
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
            if (this["ZipCode"] == null)
                return true;
            if (this["PostOfficeCity"] == null)
                return true;
            return false;
        }

        public override void Save()
        {
            Item.is_active = true;
            Item.create_date = DateTime.Now;
            DB.contractors.AddObject(Item);
            DB.SaveChanges();

        }
    }
}
