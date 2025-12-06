using Invoice_v1._0.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_v1._0.Data
{
    public class InvoiceDataAccess
    {
        public static int AddNewInvoice(Invoice newInvoice, SqlConnection conn, SqlTransaction trans)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_AddInvoice", conn, trans))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IssuerID", newInvoice.IssuerID);
                    cmd.Parameters.AddWithValue("@ReceiverID", newInvoice.ReceiverID);

                    cmd.Parameters.AddWithValue("@DateTimeIssued", newInvoice.DateTimeIssued);
                    cmd.Parameters.AddWithValue("@TaxpayerActivityCode", newInvoice.TaxpayerActivityCode);
                    cmd.Parameters.AddWithValue("@InternalId", newInvoice.InternalId);

                    cmd.Parameters.AddWithValue("@TotalSalesAmount", newInvoice.TotalSalesAmount);
                    cmd.Parameters.AddWithValue("@TotalDiscountAmount", newInvoice.TotalDiscountAmount);
                    cmd.Parameters.AddWithValue("@NetAmount", newInvoice.NetAmount);
                    cmd.Parameters.AddWithValue("@ExtraDiscountAmount", newInvoice.ExtraDiscountAmount);
                    cmd.Parameters.AddWithValue("@TotalItemsDiscountAmount", newInvoice.TotalItemsDiscountAmount);
                    cmd.Parameters.AddWithValue("@TotalAmount", newInvoice.TotalAmount);

                    // Output parameter
                    SqlParameter outputIdParam = new SqlParameter("@NewInvoiceID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputIdParam);

                    cmd.ExecuteNonQuery();

                    return (int)outputIdParam.Value;
                }
            }
            catch
            {
                return -1;
            }
        }

        public static string GenerateInternalId()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccessSettings.connectionString))
                using (SqlCommand cmd = new SqlCommand("SP_GenerateInternalId", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter outputParam = new SqlParameter("@NewInternalId", SqlDbType.VarChar, 100)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputParam);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    return outputParam.Value.ToString();
                }
            }
            catch
            {
                return null; // return null on error
            }
        }

        public static bool IsINternalIdExist(string InternalId)
        {
            bool isExist = false;

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_CheckInternalIdExists", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@InternalId", InternalId);

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null && Convert.ToInt32(result) == 1)
                        isExist = true;
                }
            }

            return isExist;
        }

        public static bool UpdateInvoiceHeader(Invoice invoice, SqlConnection conn, SqlTransaction trans)
        {
            using (SqlCommand cmd = new SqlCommand("SP_UpdateInvoiceHeader", conn, trans))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@InvoiceID", invoice.InvoiceID);
                cmd.Parameters.AddWithValue("@IssuerID", invoice.IssuerID);
                cmd.Parameters.AddWithValue("@ReceiverID", invoice.ReceiverID);
                cmd.Parameters.AddWithValue("@DateTimeIssued", invoice.DateTimeIssued);
                cmd.Parameters.AddWithValue("@TaxpayerActivityCode", invoice.TaxpayerActivityCode);
                cmd.Parameters.AddWithValue("@InternalId", invoice.InternalId);

                cmd.Parameters.AddWithValue("@TotalSalesAmount", invoice.TotalSalesAmount);
                cmd.Parameters.AddWithValue("@TotalDiscountAmount", invoice.TotalDiscountAmount);
                cmd.Parameters.AddWithValue("@NetAmount", invoice.NetAmount);
                cmd.Parameters.AddWithValue("@ExtraDiscountAmount", invoice.ExtraDiscountAmount);
                cmd.Parameters.AddWithValue("@TotalItemsDiscountAmount", invoice.TotalItemsDiscountAmount);
                cmd.Parameters.AddWithValue("@TotalAmount", invoice.TotalAmount);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool DeleteInvoiceLinesAndTaxes(int invoiceID, SqlConnection conn, SqlTransaction trans)
        {
            using (SqlCommand cmd = new SqlCommand("SP_DeleteInvoiceLinesAndTaxes", conn, trans))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InvoiceID", invoiceID);
                return cmd.ExecuteNonQuery() >= 0;
            }
        }

        public static DataSet GetInvoiceData(int invoiceID)
        {
            DataSet ds = new DataSet();

            using (SqlConnection con = new SqlConnection(DataAccessSettings.connectionString))
            {
                con.Open();

                // 1️⃣ Fill InvoiceHeader
                SqlDataAdapter daHeader = new SqlDataAdapter("GetInvoiceHeaderById", con);
                daHeader.SelectCommand.CommandType = CommandType.StoredProcedure;
                daHeader.SelectCommand.Parameters.AddWithValue("@InvoiceID", invoiceID);
                daHeader.Fill(ds, "InvoiceHeader");

                // 2️⃣ Fill InvoiceLines
                SqlDataAdapter daLines = new SqlDataAdapter("GetInvoiceLinesByInvoiceId", con);
                daLines.SelectCommand.CommandType = CommandType.StoredProcedure;
                daLines.SelectCommand.Parameters.AddWithValue("@InvoiceID", invoiceID);
                daLines.Fill(ds, "InvoiceLines");

                // 3️⃣ Fill InvoiceLineTaxes
                SqlDataAdapter daTaxes = new SqlDataAdapter("GetInvoiceLineTaxesByInvoiceLineId", con);
                daTaxes.SelectCommand.CommandType = CommandType.StoredProcedure;

                foreach (DataRow line in ds.Tables["InvoiceLines"].Rows)
                {
                    daTaxes.SelectCommand.Parameters.Clear();
                    daTaxes.SelectCommand.Parameters.AddWithValue("@LineID", line["LineID"]);
                    daTaxes.Fill(ds, "InvoiceLineTaxes");
                }

                // 4️⃣ Fill InvoiceTaxTotals
                SqlDataAdapter daTaxTotals = new SqlDataAdapter("GetInvoiceTaxTotalsByInvoiceId", con);
                daTaxTotals.SelectCommand.CommandType = CommandType.StoredProcedure;
                daTaxTotals.SelectCommand.Parameters.AddWithValue("@InvoiceID", invoiceID);
                daTaxTotals.Fill(ds, "InvoiceTaxTotals");
            }

            return ds;
        }

        public static int GetInvoiceID_ByInternalID(string internalID)
        {
            int invoiceID = -1; // default if not found

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand("GetInvoiceID_ByInternalID", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@InternalID", internalID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                        invoiceID = Convert.ToInt32(result);
                }
                catch (Exception ex)
                {
                    
                }
            }

            return invoiceID;
        }

    }
}
