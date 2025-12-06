using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_v1._0.Models
{
    public class InvoiceLine
    {
        public int LineID { get; set; }
        public int InvoiceID { get; set; }

        public string Description { get; set; }
        public string ItemType { get; set; }      // GS1 or EGS
        public string ItemCode { get; set; }
        public string UnitType { get; set; }
        public decimal Quantity { get; set; }     // > 0

        public string CurrencySold { get; set; } = "EGP";
        public decimal AmountEGP { get; set; }

        public decimal SalesTotal { get; set; }
        public decimal ItemsDiscount { get; set; }
        public decimal DiscountAmount { get; set; }

        public decimal NetTotal { get; set; }
        public decimal TotalTaxableFees { get; set; }
        public decimal ValueDifference { get; set; }

        public decimal Total { get; set; }       // final line total after taxes

        // Navigation property
        public List<InvoiceLineTax> Taxes { get; set; } = new List<InvoiceLineTax>();
    }

}
