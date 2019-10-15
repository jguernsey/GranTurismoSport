using System;
using System.Linq;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.Conversions
{
	public static class StringToLong
	{
		public static Int64 SafeToLong(this string inStr)
		{
			Int64 retVal = 0;
			try
			{
				if (inStr != null)
				{
					bool isValid = Int64.TryParse(inStr, out retVal);
					if(!isValid)
					{
						retVal = 0;
					}
				}
				else
				{
					retVal = 0;
				}
			}
			catch(Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());
				retVal = 0;
			}
			return retVal;
		}
	}
}
