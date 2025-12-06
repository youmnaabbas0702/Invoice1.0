using Invoice_v1._0.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_v1._0.Data
{
    // InvoiceTransactionsDataAccess.cs
    public static class InvoiceTransactionsDataAccess
    {
        public static bool AddInvoiceTransactionally(Invoice invoice)
        {
            using (SqlConnection conn = new SqlConnection(DataAccessSettings.connectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    // 0) Add Issuer if needed
                    if (invoice.Issuer != null && invoice.Issuer.PartyID == 0)
                    {
                        int issuerId = PartyDataAccess.AddNewParty(invoice.Issuer, conn, trans);
                        if (issuerId == -1) { trans.Rollback(); return false; }
                        invoice.IssuerID = issuerId;
                        invoice.Issuer.PartyID = issuerId;
                    }

                    // 0) Add Receiver if needed
                    if (invoice.Receiver != null && invoice.Receiver.PartyID == 0)
                    {
                        int receiverId = PartyDataAccess.AddNewParty(invoice.Receiver, conn, trans);
                        if (receiverId == -1) { trans.Rollback(); return false; }
                        invoice.ReceiverID = receiverId;
                        invoice.Receiver.PartyID = receiverId;
                    }

                    // 1) Add invoice header
                    int invoiceId = InvoiceDataAccess.AddNewInvoice(invoice, conn, trans);
                    if (invoiceId == -1) { trans.Rollback(); return false; }
                    invoice.InvoiceID = invoiceId;

                    // 2) Add invoice lines + taxes
                    foreach (var line in invoice.InvoiceLines)
                    {
                        line.InvoiceID = invoiceId;
                        int lineId = InvoiceLineDataAccess.AddInvoiceLine(line, conn, trans);
                        if (lineId == -1) { trans.Rollback(); return false; }
                        line.LineID = lineId;

                        foreach (var tax in line.Taxes ?? new List<InvoiceLineTax>())
                        {
                            tax.LineID = lineId;
                            int taxId = InvoiceLineTaxDataAccess.AddInvoiceLineTax(tax, conn, trans);
                            if (taxId == -1) { trans.Rollback(); return false; }
                            tax.TaxID = taxId;
                        }
                    }

                    // 3) Add invoice-level tax totals
                    foreach (var ttotal in invoice.TaxTotals ?? new List<InvoiceTaxTotal>())
                    {
                        ttotal.InvoiceID = invoiceId;
                        int taxTotalId = InvoiceTaxTotalDataAccess.AddInvoiceTaxTotal(ttotal, conn, trans);
                        if (taxTotalId == -1) { trans.Rollback(); return false; }
                        ttotal.TaxTotalID = taxTotalId;
                    }

                    trans.Commit();
                    return true;
                }
                catch
                {
                    trans.Rollback();
                    return false;
                }
            }
        }

        public static bool UpdateInvoiceTransactionally(Invoice invoice)
        {
            using (SqlConnection conn = new SqlConnection(DataAccessSettings.connectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    // 1) Update Issuer
                    if (invoice.Issuer != null && invoice.Issuer.PartyID != 0)
                    {
                        PartyDataAccess.UpdateParty(invoice.Issuer, conn, trans);
                    }

                    // 2) Update Receiver
                    if (invoice.Receiver != null && invoice.Receiver.PartyID != 0)
                    {
                        PartyDataAccess.UpdateParty(invoice.Receiver, conn, trans);
                    }

                    // 3) Update Invoice Header
                    InvoiceDataAccess.UpdateInvoiceHeader(invoice, conn, trans);

                    // 4) Delete old lines + taxes + totals
                    InvoiceDataAccess.DeleteInvoiceLinesAndTaxes(invoice.InvoiceID, conn, trans);

                    // 5) Re-insert lines + taxes
                    foreach (var line in invoice.InvoiceLines)
                    {
                        line.InvoiceID = invoice.InvoiceID;

                        int newLineId = InvoiceLineDataAccess.AddInvoiceLine(line, conn, trans);
                        if (newLineId == -1) { trans.Rollback(); return false; }
                        line.LineID = newLineId;

                        foreach (var tax in line.Taxes ?? new List<InvoiceLineTax>())
                        {
                            tax.LineID = newLineId;
                            int taxId = InvoiceLineTaxDataAccess.AddInvoiceLineTax(tax, conn, trans);
                            if (taxId == -1) { trans.Rollback(); return false; }
                            tax.TaxID = taxId;
                        }
                    }

                    // 6) Re-insert tax totals
                    foreach (var ttotal in invoice.TaxTotals ?? new List<InvoiceTaxTotal>())
                    {
                        ttotal.InvoiceID = invoice.InvoiceID;
                        int taxTotalId = InvoiceTaxTotalDataAccess.AddInvoiceTaxTotal(ttotal, conn, trans);
                        if (taxTotalId == -1) { trans.Rollback(); return false; }
                        ttotal.TaxTotalID = taxTotalId;
                    }

                    trans.Commit();
                    return true;
                }
                catch
                {
                    trans.Rollback();
                    return false;
                }
            }
        }

    }

}
