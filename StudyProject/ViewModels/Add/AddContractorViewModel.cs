
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
    public class AddContractorViewModel : AddViewModel<contractor>
    {
        public AddContractorViewModel(NavStore navStore, NavigationToolBarViewModel navToolBarvm)
            : base(navStore, navToolBarvm, "kontrachent")
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
                    base.OnPropertyChanged(nameof(Item.tax_number));
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
                    base.OnPropertyChanged(nameof(Item.tax_name));
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
                    base.OnPropertyChanged(nameof(Item.zip_code));
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
                    base.OnPropertyChanged(nameof(Item.post_office_city));
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
                    base.OnPropertyChanged(nameof(Item.additional_info));
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
                    base.OnPropertyChanged(nameof(Item.is_vat_taxpayer));
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
                    base.OnPropertyChanged(nameof(Item.should_include_vat_27));
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
                    base.OnPropertyChanged(nameof(Item.contractor_type_id));
                }
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
                    base.OnPropertyChanged(nameof(Item.currency_id));
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
            DB.contractors.AddObject(Item);
            DB.SaveChanges();

        }
    }
}
