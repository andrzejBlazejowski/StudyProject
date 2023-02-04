
using GalaSoft.MvvmLight.Messaging;
using StudyProject.Commands;
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
    public class AddComodityViewModel : AddViewModel<comodity>
    {
        public AddComodityViewModel()
            : base("towar")
        {
            Item = new comodity();
            Messenger.Default.Register<brand>(this, handleBrand);
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
                    base.OnPropertyChanged(()=>Item.Name);
                }
            }
        }
        public string Description
        {
            get
            {
                return Item.Description;
            }
            set
            {
                if (value != Item.Description)
                {
                    Item.Description = value;
                    base.OnPropertyChanged(()=>(Item.Description));
                }
            }
        }
        public int OrdinalNumber
        {
            get
            {
                if(Item.ordinal_number != null)  return (int)Item.ordinal_number;
                else return 0;
            }
            set
            {
                if (value != Item.ordinal_number)
                {
                    Item.ordinal_number = value;
                    base.OnPropertyChanged(()=>(Item.ordinal_number));
                }
            }
        }
        public decimal NetUnitPrice
        {
            get
            {
                return Item.net_unit_price;
            }
            set
            {
                if (value != Item.net_unit_price)
                {
                    Item.net_unit_price = (decimal)value;
                    base.OnPropertyChanged(()=>(Item.net_unit_price));
                }
            }
        }
        public decimal VatRate
        {
            get
            {
                return (int)Item.vat_rate;
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
        public decimal GrossUnitPrice
        {
            get
            {
                return (int)Item.gross_unit_price;
            }
            set
            {
                if (value != Item.gross_unit_price)
                {
                    Item.gross_unit_price = value;
                    base.OnPropertyChanged(() => (Item.gross_unit_price));
                }
            }
        }
        public int CategoryId
        {
            get
            {
                return Item.category_id;
            }
            set
            {
                if (value != Item.category_id)
                {
                    Item.category_id = (int)value;
                    base.OnPropertyChanged(() => (Item.category_id));
                }
            }
        }
        public IQueryable<KeyAndValue> Categories
        {
            get
            {
                return new ComodityCategoryB(DB).GetActiveComodityCategories();
            }
        }
        public int SizeTypeId
        {
            get
            {
                return Item.size_type_id;
            }
            set
            {
                if ((int)value != Item.category_id)
                {
                    Item.size_type_id = (int)value;
                    base.OnPropertyChanged(() => (Item.size_type_id));
                }
            }
        }
        public IQueryable<KeyAndValue> Sizes
        {
            get
            {
                return new SizeTypesB(DB).GetActiveSizeTypes();
            }
        }
        public int BrandId
        {
            get
            {
                return Item.brand_id;
            }
            set
            {
                if ((int)value != Item.brand_id)
                {
                    Item.brand_id = (int)value;
                    base.OnPropertyChanged(() => (Item.brand_id));
                }
            }
        }
        public string BrandName { get; set; }
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
        private BaseCommand _LookupBrands;
        public BaseCommand LookupBrands
        {
            get
            {
                if (_LookupBrands == null)
                {
                    _LookupBrands = new BaseCommand(() => lookupBrands());
                }
                return _LookupBrands;
            }
        }

        private void handleBrand(brand brand)
        {
            BrandId = brand.id;
            BrandName = brand.name;
        }
        private void lookupBrands() {
            Messenger.Default.Send("lookupBrands");
        }

        public override void Save()
        {
            Item.is_active = true;
            Item.create_date = DateTime.Now;
            DB.comodities.AddObject(Item);
            DB.SaveChanges();
        }
    }
}
