using Jjg.GtsData.StatsData;
using System;
using System.Data;


namespace Jjg.GtsData.RaceEvents
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
    }
}
