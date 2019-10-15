using System;

namespace Jjg.GtsData.Common
{
	public class EventDetails
	{
        public long Event_Id;

        public long Championship_Id;

        public long Season_Id;

        public long Round_Id;

        public string Championship_Color;

        public string Game_Mode;

        public string Event_Type;

        public string Sports_Mode;

        public EventInformation Information;

        public EntrySetDetail[] entry_set;

        public EventRaceDetail Race;

        public EventRanking Ranking;

        public EventRegulation Regulation;

        public long Refueling_Speed;

        public long Track_Index;

        public long matching_method;

        public long is_uncertain_event;
    }
}
