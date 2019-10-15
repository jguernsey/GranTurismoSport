using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Jjg.GtsData.Common;

namespace Jjg.GtsData.StatsData
{
	public class GetRegisteredUserDetails
	{
        public List<NumberGroup> Get(out long totalCount)
        {
            List<NumberGroup> groups = new List<NumberGroup>();
            totalCount = 0;
            for (long i = 1; i <= 15; i += 1)
            {
                DataTable dt = new DataTable();
                try
                {
                    using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                    {
                        SqlCommand cmd = new SqlCommand("GTS_GetAllRegisteredUserDetails_Paged", conn)
                        {
                            CommandType = CommandType.StoredProcedure,
                            CommandTimeout = 0
                        };
                        cmd.Parameters.Add("@PageNumber", SqlDbType.BigInt).Value = i;
                        conn.Open();
                        new SqlDataAdapter(cmd).Fill(dt);
                    }
                    totalCount += dt.Rows.Count;
                    NumberGroup tpg = new NumberGroup()
                    {
                        GroupId = i,
                        Numbers = dt
                    };
                    groups.Add(tpg);
                }
                catch (Exception exception)
                {
                    new EventWriter().Write(exception.ToString());
                }
                if (dt.Rows.Count == 0 && totalCount == 0)
                {
                    break;
                }
            }
            return groups;
        }
    }
}
