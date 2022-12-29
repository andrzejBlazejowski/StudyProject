using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Model.BusinessLogic
{
    public class SalesB:DBClass
    {
        public SalesB(ZaliczenieEntities ZaliczenieEntities)
            :base(ZaliczenieEntities)
        {

        }

        public decimal? SalesMonthContractor(int contractorId, int month, int year)
        {
            DateTime firstDayOfMonth = new DateTime(year, month, 1, 0, 0, 0);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            DateTime lastDayOfMonth = new DateTime(year, month, daysInMonth, 23, 59, 59);

            return (
                    from invoice_item in ZaliczenieEntities.invoice_item
                    where
                    invoice_item.invoice.contractor.id == contractorId &&
                    invoice_item.invoice.sale_date >= firstDayOfMonth &&
                    invoice_item.invoice.sale_date <= lastDayOfMonth
                    select
                    (
                        invoice_item.count 
                    )
                ).Sum();
        }
    }
}
