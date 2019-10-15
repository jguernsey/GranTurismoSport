using System;

namespace Jjg.GtsData.RaceEvents
{
	public class EventContentCleaner
	{
        public string Clean(string content, int type)
        {
            if (type == 1)
            {
                content = content.Replace("_", string.Empty);
            }
            else if (type == 2)
            {
                content = content.Replace(",\"entry_set\":[{\"entry_generate\":{\"player_entry_base_array\":[{}]}}]", string.Empty);
                content = content.Replace("},\"15\"]}]}", "]}]}");
                content = content.Replace("},\"25\"]}]}", "]}]}");
                content = content.Replace("},\"40\"]}]}", "]}]}");
                content = content.Replace("},\"55\"]}]}", "]}]}");
                content = content.Replace("{\"GameParameter\":", string.Empty);
            }
            return content;
        }
    }
}
