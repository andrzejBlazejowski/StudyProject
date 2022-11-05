
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
    public class AddStorageViewModel : AddViewModel<storage>
    {
        public AddStorageViewModel()
            : base("producent")
        {
            Item = new storage();
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
        public string Number
        {
            get
            {
                return Item.number;
            }
            set
            {
                if (value != Item.number)
                {
                    Item.number = value;
                    base.OnPropertyChanged(nameof(Item.number));
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
                    base.OnPropertyChanged(nameof(Item.warehouse_id));
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
                if (value != Item.size_type_id)
                {
                    Item.size_type_id = value;
                    base.OnPropertyChanged(nameof(Item.size_type_id));
                }
            }
        }
        public int TotalCount
        {
            get
            {
                return Item.total_count;
            }
            set
            {
                if (value != Item.total_count)
                {
                    Item.total_count = value;
                    base.OnPropertyChanged(nameof(Item.total_count));
                }
            }
        }
        public int TakenCount
        {
            get
            {
                return Item.taken_count;
            }
            set
            {
                if (value != Item.taken_count)
                {
                    Item.taken_count = value;
                    base.OnPropertyChanged(nameof(Item.taken_count));
                }
            }
        }
        public int FreeCount
        {
            get
            {
                return Item.free_count;
            }
            set
            {
                if (value != Item.free_count)
                {
                    Item.free_count = value;
                    base.OnPropertyChanged(nameof(Item.free_count));
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
                return Item.create_time;
            }
            set
            {
                if (value != Item.create_time)
                {
                    Item.create_time = value;
                    base.OnPropertyChanged(nameof(Item.create_time));
                }
            }
        }

        public override void Save()
        {
            Item.is_active = true;
            DB.storages.AddObject(Item);
            DB.SaveChanges();

        }
    }
}
