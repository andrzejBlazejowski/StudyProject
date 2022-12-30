using StudyProject.Model.EntitiesForViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Model.BusinessLogic
{
    public class WearhousesB : DBClass
    {
        public WearhousesB(ZaliczenieEntities zaliczenieEntities) 
            :base(zaliczenieEntities)
        {
            ZaliczenieEntities = zaliczenieEntities;
        }
        
        public ZaliczenieEntities ZaliczenieEntities { get; }

        public IQueryable<KeyAndValue> GetActiveWearhouses() 
        {
            return (
                    from Wearhouse in ZaliczenieEntities.warehouses
                    where Wearhouse.is_active == true
                    select new KeyAndValue
                    {
                        Key = Wearhouse.id,
                        Value = Wearhouse.name,
                    }
                ).ToList().AsQueryable();
        }
    }
}
