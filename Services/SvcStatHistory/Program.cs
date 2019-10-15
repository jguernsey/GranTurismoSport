using System;
using System.ServiceProcess;

namespace SvcStatHistory
{
	public class Program
	{
		public static void Main(string[] args)
		{
			ServiceBase[] servicesToRun = new ServiceBase[]
			{
				new StatHistoryService()
			};
			ServiceBase.Run(servicesToRun);
		}
	}
}
