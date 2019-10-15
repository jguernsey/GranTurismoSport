using Jjg.GtsData.Common;
using Jjg.GtsData.StatsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jjg.GtsData.RaceCalendar
{
    public class CreateEventDetail
    {
        public EventDetail Create(EventDetail ed, GtsRaces cr)
        {
            EventWriter writer = new EventWriter();
            if (cr.Event.Length == 1 && cr.Event[0].Value.Length == 1 && cr.Event[0].Value[0].Events.Length == 1)
            {
                try
                {
                    if (cr.Event[0].Value[0].Events[0].Event_Id > 0)
                    {
                        ed.EventId = cr.Event[0].Value[0].Events[0].Event_Id;
                    }
                }
                catch (Exception exception)
                {
                    writer.Write(exception.ToString());
                }
                try
                {
                    ed.ChampionshipId = cr.Event[0].Value[0].Events[0].Championship_Id;
                }
                catch (Exception exception1)
                {
                    writer.Write(exception1.ToString());
                }
                try
                {
                    ed.SeasonId = cr.Event[0].Value[0].Events[0].Season_Id;
                }
                catch (Exception exception2)
                {
                    writer.Write(exception2.ToString());
                }
                try
                {
                    ed.RoundId = cr.Event[0].Value[0].Events[0].Round_Id;
                }
                catch (Exception exception3)
                {
                    writer.Write(exception3.ToString());
                }
                try
                {
                    if (!string.IsNullOrEmpty(cr.Event[0].Value[0].Events[0].Championship_Color))
                    {
                        ed.ChampionshipColor = cr.Event[0].Value[0].Events[0].Championship_Color;
                    }
                }
                catch (Exception exception4)
                {
                    writer.Write(exception4.ToString());
                }
                try
                {
                    if (!string.IsNullOrEmpty(cr.Event[0].Value[0].Events[0].Game_Mode))
                    {
                        ed.GameMode = cr.Event[0].Value[0].Events[0].Game_Mode;
                    }
                }
                catch (Exception exception5)
                {
                    writer.Write(exception5.ToString());
                }
                try
                {
                    if (!string.IsNullOrEmpty(cr.Event[0].Value[0].Events[0].Event_Type))
                    {
                        ed.EventType = cr.Event[0].Value[0].Events[0].Event_Type;
                    }
                }
                catch (Exception exception6)
                {
                    writer.Write(exception6.ToString());
                }
                try
                {
                    if (!string.IsNullOrEmpty(cr.Event[0].Value[0].Events[0].Sports_Mode))
                    {
                        ed.SportsMode = cr.Event[0].Value[0].Events[0].Sports_Mode;
                    }
                }
                catch (Exception exception7)
                {
                    writer.Write(exception7.ToString());
                }
                try
                {
                    if (!string.IsNullOrEmpty(cr.Event[0].Value[0].Events[0].Information.Title.US))
                    {
                        ed.Title = cr.Event[0].Value[0].Events[0].Information.Title.US;
                    }
                }
                catch (Exception exception8)
                {
                    writer.Write(exception8.ToString());
                }
                try
                {
                    if (!string.IsNullOrEmpty(cr.Event[0].Value[0].Events[0].Information.One_Line_Title.US))
                    {
                        ed.OneLineTitle = cr.Event[0].Value[0].Events[0].Information.One_Line_Title.US;
                    }
                }
                catch (Exception exception9)
                {
                    writer.Write(exception9.ToString());
                }
                try
                {
                    if (!string.IsNullOrEmpty(cr.Event[0].Value[0].Events[0].Information.Description.US))
                    {
                        ed.Description = cr.Event[0].Value[0].Events[0].Information.Description.US;
                    }
                }
                catch (Exception exception10)
                {
                    writer.Write(exception10.ToString());
                }
                try
                {
                    if (!string.IsNullOrEmpty(cr.Event[0].Value[0].Events[0].Information.Registration_Notice.US))
                    {
                        ed.RegistrationNotice = cr.Event[0].Value[0].Events[0].Information.Registration_Notice.US;
                    }
                }
                catch (Exception exception11)
                {
                    writer.Write(exception11.ToString());
                }
                try
                {
                    if (!string.IsNullOrEmpty(cr.Event[0].Value[0].Events[0].Information.Event_Target.US))
                    {
                        ed.EventTarget = cr.Event[0].Value[0].Events[0].Information.Event_Target.US;
                    }
                }
                catch (Exception exception12)
                {
                    writer.Write(exception12.ToString());
                }
                try
                {
                    if (!string.IsNullOrEmpty(cr.Event[0].Value[0].Events[0].Information.Event_Restrict.US))
                    {
                        ed.EventRestrict = cr.Event[0].Value[0].Events[0].Information.Event_Restrict.US;
                    }
                }
                catch (Exception exception13)
                {
                    writer.Write(exception13.ToString());
                }
                try
                {
                    if (!string.IsNullOrEmpty(cr.Event[0].Value[0].Events[0].Information.Logo_Image_Path))
                    {
                        ed.LogoImagePath = cr.Event[0].Value[0].Events[0].Information.Logo_Image_Path;
                    }
                }
                catch (Exception exception14)
                {
                    writer.Write(exception14.ToString());
                }
                try
                {
                    if (!string.IsNullOrEmpty(cr.Event[0].Value[0].Events[0].Information.Flyer_Image_Path))
                    {
                        ed.FlyerImagePath = cr.Event[0].Value[0].Events[0].Information.Flyer_Image_Path;
                    }
                }
                catch (Exception exception15)
                {
                    writer.Write(exception15.ToString());
                }
                try
                {
                    if (!string.IsNullOrEmpty(cr.Event[0].Value[0].Events[0].Race.Behavior_Damage_Type))
                    {
                        ed.BehaviorDamageType = cr.Event[0].Value[0].Events[0].Race.Behavior_Damage_Type;
                    }
                }
                catch (Exception exception16)
                {
                    writer.Write(exception16.ToString());
                }
                try
                {
                    if (!string.IsNullOrEmpty(cr.Event[0].Value[0].Events[0].Race.Behavior_Slip_Stream_Type))
                    {
                        ed.BehaviorSlipStreamType = cr.Event[0].Value[0].Events[0].Race.Behavior_Slip_Stream_Type;
                    }
                }
                catch (Exception exception17)
                {
                    writer.Write(exception17.ToString());
                }
                try
                {
                    if (!string.IsNullOrEmpty(cr.Event[0].Value[0].Events[0].Race.Boost_Level))
                    {
                        ed.BoostLevel = cr.Event[0].Value[0].Events[0].Race.Boost_Level;
                    }
                }
                catch (Exception exception18)
                {
                    writer.Write(exception18.ToString());
                }
                try
                {
                    if (!string.IsNullOrEmpty(cr.Event[0].Value[0].Events[0].Race.Low_Mu_Type))
                    {
                        ed.LowMuType = cr.Event[0].Value[0].Events[0].Race.Low_Mu_Type;
                    }
                }
                catch (Exception exception19)
                {
                    writer.Write(exception19.ToString());
                }
                try
                {
                    ed.EntryMax = cr.Event[0].Value[0].Events[0].Race.Entry_Max;
                }
                catch (Exception exception20)
                {
                    writer.Write(exception20.ToString());
                }
                try
                {
                    if (!string.IsNullOrEmpty(cr.Event[0].Value[0].Events[0].Race.Start_Type))
                    {
                        ed.StartType = cr.Event[0].Value[0].Events[0].Race.Start_Type;
                    }
                }
                catch (Exception exception21)
                {
                    writer.Write(exception21.ToString());
                }
                try
                {
                    ed.ConsumeFuel = cr.Event[0].Value[0].Events[0].Race.Consume_Fuel;
                }
                catch (Exception exception22)
                {
                    writer.Write(exception22.ToString());
                }
                try
                {
                    ed.ConsumeTire = cr.Event[0].Value[0].Events[0].Race.Consume_Tire;
                }
                catch (Exception exception23)
                {
                    writer.Write(exception23.ToString());
                }
                try
                {
                    ed.RaceLimitLaps = cr.Event[0].Value[0].Events[0].Race.Race_Limit_Laps;
                }
                catch (Exception exception24)
                {
                    writer.Write(exception24.ToString());
                }
                try
                {
                    ed.RaceLimitMinutes = cr.Event[0].Value[0].Events[0].Race.Race_Limit_Minute;
                }
                catch (Exception exception25)
                {
                    writer.Write(exception25.ToString());
                }
                try
                {
                    ed.PitConstraint = cr.Event[0].Value[0].Events[0].Race.Pit_Constraint;
                }
                catch (Exception exception26)
                {
                    writer.Write(exception26.ToString());
                }
                try
                {
                    if (!string.IsNullOrEmpty(cr.Event[0].Value[0].Events[0].Race.Need_Compound_Use))
                    {
                        ed.NeedCompoundUse = cr.Event[0].Value[0].Events[0].Race.Need_Compound_Use;
                    }
                }
                catch (Exception exception27)
                {
                    writer.Write(exception27.ToString());
                }
                try
                {
                    ed.LimitFuelCapacity = cr.Event[0].Value[0].Events[0].Race.Limit_Fuel_Capacity;
                }
                catch (Exception exception28)
                {
                    writer.Write(exception28.ToString());
                }
                try
                {
                    ed.BoardId = cr.Event[0].Value[0].Events[0].Ranking.Board_Id;
                }
                catch (Exception exception29)
                {
                    writer.Write(exception29.ToString());
                }
                try
                {
                    ed.LimitTireF = cr.Event[0].Value[0].Events[0].Regulation.Limit_Tire_F;
                }
                catch (Exception exception30)
                {
                    writer.Write(exception30.ToString());
                }
                try
                {
                    ed.NeedTireF = cr.Event[0].Value[0].Events[0].Regulation.Need_Tire_F;
                }
                catch (Exception exception31)
                {
                    writer.Write(exception31.ToString());
                }
                try
                {
                    ed.UseBop = cr.Event[0].Value[0].Events[0].Regulation.Use_Bop;
                }
                catch (Exception exception32)
                {
                    writer.Write(exception32.ToString());
                }
                try
                {
                    ed.Tuning = cr.Event[0].Value[0].Events[0].Regulation.Tuning;
                }
                catch (Exception exception33)
                {
                    writer.Write(exception33.ToString());
                }
                try
                {
                    if (!string.IsNullOrEmpty(cr.Event[0].Value[0].Events[0].Regulation.Need_Driver_Class))
                    {
                        ed.NeedDriverClass = cr.Event[0].Value[0].Events[0].Regulation.Need_Driver_Class;
                    }
                }
                catch (Exception exception34)
                {
                    writer.Write(exception34.ToString());
                }
                try
                {
                    if (!string.IsNullOrEmpty(cr.Event[0].Value[0].Events[0].Regulation.Car_Category_Types[0]))
                    {
                        ed.CarCategoryTypes = cr.Event[0].Value[0].Events[0].Regulation.Car_Category_Types[0];
                    }
                }
                catch (Exception exception35)
                {
                    writer.Write(exception35.ToString());
                }
                try
                {
                    if (!string.IsNullOrEmpty(cr.Event[0].Value[0].Events[0].Regulation.Cars))
                    {
                        ed.Cars = cr.Event[0].Value[0].Events[0].Regulation.Cars;
                    }
                }
                catch (Exception exception36)
                {
                    writer.Write(exception36.ToString());
                }
                try
                {
                    ed.CarsCount = cr.Event[0].Value[0].Events[0].Regulation.Cars_Count;
                }
                catch (Exception exception37)
                {
                    writer.Write(exception37.ToString());
                }
                try
                {
                    ed.RefuelingSpeed = cr.Event[0].Value[0].Events[0].Refueling_Speed;
                }
                catch (Exception exception38)
                {
                    writer.Write(exception38.ToString());
                }
                try
                {
                    if (!string.IsNullOrEmpty(cr.Event[0].Value[0].Tracks[0].Course_Code))
                    {
                        ed.CourseCode = cr.Event[0].Value[0].Tracks[0].Course_Code;
                    }
                }
                catch (Exception exception39)
                {
                    writer.Write(exception39.ToString());
                }
                try
                {
                    ed.WeatherId = cr.Event[0].Value[0].Tracks[0].WeatherList[0].Weather_Id;
                }
                catch (Exception exception40)
                {
                    writer.Write(exception40.ToString());
                }
            }
            return ed;
        }
    }
}
