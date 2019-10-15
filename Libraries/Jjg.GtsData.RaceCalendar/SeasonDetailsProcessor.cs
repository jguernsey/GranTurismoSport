using Jjg.GtsData.Common;
using Jjg.GtsData.Conversions;
using Jjg.GtsData.Requester;
using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceCalendar
{
    public class SeasonDetailsProcessor
    {
        public void Process()
        {
            string[] strArrays = new string[] { "jp", "de", "us" };
            for (int i = 0; i < strArrays.Length; i++)
            {
                string region = strArrays[i];
                try
                {
                    DateTime now = DateTime.Now;
                    GetSeasons getSeasons = new GetSeasons();
                    string content = getSeasons.Get(region);

                    SeasonsArray seasons = new ConvertToSeasonsArray().Convert(content);
                    long regionId = 0;
                    string str = region;
                    string str1 = str;
                    if (str != null)
                    {
                        if (str1 == "jp")
                        {
                            regionId = 1;
                        }
                        else if (str1 == "de")
                        {
                            regionId = 2;
                        }
                        else if (str1 == "us")
                        {
                            regionId = 3;
                        }
                    }
                    new ProcessSeasons().Process(seasons, regionId);
                }
                catch (Exception exception)
                {
                    new EventWriter().Write(exception.ToString());
                }
            }
        }
    }
}
