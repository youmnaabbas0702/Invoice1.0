using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_v1._0.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }

        public int IssuerID { get; set; }
        public int ReceiverID { get; set; }

        public string DocumentType { get; set; } = "i";
        public string DocumentTypeVersion { get; set; } = "1.0";

        public DateTime DateTimeIssued { get; set; }
        public string TaxpayerActivityCode { get; set; }
        public string InternalId { get; set; }


        // Totals
        public decimal TotalSalesAmount { get; set; }
        public decimal TotalDiscountAmount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal ExtraDiscountAmount { get; set; }
        public decimal TotalItemsDiscountAmount { get; set; }
        public decimal TotalAmount { get; set; }

        // Navigation properties
        public Party Issuer { get; set; }
        public Party Receiver { get; set; }
        public List<InvoiceLine> InvoiceLines { get; set; } = new List<InvoiceLine>();
        public List<InvoiceTaxTotal> TaxTotals { get; set; } = new List<InvoiceTaxTotal>();
    }

}
