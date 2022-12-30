using StudyProject.Model.EntitiesForViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Model.BusinessLogic
{
    public class DeliveryStatusB : DBClass
    {
        public DeliveryStatusB(ZaliczenieEntities zaliczenieEntities) 
            :base(zaliczenieEntities)
        {
            ZaliczenieEntities = zaliczenieEntities;
        }
        
        public ZaliczenieEntities ZaliczenieEntities { get; }

        public IQueryable<KeyAndValue> GetActiveDeliveryStatuses() 
        {
            return (
                    from DeliverStatus in ZaliczenieEntities.delivery_status
                    where DeliverStatus.is_active == true
                    select new KeyAndValue
                    {
                        Key = DeliverStatus.id,
                        Value = DeliverStatus.Name,
                    }
                ).ToList().AsQueryable();
        }
    }
}
