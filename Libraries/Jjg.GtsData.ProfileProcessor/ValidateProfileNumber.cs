using System;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.ProfileProcessor
{
	public class ValidateProfileNumber
	{
		public Int64 Validate(Int64 profileNumber, Int64 increment)
		{
			bool valid = true;
			Int64 lastValidNumber = profileNumber;
			try
			{
				do
				{
					CheckProfileNumber check = new CheckProfileNumber();
					valid = check.Check(profileNumber);
					if (valid == false)
					{
						break;
					}
					else
					{
						lastValidNumber = profileNumber;
						profileNumber = profileNumber + increment;
					}
				} while (valid == true);
			}
			catch(Exception ex)
			{
				EventWriter writer = new EventWriter();
				writer.Write(ex.ToString());
			}
			return lastValidNumber;
		}
	}
}
