﻿
using StudyProject.Model;
using StudyProject.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;

namespace Firma.ViewModels
{
    public class AddComodityViewModel : AddViewModel<comodity>
    {
        public AddComodityViewModel()
            : base("towar")
        {
            Item = new comodity();
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
                return Item.Name;
            }
            set
            {
                if (value != Item.Name)
                {
                    Item.Name = value;
                    base.OnPropertyChanged(nameof(Item.Name));
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
                    base.OnPropertyChanged(nameof(Item.Description));
                }
            }
        }
        public int OrdinalNumber
        {
            get
            {
                return (int)Item.ordinal_number;
            }
            set
            {
                if (value != Item.ordinal_number)
                {
                    Item.ordinal_number = value;
                    base.OnPropertyChanged(nameof(Item.ordinal_number));
                }
            }
        }
        public decimal NetUnitPrice
        {
            get
            {
                return (int)Item.net_unit_price;
            }
            set
            {
                if (value != Item.net_unit_price)
                {
                    Item.net_unit_price = value;
                    base.OnPropertyChanged(nameof(Item.net_unit_price));
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
                    base.OnPropertyChanged(nameof(Item.vat_rate));
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
                    base.OnPropertyChanged(nameof(Item.gross_unit_price));
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
                    Item.category_id = value;
                    base.OnPropertyChanged(nameof(Item.category_id));
                }
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
                if (value != Item.category_id)
                {
                    Item.size_type_id = value;
                    base.OnPropertyChanged(nameof(Item.size_type_id));
                }
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
                if (value != Item.brand_id)
                {
                    Item.brand_id = value;
                    base.OnPropertyChanged(nameof(Item.brand_id));
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
            DB.comodities.AddObject(Item);
            DB.SaveChanges();

        }
    }
}
