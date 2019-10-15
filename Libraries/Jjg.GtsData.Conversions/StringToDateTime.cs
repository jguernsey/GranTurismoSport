using System;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.Conversions
{
	public static class StringToDateTime
	{
		public static DateTime SafeDateTime(this string inStr)
		{
			DateTime retVal = new DateTime(1753, 1, 1, 0, 0, 0);
			try
			{
				if(!string.IsNullOrEmpty(inStr))
				{
					bool isValid = DateTime.TryParse(inStr, out retVal);
					if(isValid)
					{
						retVal = DateTime.Parse(inStr);
					}
					else
					{
						retVal = new DateTime(1753, 1, 1, 0, 0, 0);
					}
				}
			}
			catch(Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());
			}
			return retVal;
		}
	}
}
