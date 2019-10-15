using Jjg.GtsData.Common;
using Jjg.GtsData.Conversions;
using Jjg.GtsData.RaceEvents;
using Jjg.GtsData.StatsData;
using System;
using System.IO;

namespace Jjg.GtsData.RaceCalendar
{
    public class EventContentReader
    {
        public void Read(string content, long regionId)
        {
            if (!string.IsNullOrEmpty(content))
            {
                using (StringReader readerC = new StringReader(content))
                {
                    string line = string.Empty;
                    while (true)
                    {
                        string str = readerC.ReadLine();
                        line = str;
                        if (str == null)
                        {
                            break;
                        }
                        if (!string.IsNullOrEmpty(line))
                        {
                            try
                            {
                                string cc = new EventContentCleaner().Clean(line, 2);
                                GtsRaces cr = new ConvertToRaceDetails().Convert(cc);
                                EventDetail ed = new InitializeEventDetail().Initialize(regionId);
                                ed = new CreateEventDetail().Create(ed, cr);
                                new InsertEventDetail().Insert(ed);
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
}
