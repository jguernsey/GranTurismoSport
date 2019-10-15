using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class InsertLocalizedText
	{
        public void Insert(long roundId, long textType, string countryCode, string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                EventWriter w = new EventWriter();
                w.Write(string.Format("Bad Entry: Round Id:{0} Type:{1} Country: {2}", roundId, textType, countryCode));
            }
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                    {
                        SqlCommand cmd = new SqlCommand("GTS_LocalizedText_Insert", conn)
                        {
                            CommandType = CommandType.StoredProcedure,
                            CommandTimeout = 0
                        };
                        cmd.Parameters.Add("@RoundId", SqlDbType.BigInt).Value = roundId;
                        cmd.Parameters.Add("@TextType", SqlDbType.BigInt).Value = textType;
                        cmd.Parameters.Add("@CountryCode", SqlDbType.NVarChar).Value = countryCode;
                        cmd.Parameters.Add("@LocalText", SqlDbType.NVarChar).Value = text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception exception)
                {
                    new EventWriter().Write(exception.ToString());
                }
            }
        }
    }
}
