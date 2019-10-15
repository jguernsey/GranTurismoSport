using Jjg.GtsData.StatsData;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Jjg.GtsData.LapTimes
{
    public class BatchUpdateLapTimes
    {
        public void Update(DataTable dt)
        {
            try
            {
                Task[] taskArray = new Task[] { Task.Factory.StartNew(() => new GetUpdateLapTimes().Update(dt.Rows[0][0].ToString(), long.Parse(dt.Rows[0][1].ToString()), long.Parse(dt.Rows[0][2].ToString()))), Task.Factory.StartNew(() => new GetUpdateLapTimes().Update(dt.Rows[1][0].ToString(), long.Parse(dt.Rows[1][1].ToString()), long.Parse(dt.Rows[1][2].ToString()))), Task.Factory.StartNew(() => new GetUpdateLapTimes().Update(dt.Rows[2][0].ToString(), long.Parse(dt.Rows[2][1].ToString()), long.Parse(dt.Rows[2][2].ToString()))), Task.Factory.StartNew(() => new GetUpdateLapTimes().Update(dt.Rows[3][0].ToString(), long.Parse(dt.Rows[3][1].ToString()), long.Parse(dt.Rows[3][2].ToString()))), Task.Factory.StartNew(() => new GetUpdateLapTimes().Update(dt.Rows[4][0].ToString(), long.Parse(dt.Rows[4][1].ToString()), long.Parse(dt.Rows[4][2].ToString()))), Task.Factory.StartNew(() => new GetUpdateLapTimes().Update(dt.Rows[5][0].ToString(), long.Parse(dt.Rows[5][1].ToString()), long.Parse(dt.Rows[5][2].ToString()))), Task.Factory.StartNew(() => new GetUpdateLapTimes().Update(dt.Rows[6][0].ToString(), long.Parse(dt.Rows[6][1].ToString()), long.Parse(dt.Rows[6][2].ToString()))), Task.Factory.StartNew(() => new GetUpdateLapTimes().Update(dt.Rows[7][0].ToString(), long.Parse(dt.Rows[7][1].ToString()), long.Parse(dt.Rows[7][2].ToString()))), Task.Factory.StartNew(() => new GetUpdateLapTimes().Update(dt.Rows[8][0].ToString(), long.Parse(dt.Rows[8][1].ToString()), long.Parse(dt.Rows[8][2].ToString()))), Task.Factory.StartNew(() => new GetUpdateLapTimes().Update(dt.Rows[9][0].ToString(), long.Parse(dt.Rows[9][1].ToString()), long.Parse(dt.Rows[9][2].ToString()))), Task.Factory.StartNew(() => new GetUpdateLapTimes().Update(dt.Rows[10][0].ToString(), long.Parse(dt.Rows[10][1].ToString()), long.Parse(dt.Rows[10][2].ToString()))), Task.Factory.StartNew(() => new GetUpdateLapTimes().Update(dt.Rows[11][0].ToString(), long.Parse(dt.Rows[11][1].ToString()), long.Parse(dt.Rows[11][2].ToString()))), Task.Factory.StartNew(() => new GetUpdateLapTimes().Update(dt.Rows[12][0].ToString(), long.Parse(dt.Rows[12][1].ToString()), long.Parse(dt.Rows[12][2].ToString()))), Task.Factory.StartNew(() => new GetUpdateLapTimes().Update(dt.Rows[13][0].ToString(), long.Parse(dt.Rows[13][1].ToString()), long.Parse(dt.Rows[13][2].ToString()))), Task.Factory.StartNew(() => new GetUpdateLapTimes().Update(dt.Rows[14][0].ToString(), long.Parse(dt.Rows[14][1].ToString()), long.Parse(dt.Rows[14][2].ToString()))) };
                Task.WaitAll(taskArray);
            }
            catch (Exception exception)
            {
                new EventWriter().Write(exception.ToString());
            }
        }
    }
}
