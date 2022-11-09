using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Model.EntitiesForViewModel
{
    public class ContractorForViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TaxNumber { get; set; }
        public string TaxName { get; set; }
        public string Address { get; set; }
        public string AdditionalInfo { get; set; }
        public Boolean IsVatTaxpayer { get; set; }
        public Boolean ShouldIncludeVat27 { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySign { get; set; }
        public string ContractorType { get; set; }
    }
}
