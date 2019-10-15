using System;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.Conversions
{
	public class ConvertStringToArray
	{
		public Int64[] Convert(string inStr)
		{
			EventWriter writer = new EventWriter();
			Int64[] outArray = new Int64[20];
			if (!string.IsNullOrEmpty(inStr))
			{
				try
				{
					Int64[] nums = Array.ConvertAll(inStr.Split(','), Int64.Parse);
					if(nums.Length == 20)
					{
						outArray = nums;
					}
					else
					{
						writer.Write("Array is not 20 long");
					}
				}
				catch(Exception ex)
				{
					writer.Write(ex.ToString());
				}
			}
			else
			{
				writer.Write("String is empty or null");
				outArray = new Int64[20] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
			}
			return outArray;
		}
	}
}
