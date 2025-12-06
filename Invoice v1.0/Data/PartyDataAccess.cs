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
    public static class PartyDataAccess
    {
        public static int AddNewParty(Party newParty, SqlConnection conn, SqlTransaction trans)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_AddParty", conn, trans))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Role", newParty.Role);
                    cmd.Parameters.AddWithValue("@Type", newParty.Type);
                    cmd.Parameters.AddWithValue("@RegID", newParty.RegID);
                    cmd.Parameters.AddWithValue("@Name", newParty.Name);
                    cmd.Parameters.AddWithValue("@Country", newParty.Country);
                    cmd.Parameters.AddWithValue("@Governate", newParty.Governate);
                    cmd.Parameters.AddWithValue("@RegionCity", newParty.RegionCity);
                    cmd.Parameters.AddWithValue("@Street", newParty.Street);
                    cmd.Parameters.AddWithValue("@BuildingNumber", newParty.BuildingNumber);
                    cmd.Parameters.AddWithValue("@BranchId", (object)newParty.BranchId ?? DBNull.Value);

                    SqlParameter outputIdParam = new SqlParameter("@NewPartyID", SqlDbType.Int)
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

        public static bool UpdateParty(Party party, SqlConnection conn, SqlTransaction trans)
        {
            using (SqlCommand cmd = new SqlCommand("SP_UpdateParty", conn, trans))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PartyID", party.PartyID);
                cmd.Parameters.AddWithValue("@Role", party.Role);
                cmd.Parameters.AddWithValue("@Type", party.Type);
                cmd.Parameters.AddWithValue("@RegID", party.RegID);
                cmd.Parameters.AddWithValue("@Name", party.Name);

                cmd.Parameters.AddWithValue("@Country", party.Country);
                cmd.Parameters.AddWithValue("@Governate", party.Governate);
                cmd.Parameters.AddWithValue("@RegionCity", party.RegionCity);
                cmd.Parameters.AddWithValue("@Street", party.Street);
                cmd.Parameters.AddWithValue("@BuildingNumber", party.BuildingNumber);

                // Nullable BranchId
                if (party.BranchId == null)
                    cmd.Parameters.AddWithValue("@BranchId", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@BranchId", party.BranchId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}
