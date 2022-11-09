using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Model.EntitiesForViewModel
{
    public class DeliveryForViewModel
    {
        public int Id { get; set; }
        public String number { get; set; }
        public string destinationWarehouseName { get; set; }
        public string sourceWarehouseName { get; set; }
        public string sourceContractorName { get; set; }
        public string sourceContractorType { get; set; }
        public string sourceContractorAddress { get; set; }
        public string paymentMethod { get; set; }
        public string DeliveryStatus { get; set; }
        public DateTime createDate { get; set; }
        public DateTime dueDate { get; set; }
    }
}
