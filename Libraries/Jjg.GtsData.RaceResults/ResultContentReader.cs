using Jjg.GtsData.Common;
using Jjg.GtsData.Conversions;
using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceResults
{
    public class ResultContentReader
    {
        public void Read(string content)
        {
            using (StringReader reader = new StringReader(content))
            {
                string line = string.Empty;
                while (true)
                {
                    string str = reader.ReadLine();
                    line = str;
                    if (str == null)
                    {
                        break;
                    }
                    if (!string.IsNullOrEmpty(line))
                    {
                        try
                        {
                            EventResults[] eventResult = new ConvertToGtsEvent().Convert(line).event_result;
                            for (int i = 0; i < eventResult.Length; i++)
                            {
                                EventResults er = eventResult[i];
                                new CreateEventDetail().Create(er);
                            }
                        }
                        catch (Exception exception)
                        {
                            new EventWriter().Write(exception.ToString());
                        }
                    }
                }
            }
        }
    }
}
