using System.ServiceProcess;

namespace SvcRaceResults
{
	public class Program
	{
		public static void Main(string[] args)
		{
			ServiceBase[] servicesToRun = new ServiceBase[]
			{
				new ResultsService()
			};
			ServiceBase.Run(servicesToRun);
		}
	}
}