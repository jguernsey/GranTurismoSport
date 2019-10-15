using System;
using DotNetNuke.Services.Exceptions;

namespace Jjg.GtsStats.StatCharts
{
	public partial class Edit : StatChartsModuleBase
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			try
			{

			}
			catch (Exception exc) //Module failed to load
			{
				Exceptions.ProcessModuleLoadException(this, exc);
			}
		}
	}
}