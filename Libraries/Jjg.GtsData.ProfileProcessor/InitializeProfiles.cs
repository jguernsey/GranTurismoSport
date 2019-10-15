using System;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.ProfileProcessor
{
	public class InitializeProfiles
	{
		public void Initialize()
		{
			GetLastProfileNumber getLast = new GetLastProfileNumber();
			Int64 lastProfileNumber = getLast.Get();

			LocateEndpoint locateEndpoint = new LocateEndpoint();
			Int64 endPoint = locateEndpoint.Locate(lastProfileNumber);

			IncreaseMaximumNumber update = new IncreaseMaximumNumber();
			update.Update(lastProfileNumber, endPoint);
		}
	}
}
