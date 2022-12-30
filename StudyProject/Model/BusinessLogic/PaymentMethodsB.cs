using StudyProject.Model.EntitiesForViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Model.BusinessLogic
{
    public class PaymentMethodsB : DBClass
    {
        public PaymentMethodsB(ZaliczenieEntities zaliczenieEntities) 
            :base(zaliczenieEntities)
        {
            ZaliczenieEntities = zaliczenieEntities;
        }
        
        public ZaliczenieEntities ZaliczenieEntities { get; }

        public IQueryable<KeyAndValue> GetActivePaymentMethods() 
        {
            return (
                    from PaymentMethod in ZaliczenieEntities.payment_method
                    where PaymentMethod.is_active == true
                    select new KeyAndValue
                    {
                        Key = PaymentMethod.id,
                        Value = PaymentMethod.name,
                    }
                ).ToList().AsQueryable();
        }
    }
}
