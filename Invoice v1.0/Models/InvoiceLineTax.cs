using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_v1._0.Models
{
    public class InvoiceLineTax
    {
        public int TaxID { get; set; }
        public int LineID { get; set; }

        public string TaxType { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxAmount { get; set; }
        public string SubType { get; set; }
    }

}
