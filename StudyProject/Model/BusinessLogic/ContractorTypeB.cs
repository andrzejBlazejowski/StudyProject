using StudyProject.Model.EntitiesForViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Model.BusinessLogic
{
    public class ContractorTypeB : DBClass
    {
        public ContractorTypeB(ZaliczenieEntities zaliczenieEntities)
            : base(zaliczenieEntities)
        {
            ZaliczenieEntities = zaliczenieEntities;
        }

        public ZaliczenieEntities ZaliczenieEntities { get; }

        public IQueryable<KeyAndValue> GetActiveContractorTypes()
        {
            return (
                    from ContractorTypes in ZaliczenieEntities.contractor_type
                    where ContractorTypes.is_active == true
                    select new KeyAndValue
                    {
                        Key = ContractorTypes.id,
                        Value = ContractorTypes.name,
                    }
                ).ToList().AsQueryable();
        }
    }
}
