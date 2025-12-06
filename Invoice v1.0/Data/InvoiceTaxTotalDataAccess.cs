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
    public class InvoiceTaxTotalDataAccess
    {
        public static int AddInvoiceTaxTotal(InvoiceTaxTotal taxTotal, SqlConnection conn, SqlTransaction trans)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_AddInvoiceTaxTotal", conn, trans))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@InvoiceID", taxTotal.InvoiceID);
                    cmd.Parameters.AddWithValue("@TaxType", taxTotal.TaxType);
                    cmd.Parameters.AddWithValue("@Amount", taxTotal.Amount);

                    SqlParameter outputIdParam = new SqlParameter("@NewTaxTotalID", SqlDbType.Int)
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
