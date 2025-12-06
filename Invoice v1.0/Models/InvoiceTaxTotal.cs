using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_v1._0.Models
{
    public class InvoiceTaxTotal
    {
        public int TaxTotalID { get; set; }
        public int InvoiceID { get; set; }

        public string TaxType { get; set; }
        public decimal Amount { get; set; }
    }

}
