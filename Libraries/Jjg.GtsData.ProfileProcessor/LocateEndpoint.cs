using System;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsData.ProfileProcessor
{
    public class LocateEndpoint
    {
		public Int64 Locate(Int64 profileNumber)
		{
			Int64 lastProfileNumber = profileNumber;
			ValidateProfileNumber phaseOne = new ValidateProfileNumber();
			lastProfileNumber = phaseOne.Validate(profileNumber, 100000);

			ValidateProfileNumber phaseTwo = new ValidateProfileNumber();
			lastProfileNumber = phaseTwo.Validate(lastProfileNumber, 10000);

			ValidateProfileNumber phaseThree = new ValidateProfileNumber();
			lastProfileNumber = phaseThree.Validate(lastProfileNumber, 1000);

			ValidateProfileNumber phaseFour = new ValidateProfileNumber();
			lastProfileNumber = phaseFour.Validate(lastProfileNumber, 100);

			ValidateProfileNumber phaseFive = new ValidateProfileNumber();
			lastProfileNumber = phaseFive.Validate(lastProfileNumber, 10);

			ValidateProfileNumber phaseSix = new ValidateProfileNumber();
			lastProfileNumber = phaseSix.Validate(lastProfileNumber, 1);

			EventWriter writer = new EventWriter();
			writer.Write(string.Format("Max Profile Number: {0}", lastProfileNumber));

			return lastProfileNumber;
		}
    }
}
