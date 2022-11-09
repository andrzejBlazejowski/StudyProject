using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Model.EntitiesForViewModel
{
    internal class DeliveryItemForViewModel
    {
        public int Id { get; set; }
        public string ComodityName { get; set; }
        public string ComodityUnitPrice { get; set; }
        public string ComodityCategoryName { get; set; }
        public string ComoditySizeName { get; set; }
        public int Count { get; set; }
        public string CurencyName { get; set; }
        public string CurrenvySign { get; set; }
    }
}
