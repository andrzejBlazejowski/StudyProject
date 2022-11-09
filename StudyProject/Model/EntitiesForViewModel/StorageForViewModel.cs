using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Model.EntitiesForViewModel
{
    internal class StorageForViewModel
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int TotalCount { get; set; }
        public int FreeCount { get; set; }
        public int TakenCount { get; set; }
        public string WarehouseName { get; set; }
        public string SizeTypeName { get; set; }
    }
}
