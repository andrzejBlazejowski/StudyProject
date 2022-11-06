
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
    public class AddDeliveryItemViewModel : AddViewModel<delivery_item>
    {
        public AddDeliveryItemViewModel(NavStore navStore, NavigationToolBarViewModel navToolBarvm)
            : base(navStore, navToolBarvm, "pozycja dostawy")
        {
            Item = new delivery_item();
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
        public int comodity_id
        {
            get
            {
                return Item.comodity_id;
            }
            set
            {
                if (value != Item.comodity_id)
                {
                    Item.comodity_id = value;
                    base.OnPropertyChanged(nameof(Item.comodity_id));
                }
            }
        }
        public int count
        {
            get
            {
                return Item.count;
            }
            set
            {
                if (value != Item.count)
                {
                    Item.count = value;
                    base.OnPropertyChanged(nameof(Item.count));
                }
            }
        }
        public decimal unit_cost
        {
            get
            {
                return Item.unit_cost;
            }
            set
            {
                if (value != Item.unit_cost)
                {
                    Item.unit_cost = value;
                    base.OnPropertyChanged(nameof(Item.unit_cost));
                }
            }
        }
        public int delivery_id
        {
            get
            {
                return Item.delivery_id;
            }
            set
            {
                if (value != Item.delivery_id)
                {
                    Item.delivery_id = value;
                    base.OnPropertyChanged(nameof(Item.delivery_id));
                }
            }
        }
        public int curency_id
        {
            get
            {
                return Item.curency_id;
            }
            set
            {
                if (value != Item.curency_id)
                {
                    Item.curency_id = value;
                    base.OnPropertyChanged(nameof(Item.curency_id));
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
            Item.create_date = DateTime.Now;
            DB.delivery_item.AddObject(Item);
            DB.SaveChanges();

        }
    }
}
