using StudyProject.Model.EntitiesForViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Model.BusinessLogic
{
    public class EmployTypeB : DBClass
    {
        public EmployTypeB(ZaliczenieEntities zaliczenieEntities) 
            :base(zaliczenieEntities)
        {
            ZaliczenieEntities = zaliczenieEntities;
        }
        
        public ZaliczenieEntities ZaliczenieEntities { get; }

        public IQueryable<KeyAndValue> GetActiveEmployType() 
        {
            return (
                    from EmployType in ZaliczenieEntities.employ_type
                    where EmployType.is_active == true
                    select new KeyAndValue
                    {
                        Key = EmployType.id,
                        Value = EmployType.name,
                    }
                ).ToList().AsQueryable();
        }
    }
}
