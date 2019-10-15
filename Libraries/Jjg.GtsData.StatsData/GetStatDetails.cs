using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetStatDetails
	{
        public DataTable Get(string statType)
        {
            DataTable statTypes = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_StatType_Details", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
                    cmd.Parameters.Add("@StatType", SqlDbType.NVarChar).Value = statType;
                    conn.Open();
                    new SqlDataAdapter(cmd).Fill(statTypes);
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return statTypes;
        }
    }
}
