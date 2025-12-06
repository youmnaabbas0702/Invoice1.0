using Invoice_v1._0.Data;
using Invoice_v1._0.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_v1._0.Services
{
    public static class InvoiceServices
    {
        public static bool AddNewInvoice(Invoice invoice)
        {
            if (invoice == null || invoice.InvoiceLines == null || invoice.InvoiceLines.Count == 0)
                return false;

            return InvoiceTransactionsDataAccess.AddInvoiceTransactionally(invoice);
        }

        public static string GenerateInternalID()
        {
            return InvoiceDataAccess.GenerateInternalId();
        }

        public static bool IsInternalIdExist(string InternalId)
        {
            return InvoiceDataAccess.IsINternalIdExist(InternalId);
        }

        public static DataSet GetInvoiceData(int InvoiceID)
        {
            return InvoiceDataAccess.GetInvoiceData(InvoiceID);
        }

        public static int GetInvoiceID(string internalID)
        {
            return InvoiceDataAccess.GetInvoiceID_ByInternalID(internalID);
        }
    }
}
