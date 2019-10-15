using System.Configuration;

namespace ImageUploader
{
	public static class DbConn
	{
		public static string Get()
		{
			return ConfigurationManager.AppSettings["AppDb"].ToString();
		}
	}
}
