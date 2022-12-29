using StudyProject.Model.EntitiesForViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Model.BusinessLogic
{
    public class ContractorB : DBClass
    {
        public ContractorB(ZaliczenieEntities zaliczenieEntities) 
            :base(zaliczenieEntities)
        {
            ZaliczenieEntities = zaliczenieEntities;
        }

        public ZaliczenieEntities ZaliczenieEntities { get; }

        public IQueryable<KeyAndValue> GetActiveContractors() 
        {
            return (
                    from Contractor in ZaliczenieEntities.contractors
                    where Contractor.is_active == true
                    select new KeyAndValue
                    {
                        Key = Contractor.id,
                        Value = Contractor.name,
                    }
                ).ToList().AsQueryable();
        }
    }
}
