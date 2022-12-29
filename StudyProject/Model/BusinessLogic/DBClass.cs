using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Model.BusinessLogic
{
    public class DBClass
    {
        public ZaliczenieEntities ZaliczenieEntities { get; set; }

        public DBClass(ZaliczenieEntities zaliczenieEntities)
        {
            this.ZaliczenieEntities = zaliczenieEntities;
        }
    }
}
