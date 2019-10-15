using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetManufacturerImage
	{
        public byte[] Get(string manufacturerCode)
        {
            byte[] imageData = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_Manufacturers_GetImage", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
                    cmd.Parameters.Add("@PDCode", SqlDbType.BigInt).Value = long.Parse(manufacturerCode);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        imageData = (byte[])reader["Image"];
                    }
                    reader.Close();
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return imageData;
        }
    }
}
