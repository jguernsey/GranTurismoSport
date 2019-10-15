using System;
using System.Linq;
using System.Web;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsStats.CountryStats
{
	public class ImageHandler : IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{
			GetCountryFlagImage getImage = new GetCountryFlagImage();
			byte[] imageData = getImage.Get(context.Request.QueryString["imgId"].ToString());

			context.Response.ContentType = "image/jpg";
			context.Response.BinaryWrite(imageData);
		}

		public bool IsReusable
		{
			get
			{
				return false;
			}
		}
	}
}