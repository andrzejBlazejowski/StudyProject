
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
                    base.OnPropertyChanged(nameof(Item.destination_warehouse_id));
                }
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
                    base.OnPropertyChanged(nameof(Item.source_warehouse_id));
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
                    base.OnPropertyChanged(nameof(Item.source_contractor_id));
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
                    base.OnPropertyChanged(nameof(Item.delivery_status_id));
                }
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
                    base.OnPropertyChanged(nameof(Item.payment_id));
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
                    base.OnPropertyChanged(nameof(Item.due_date));
                }
            }
        }

        public override void Save()
        {
            Item.is_active = true;
            DB.deliveries.AddObject(Item);
            DB.SaveChanges();

        }
    }
}
