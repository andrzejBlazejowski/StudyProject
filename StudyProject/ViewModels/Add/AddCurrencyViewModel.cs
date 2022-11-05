﻿
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
    public class AddCurrencyViewModel : AddViewModel<curency>
    {
        public AddCurrencyViewModel(NavStore navStore, NavigationToolBarViewModel navToolBarvm)
            : base(navStore, navToolBarvm, "waluta")
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
                    base.OnPropertyChanged(nameof(Item.convert_rate));
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
                    base.OnPropertyChanged(nameof(Item.is_default));
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
                    base.OnPropertyChanged(nameof(Item.sign));
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
            DB.curencies.AddObject(Item);
            DB.SaveChanges();

        }
    }
}