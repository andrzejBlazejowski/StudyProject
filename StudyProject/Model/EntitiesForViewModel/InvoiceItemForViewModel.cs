using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Model.EntitiesForViewModel
{
    public class InvoiceItemForViewModel
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public string Discount { get; set; }
        public string ComodityName { get; set; }
        public decimal ComodityGrossPrice { get; set; }
        public decimal ComodityNetPrice { get; set; }
        public string CategoryName { get; set; }
        public string SizeTypeName { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
