using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetStatTypes
	{
        public DataTable Get()
        {
            DataTable statTypes = new DataTable();
            statTypes.Columns.Add("StatTypeId", typeof(long));
            statTypes.Columns.Add("StatType", typeof(string));
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_StatTypes_Select", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
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
