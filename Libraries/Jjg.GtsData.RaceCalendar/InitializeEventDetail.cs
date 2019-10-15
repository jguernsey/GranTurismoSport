using Jjg.GtsData.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceCalendar
{
    public class InitializeEventDetail
    {
        public EventDetail Initialize(long regionId)
        {
            EventDetail ed = new EventDetail()
            {
                RegionId = regionId,
                EventId = 0,
                ChampionshipId = 0,
                SeasonId = 0,
                RoundId = 0,
                ChampionshipColor = string.Empty,
                GameMode = string.Empty,
                EventType = string.Empty,
                SportsMode = string.Empty,
                Title = string.Empty,
                OneLineTitle = string.Empty,
                Description = string.Empty,
                RegistrationNotice = string.Empty,
                EventTarget = string.Empty,
                EventRestrict = string.Empty,
                LogoImagePath = string.Empty,
                FlyerImagePath = string.Empty,
                BehaviorDamageType = string.Empty,
                BehaviorSlipStreamType = string.Empty,
                BoostLevel = string.Empty,
                LowMuType = string.Empty,
                EntryMax = 0,
                StartType = string.Empty,
                ConsumeFuel = 0,
                ConsumeTire = 0,
                RaceLimitLaps = 0,
                RaceLimitMinutes = 0,
                PitConstraint = 0,
                NeedCompoundUse = string.Empty,
                LimitFuelCapacity = 0,
                BoardId = 0,
                LimitTireF = 0,
                NeedTireF = 0,
                UseBop = 0,
                Tuning = 0,
                NeedDriverClass = string.Empty,
                CarCategoryTypes = string.Empty,
                Cars = string.Empty,
                CarsCount = 0,
                RefuelingSpeed = 0,
                CourseCode = string.Empty,
                WeatherId = 0
            };
            return ed;
        }
    }
}
