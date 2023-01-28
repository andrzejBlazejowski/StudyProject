
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
                    base.OnPropertyChanged(()=>(Item.id));
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
                    base.OnPropertyChanged(()=>(Item.number));
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
                    base.OnPropertyChanged(()=>(Item.size_type_id));
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
                    base.OnPropertyChanged(()=>(Item.total_count));
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
                    base.OnPropertyChanged(()=>(Item.taken_count));
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
                    base.OnPropertyChanged(()=>(Item.free_count));
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
                    base.OnPropertyChanged(()=>(Item.is_active));
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
                    base.OnPropertyChanged(()=>(Item.create_time));
                }
            }
        }

        public override void Save()
        {
            Item.is_active = true;
            Item.create_time = DateTime.Now;
            DB.storages.AddObject(Item);
            DB.SaveChanges();

        }
    }
}
