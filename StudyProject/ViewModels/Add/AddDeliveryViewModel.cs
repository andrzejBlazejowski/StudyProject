
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
    public class AddDeliveryViewModel : AddViewModel<delivery>
    {
        public AddDeliveryViewModel()
            : base("dostawy")
        {
            Item = new delivery();
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
        public int DestinationWarhouseId
        {
            get
            {
                return Item.destination_warehouse_id;
            }
            set
            {
                if (value != Item.destination_warehouse_id)
                {
                    Item.destination_warehouse_id = value;
                    base.OnPropertyChanged(()=>(Item.destination_warehouse_id));
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
        public int SourceWarhouseId
        {
            get
            {
                return Item.source_warehouse_id;
            }
            set
            {
                if (value != Item.source_warehouse_id)
                {
                    Item.source_warehouse_id = value;
                    base.OnPropertyChanged(()=>(Item.source_warehouse_id));
                }
            }
        }
        public int SourcenContractorId
        {
            get
            {
                return Item.source_contractor_id;
            }
            set
            {
                if (value != Item.source_contractor_id)
                {
                    Item.source_contractor_id = value;
                    base.OnPropertyChanged(()=>(Item.source_contractor_id));
                }
            }
        }
        public int DeliveryStatusId
        {
            get
            {
                return Item.delivery_status_id;
            }
            set
            {
                if (value != Item.delivery_status_id)
                {
                    Item.delivery_status_id = value;
                    base.OnPropertyChanged(()=>(Item.delivery_status_id));
                }
            }
        }

        public IQueryable<KeyAndValue> DeliveryStatuses
        {
            get
            {
                return new DeliveryStatusB(DB).GetActiveDeliveryStatuses();
            }
        }
        public int PaymentId
        {
            get
            {
                return Item.payment_id;
            }
            set
            {
                if (value != Item.payment_id)
                {
                    Item.payment_id = value;
                    base.OnPropertyChanged(()=>(Item.payment_id));
                }
            }
        }

        public IQueryable<KeyAndValue> PeymentMethods
        {
            get
            {
                return new PaymentMethodsB(DB).GetActivePaymentMethods();
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
        public DateTime DueDate
        {
            get
            {
                return Item.due_date;
            }
            set
            {
                if (value != Item.due_date)
                {
                    Item.due_date = value;
                    base.OnPropertyChanged(()=>(Item.due_date));
                }
            }
        }

        public override void Save()
        {
            Item.is_active = true;
            Item.create_date = DateTime.Now;
            DB.deliveries.AddObject(Item);
            DB.SaveChanges();

        }
    }
}
