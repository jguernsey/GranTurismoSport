using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.Requester
{
    public class GetCourseRecords
    {
        public string Get(Int64 profileNumber)
        {
            string content = string.Empty;
            for (int i = 0; i <= 16; i++)
            {
                try
                {
                    string fileName = string.Format("C:\\GTS\\Services\\Logs\\course_record_{0}.json", i.ToString());
                    string url = string.Format("https://www.gran-turismo.com/us/api/gt7sp/course_record/?category_id={0}&course_id=-1&is_category=1&job=1&user_no={1}", i, profileNumber);
                    RequestData request = new RequestData();
                    content = request.Request(url);
                    using (StreamWriter writer = new StreamWriter(fileName, true))
                    {
                        writer.Write(content);
                    }
                }
                catch (Exception ex)
                {
                    EventWriter writer = new EventWriter();
                    writer.Write(ex.ToString());
                }
            }
            return content;
        }
    }
}
