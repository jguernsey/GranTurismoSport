using Jjg.GtsData.StatsData;
using System;
using System.Data;

namespace Jjg.GtsData.LapTimes
{
    public class ProcessBoards
    {
        public void Process()
        {
            EventWriter writer = new EventWriter();
            DateTime start = DateTime.Now;
            DateTime now = DateTime.Now;
            writer.Write(string.Format("Start:UpdateQualifyingTimes:{0}", now.ToString()));
            DataTable dt = new GetDailyRaceInfo().Get();
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows.Count != 15)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        string region = dr[0].ToString();
                        long boardId = long.Parse(dr[1].ToString());
                        long entryCount = long.Parse(dr[2].ToString());
                        if (region.Equals("fi"))
                        {
                            FiaLoop(boardId, entryCount);
                        }
                        
                        writer.Write(string.Format("Region:{0}-BoardId:{1}-EntryCount{2}", region, boardId, entryCount));
                        new GetUpdateLapTimes().Update(region, boardId, entryCount);
                    }
                }
                else
                {
                    new BatchUpdateLapTimes().Update(dt);
                }
            }
            TimeSpan ts = DateTime.Now.Subtract(start);
            DateTime dateTime = DateTime.Now;
            writer.Write(string.Format("End:UpdateQualifyingTimes:{0}-Duration:{1}", dateTime.ToString(), ts.ToString()));
        }
        private void FiaLoop(long boardId, long entryCount)
        {
            EventWriter writer = new EventWriter();
            
            string[] regions = new string[3] { "us", "de", "jp" };
            foreach(string region in regions)
            {
                writer.Write(string.Format("Region:{0}-BoardId:{1}-EntryCount{2}", region, boardId, entryCount));
                new GetUpdateLapTimes().Update(region, boardId, entryCount);
            }
        }
    }
}
