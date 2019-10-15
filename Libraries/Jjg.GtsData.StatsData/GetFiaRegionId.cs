using System;

namespace Jjg.GtsData.StatsData
{
    public class GetFiaRegionId
    {
        public long Get(string psnLogin)
        {
            long regionId = 0;
            try
            {

            }
            catch (Exception ex)
            {
                EventWriter writer = new EventWriter();
                writer.Write(ex.ToString());
            }
            return regionId;
        }
    }
}
