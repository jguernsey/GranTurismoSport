using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetManufacturerIdByCarId
	{
        public DataTable Get(long carId)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ManufacturerId", typeof(long));
            dt.Columns.Add("CategoryId", typeof(long));
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_Cars_SelectByCarId", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@CarId", SqlDbType.BigInt).Value = carId;
                    conn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return dt;
        }
    }
}
