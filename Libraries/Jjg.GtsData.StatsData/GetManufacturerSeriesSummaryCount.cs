using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetManufacturerSeriesSummaryCount
	{
        public long Get(string season, long regionId, long countryId, long manufacturerId)
        {
            long entryCount = 0;
            if (countryId > 0 && manufacturerId > 0)
            {
                entryCount = this.GetByAll(season, regionId, countryId, manufacturerId);
            }
            else if (countryId <= 0)
            {
                entryCount = manufacturerId <= 0 ? this.GetByNone(season, regionId) : this.GetByManufacturer(season, regionId, manufacturerId);
            }
            else
            {
                entryCount = this.GetByCountry(season, regionId, countryId);
            }
            return entryCount;
        }

        private long GetByAll(string season, long regionId, long countryId, long manufacturerId)
        {
            long dt = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_ManufacturerSeries_GetCountByAll", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@EventTarget", SqlDbType.NVarChar).Value = season;
                    cmd.Parameters.Add("@RegionId", SqlDbType.BigInt).Value = regionId;
                    cmd.Parameters.Add("@CountryId", SqlDbType.BigInt).Value = countryId;
                    cmd.Parameters.Add("@ManufacturerId", SqlDbType.BigInt).Value = manufacturerId;
                    cmd.CommandTimeout = 0;
                    conn.Open();
                    dt = long.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return dt;
        }

        private long GetByCountry(string season, long regionId, long countryId)
        {
            long dt = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_ManufacturerSeries_GetCountByCountry", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@EventTarget", SqlDbType.NVarChar).Value = season;
                    cmd.Parameters.Add("@RegionId", SqlDbType.BigInt).Value = regionId;
                    cmd.Parameters.Add("@CountryId", SqlDbType.BigInt).Value = countryId;
                    cmd.CommandTimeout = 0;
                    conn.Open();
                    dt = long.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return dt;
        }

        private long GetByManufacturer(string season, long regionId, long manufacturerId)
        {
            long dt = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_ManufacturerSeries_GetCountByManufacturer", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@EventTarget", SqlDbType.NVarChar).Value = season;
                    cmd.Parameters.Add("@RegionId", SqlDbType.BigInt).Value = regionId;
                    cmd.Parameters.Add("@ManufacturerId", SqlDbType.BigInt).Value = manufacturerId;
                    cmd.CommandTimeout = 0;
                    conn.Open();
                    dt = long.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            return dt;
        }

        private long GetByNone(string season, long regionId)
        {
            long dt = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_ManufacturerSeries_GetCount", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@EventTarget", SqlDbType.NVarChar).Value = season;
                    cmd.Parameters.Add("@RegionId", SqlDbType.BigInt).Value = regionId;
                    cmd.CommandTimeout = 0;
                    conn.Open();
                    dt = long.Parse(cmd.ExecuteScalar().ToString());
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
