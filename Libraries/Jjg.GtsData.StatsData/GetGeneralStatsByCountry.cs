using System;
using System.Data;
using System.Data.SqlClient;

namespace Jjg.GtsData.StatsData
{
	public class GetGeneralStatsByCountry
	{
        public DataTable Get(string proc, long pageNumber, long perPage, string country, long regionId)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand(proc, conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@PerPage", SqlDbType.BigInt).Value = perPage;
                    cmd.Parameters.Add("@Country", SqlDbType.NVarChar).Value = country;
                    cmd.Parameters.Add("@PageNumber", SqlDbType.BigInt).Value = pageNumber;
                    cmd.Parameters.Add("@RegionId", SqlDbType.BigInt).Value = regionId;
                    cmd.CommandTimeout = 0;
                    conn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
            DataTable retTable = new DataTable();
            retTable.Columns.Add("Rank", typeof(long));
            retTable.Columns.Add("Player", typeof(string));
            retTable.Columns.Add("ImagePath", typeof(string));
            retTable.Columns.Add("Value", typeof(string));
            retTable.Columns.Add("Wins", typeof(string));
            retTable.Columns.Add("Races", typeof(string));
            retTable.Columns.Add("EntryDate", typeof(DateTime));
            foreach (DataRow dr in dt.Rows)
            {
                long rank = long.Parse(dr[0].ToString());
                string player = dr[1].ToString();
                string countryName = dr[2].ToString();
                string value = string.Empty;
                string wins = string.Empty;
                string races = string.Empty;
                DateTime entryDate = DateTime.Parse(dr[6].ToString());
                string str = proc;
                string str1 = str;
                if (str != null)
                {
                    switch (str1)
                    {
                        case "GTS_CarCount_ByCountryPaged":
                            {
                                value = string.Format("{0:N0}", long.Parse(dr[3].ToString()));
                                break;
                            }
                        case "GTS_CarsPurchased_ByCountryPaged":
                            {
                                value = string.Format("{0:N0}", long.Parse(dr[3].ToString()));
                                break;
                            }
                        case "GTS_CreditEarned_ByCountryPaged":
                            {
                                value = string.Format("{0:N0}", long.Parse(dr[3].ToString()));
                                break;
                            }
                        case "GTS_DriverRating_ByCountryPaged":
                            {
                                value = string.Format("{0:N0}", long.Parse(dr[3].ToString()));
                                break;
                            }
                        case "GTS_Experience_ByCountryPaged":
                            {
                                value = string.Format("{0:N0}", long.Parse(dr[3].ToString()));
                                break;
                            }
                        case "GTS_FastestLaps_ByCountryPaged":
                            {
                                value = string.Format("{0:N0}", long.Parse(dr[3].ToString()));
                                break;
                            }
                        case "GTS_FuelConsumed_ByCountryPaged":
                            {
                                value = string.Format("{0:N0}", long.Parse(dr[3].ToString()));
                                break;
                            }
                        case "GTS_Level_ByCountryPaged":
                            {
                                value = string.Format("{0:N0}", long.Parse(dr[3].ToString()));
                                break;
                            }
                        case "GTS_LoginCount_ByCountryPaged":
                            {
                                value = string.Format("{0:N0}", long.Parse(dr[3].ToString()));
                                break;
                            }
                        case "GTS_PolePositions_ByCountryPaged":
                            {
                                value = string.Format("{0:N0}", long.Parse(dr[3].ToString()));
                                break;
                            }
                        case "GTS_RaceCount_ByCountryPaged":
                            {
                                value = string.Format("{0:N0}", long.Parse(dr[3].ToString()));
                                break;
                            }
                        case "GTS_RacesFinished_ByCountryPaged":
                            {
                                value = string.Format("{0:N0}", long.Parse(dr[3].ToString()));
                                break;
                            }
                        case "GTS_TimeDriven_ByCountryPaged":
                            {
                                double seconds = long.Parse(dr[3].ToString());
                                value = TimeSpan.FromSeconds(seconds).ToString();
                                break;
                            }
                        case "GTS_TimePlayed_ByCountryPaged":
                            {
                                double seconds2 = long.Parse(dr[3].ToString());
                                value = TimeSpan.FromSeconds(seconds2).ToString();
                                break;
                            }
                        case "GTS_TotalDistance_ByCountryPaged":
                            {
                                value = string.Format("{0:N4} km", decimal.Parse(dr[3].ToString()) / new decimal(1000));
                                break;
                            }
                        case "GTS_Wins_ByCountryPaged":
                            {
                                value = string.Format("{0:N0}", long.Parse(dr[3].ToString()));
                                break;
                            }
                        case "GTS_PolesPerEntry_ByCountryPaged":
                            {
                                value = string.Format("{0:N4}%", decimal.Parse(dr[3].ToString()) * new decimal(100));
                                break;
                            }
                        case "GTS_FinishesPerEntry_ByCountryPaged":
                            {
                                value = string.Format("{0:N4}%", decimal.Parse(dr[3].ToString()) * new decimal(100));
                                break;
                            }
                        case "GTS_WinsPerEntry_ByCountryPaged":
                            {
                                value = string.Format("{0:N4}%", decimal.Parse(dr[3].ToString()) * new decimal(100));
                                wins = string.Format("{0:N0}", long.Parse(dr[4].ToString()));
                                races = string.Format("{0:N0}", long.Parse(dr[5].ToString()));
                                break;
                            }
                        case "GTS_CleanRaces_ByCountryPaged":
                            {
                                value = string.Format("{0:N0}", long.Parse(dr[3].ToString()));
                                break;
                            }
                    }
                }
                DataRowCollection rows = retTable.Rows;
                object[] objArray = new object[] { rank, player, countryName, value, wins, races, entryDate };
                rows.Add(objArray);
            }
            return retTable;
        }
    }
}
