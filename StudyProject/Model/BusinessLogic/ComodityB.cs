using StudyProject.Model.EntitiesForViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Model.BusinessLogic
{
    public class ComodityB : DBClass
    {
        public ComodityB(ZaliczenieEntities zaliczenieEntities) 
            :base(zaliczenieEntities)
        {
            ZaliczenieEntities = zaliczenieEntities;
        }
        
        public ZaliczenieEntities ZaliczenieEntities { get; }

        public IQueryable<KeyAndValue> GetActiveComodities() 
        {
            return (
                    from Comodity in ZaliczenieEntities.comodities
                    where Comodity.is_active == true
                    select new KeyAndValue
                    {
                        Key = Comodity.id,
                        Value = Comodity.Description,
                    }
                ).ToList().AsQueryable();
        }
    }
}
