using StudyProject.Model.EntitiesForViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Model.BusinessLogic
{
    public class CurencyB:DBClass
    {
            public CurencyB(ZaliczenieEntities zaliczenieEntities)
                : base(zaliczenieEntities)
            {
                ZaliczenieEntities = zaliczenieEntities;
            }

            public ZaliczenieEntities ZaliczenieEntities { get; }

            public IQueryable<KeyAndValue> GetActivecurency()
            {
                return (
                        from Curency in ZaliczenieEntities.curency
                        where Curency.is_active == true
                        select new KeyAndValue
                        {
                            Key = Curency.id,
                            Value = Curency.name,
                        }
                    ).ToList().AsQueryable();
            }
        }
    }
