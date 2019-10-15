using System.Configuration;

namespace Jjg.GtsData.StatsData
{
	public static class DbConn
	{
		public static string Get()
		{
			return ConfigurationManager.AppSettings["SiteSqlServer"].ToString();
		}
	}
}
