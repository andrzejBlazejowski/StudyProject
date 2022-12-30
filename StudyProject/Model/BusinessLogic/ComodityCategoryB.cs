using StudyProject.Model.EntitiesForViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Model.BusinessLogic
{
    public class ComodityCategoryB : DBClass
    {
        public ComodityCategoryB(ZaliczenieEntities zaliczenieEntities) 
            :base(zaliczenieEntities)
        {
            ZaliczenieEntities = zaliczenieEntities;
        }
        
        public ZaliczenieEntities ZaliczenieEntities { get; }

        public IQueryable<KeyAndValue> GetActiveComodityCategories() 
        {
            return (
                    from ComodityType in ZaliczenieEntities.comodity_category
                    where ComodityType.is_active == true
                    select new KeyAndValue
                    {
                        Key = ComodityType.id,
                        Value = ComodityType.name,
                    }
                ).ToList().AsQueryable();
        }
    }
}
