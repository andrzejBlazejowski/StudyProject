using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Model.EntitiesForViewModel
{
    public class InvoiceForViewModel
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public string ContractorName { get; set; }
        public string ContractorAddress { get; set; }
        public string ContractorType { get; set; }
        public Boolean IsContractorVatPayer { get; set; }
        public string ContractorCurrency { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal? Discount { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal NetValue { get; set; }
        public decimal GrossValue { get; set; }
        public decimal PaidValue { get; set; }
        public decimal PendingPayment { get; set; }
    }
}
