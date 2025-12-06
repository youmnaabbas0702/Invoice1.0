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
    public class InvoiceLineTaxDataAccess
    {
        public static int AddInvoiceLineTax(InvoiceLineTax tax, SqlConnection conn, SqlTransaction trans)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_AddInvoiceLineTax", conn, trans))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@LineID", tax.LineID);
                    cmd.Parameters.AddWithValue("@TaxType", tax.TaxType);
                    cmd.Parameters.AddWithValue("@TaxRate", tax.TaxRate);
                    cmd.Parameters.AddWithValue("@TaxAmount", tax.TaxAmount);

                    if (string.IsNullOrEmpty(tax.SubType))
                        cmd.Parameters.AddWithValue("@SubType", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@SubType", tax.SubType);

                    SqlParameter outputIdParam = new SqlParameter("@NewTaxID", SqlDbType.Int)
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
