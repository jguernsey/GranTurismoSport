using System;
using System.Data;
using System.Data.SqlClient;
using Jjg.GtsData.Common;

namespace Jjg.GtsData.StatsData
{
	public class InsertEventDetail
	{
        public long Insert(EventDetail ed)
        {
            long detailId = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConn.Get()))
                {
                    SqlCommand cmd = new SqlCommand("GTS_EventDetails_Insert", conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandTimeout = 0
                    };
                    cmd.Parameters.Add("@RegionId", SqlDbType.BigInt).Value = ed.RegionId;
                    cmd.Parameters.Add("@EventId", SqlDbType.BigInt).Value = ed.EventId;
                    cmd.Parameters.Add("@ChampionshipId", SqlDbType.BigInt).Value = ed.ChampionshipId;
                    cmd.Parameters.Add("@SeasonId", SqlDbType.BigInt).Value = ed.SeasonId;
                    cmd.Parameters.Add("@RoundId", SqlDbType.BigInt).Value = ed.RoundId;
                    cmd.Parameters.Add("@ChampionshipColor", SqlDbType.NVarChar).Value = ed.ChampionshipColor;
                    cmd.Parameters.Add("@GameMode", SqlDbType.NVarChar).Value = ed.GameMode;
                    cmd.Parameters.Add("@EventType", SqlDbType.NVarChar).Value = ed.EventType;
                    cmd.Parameters.Add("@SportsMode", SqlDbType.NVarChar).Value = ed.SportsMode;
                    cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = ed.Title;
                    cmd.Parameters.Add("@OneLineTitle", SqlDbType.NVarChar).Value = ed.OneLineTitle;
                    cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = ed.Description;
                    cmd.Parameters.Add("@RegistrationNotice", SqlDbType.NVarChar).Value = ed.RegistrationNotice;
                    cmd.Parameters.Add("@EventTarget", SqlDbType.NVarChar).Value = ed.EventTarget;
                    cmd.Parameters.Add("@EventRestrict", SqlDbType.NVarChar).Value = ed.EventRestrict;
                    cmd.Parameters.Add("@LogoImagePath", SqlDbType.NVarChar).Value = ed.LogoImagePath;
                    cmd.Parameters.Add("@FlyerImagePath", SqlDbType.NVarChar).Value = ed.FlyerImagePath;
                    cmd.Parameters.Add("@BehaviorDamageType", SqlDbType.NVarChar).Value = ed.BehaviorDamageType;
                    cmd.Parameters.Add("@BehaviorSlipStreamType", SqlDbType.NVarChar).Value = ed.BehaviorSlipStreamType;
                    cmd.Parameters.Add("@BoostLevel", SqlDbType.NVarChar).Value = ed.BoostLevel;
                    cmd.Parameters.Add("@LowMuType", SqlDbType.NVarChar).Value = ed.LowMuType;
                    cmd.Parameters.Add("@EntryMax", SqlDbType.BigInt).Value = ed.EntryMax;
                    cmd.Parameters.Add("@StartType", SqlDbType.NVarChar).Value = ed.StartType;
                    cmd.Parameters.Add("@ConsumeFuel", SqlDbType.BigInt).Value = ed.ConsumeFuel;
                    cmd.Parameters.Add("@ConsumeTire", SqlDbType.BigInt).Value = ed.ConsumeTire;
                    cmd.Parameters.Add("@RaceLimitLaps", SqlDbType.BigInt).Value = ed.RaceLimitLaps;
                    cmd.Parameters.Add("@RaceLimitMinutes", SqlDbType.BigInt).Value = ed.RaceLimitMinutes;
                    cmd.Parameters.Add("@PitConstraint", SqlDbType.BigInt).Value = ed.PitConstraint;
                    cmd.Parameters.Add("@NeedCompoundUse", SqlDbType.NVarChar).Value = ed.NeedCompoundUse;
                    cmd.Parameters.Add("@LimitFuelCapacity", SqlDbType.BigInt).Value = ed.LimitFuelCapacity;
                    cmd.Parameters.Add("@BoardId", SqlDbType.BigInt).Value = ed.BoardId;
                    cmd.Parameters.Add("@LimitTireF", SqlDbType.BigInt).Value = ed.LimitTireF;
                    cmd.Parameters.Add("@NeedTireF", SqlDbType.BigInt).Value = ed.NeedTireF;
                    cmd.Parameters.Add("@UseBOP", SqlDbType.BigInt).Value = ed.UseBop;
                    cmd.Parameters.Add("@Tuning", SqlDbType.BigInt).Value = ed.Tuning;
                    cmd.Parameters.Add("@NeedDriverClass", SqlDbType.NVarChar).Value = ed.NeedDriverClass;
                    cmd.Parameters.Add("@CarCategoryTypes", SqlDbType.NVarChar).Value = ed.CarCategoryTypes;
                    cmd.Parameters.Add("@Cars", SqlDbType.NVarChar).Value = ed.Cars;
                    cmd.Parameters.Add("@CarsCount", SqlDbType.BigInt).Value = ed.CarsCount;
                    cmd.Parameters.Add("@RefuelingSpeed", SqlDbType.BigInt).Value = ed.RefuelingSpeed;
                    cmd.Parameters.Add("@CourseCode", SqlDbType.NVarChar).Value = ed.CourseCode;
                    cmd.Parameters.Add("@WeatherId", SqlDbType.BigInt).Value = ed.WeatherId;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exception)
            {
                EventWriter writer = new EventWriter();
                writer.Write(exception.ToString());

                writer.Write(string.Format(string.Format("RegionId:{0}-EventId:{1}-ChampionshipId:{2}-SeasonId:{3}-RoundId:{4}-ChampionshipColor:{5}-GameMode:{6}-EventType:{7}-SportsMode:{8}-Title:{9}-OneLineTitle:{10}-Description:{11}-RegistrationNotice:{12}-EventTarget:{13}-EventRestrict:{14}-LogoImagePath:{15}-FlyerImagePath:{16}-BehaviorDamageType:{17}-BehaviorSlipStreamType:{18}-BoostLevel:{19}-LowMuType:{20}-EntryMax:{21}-StartType:{22}-ConsumeFuel:{23}-ConsumeTire:{24}-RaceLimitLaps:{25}-RaceLimitMinutes:{26}-PitConstraint:{27}-NeedCompoundUse:{28}-LimitFuelCapacity:{29}-BoardId:{30}-LimitTireF:{31}-NeedTireF:{32}-UseBop:{33}-Tuning:{34}-NeedDriverClass:{35}-CarCategoryTypes:{36}-Cars:{37}-CarsCount:{38}-RefuelingSpeed:{39}-CourseCode:{40}-WeatherId:{41}", ed.RegionId, ed.EventId, ed.ChampionshipId, ed.SeasonId, ed.RoundId, ed.ChampionshipColor, ed.GameMode, ed.EventType, ed.SportsMode, ed.Title, ed.OneLineTitle, ed.Description, ed.RegistrationNotice, ed.EventTarget, ed.EventRestrict, ed.LogoImagePath, ed.FlyerImagePath, ed.BehaviorDamageType, ed.BehaviorSlipStreamType, ed.BoostLevel, ed.LowMuType, ed.EntryMax, ed.StartType, ed.ConsumeFuel, ed.ConsumeTire, ed.RaceLimitLaps, ed.RaceLimitMinutes, ed.PitConstraint, ed.NeedCompoundUse, ed.LimitFuelCapacity, ed.BoardId, ed.LimitTireF, ed.NeedTireF, ed.UseBop, ed.Tuning, ed.NeedDriverClass, ed.CarCategoryTypes, ed.Cars, ed.CarsCount, ed.RefuelingSpeed, ed.CourseCode, ed.WeatherId)));

    }
            return detailId;
        }
    }
}
