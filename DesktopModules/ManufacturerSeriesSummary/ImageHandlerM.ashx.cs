using System.Web;
using Jjg.GtsData.StatsData;

namespace Jjg.GtsStats.ManufacturerSeriesSummary
{
	public class ImageHandlerM : IHttpHandler
	{

		public void ProcessRequest(HttpContext context)
		{
			GetManufacturerImage getImage = new GetManufacturerImage();
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