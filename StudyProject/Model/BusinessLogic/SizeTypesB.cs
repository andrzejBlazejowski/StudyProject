using StudyProject.Model.EntitiesForViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Model.BusinessLogic
{
    public class SizeTypesB : DBClass
    {
        public SizeTypesB(ZaliczenieEntities zaliczenieEntities) 
            :base(zaliczenieEntities)
        {
            ZaliczenieEntities = zaliczenieEntities;
        }
        
        public ZaliczenieEntities ZaliczenieEntities { get; }

        public IQueryable<KeyAndValue> GetActiveSizeTypes() 
        {
            return (
                    from SizeType in ZaliczenieEntities.size_type
                    where SizeType.is_active == true
                    select new KeyAndValue
                    {
                        Key = SizeType.id,
                        Value = SizeType.name,
                    }
                ).ToList().AsQueryable();
        }
    }
}
