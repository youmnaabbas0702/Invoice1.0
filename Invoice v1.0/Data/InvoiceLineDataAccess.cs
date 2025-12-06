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
    public class InvoiceLineDataAccess
    {
        public static int AddInvoiceLine(InvoiceLine line, SqlConnection conn, SqlTransaction trans)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_AddInvoiceLine", conn, trans))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@InvoiceID", line.InvoiceID);
                    cmd.Parameters.AddWithValue("@Description", line.Description);
                    cmd.Parameters.AddWithValue("@ItemType", line.ItemType);
                    cmd.Parameters.AddWithValue("@ItemCode", line.ItemCode);
                    cmd.Parameters.AddWithValue("@UnitType", line.UnitType);
                    cmd.Parameters.AddWithValue("@Quantity", line.Quantity);

                    cmd.Parameters.AddWithValue("@CurrencySold", line.CurrencySold);
                    cmd.Parameters.AddWithValue("@AmountEGP", line.AmountEGP);

                    cmd.Parameters.AddWithValue("@SalesTotal", line.SalesTotal);
                    cmd.Parameters.AddWithValue("@ItemsDiscount", line.ItemsDiscount);
                    cmd.Parameters.AddWithValue("@DiscountAmount", line.DiscountAmount);

                    cmd.Parameters.AddWithValue("@NetTotal", line.NetTotal);
                    cmd.Parameters.AddWithValue("@TotalTaxableFees", line.TotalTaxableFees);
                    cmd.Parameters.AddWithValue("@ValueDifference", line.ValueDifference);

                    cmd.Parameters.AddWithValue("@Total", line.Total);

                    SqlParameter outputIdParam = new SqlParameter("@NewLineID", SqlDbType.Int)
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

    }
}
