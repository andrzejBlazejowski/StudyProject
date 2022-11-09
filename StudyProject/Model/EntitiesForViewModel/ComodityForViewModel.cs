using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Model.EntitiesForViewModel
{
    public class ComodityForViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal NetUnitPrice { get; set; }
        public decimal VatRate { get; set; }
        public decimal GrossUnitPrice { get; set; }
        public string CategoryName { get; set; }
        public string SizeType { get; set; }
        public string BrandName { get; set; }
        public string BrandAddres { get; set; }
    }
}
