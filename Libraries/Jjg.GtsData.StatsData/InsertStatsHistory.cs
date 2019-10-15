using System;
using Jjg.GtsData.Common;

namespace Jjg.GtsData.StatsData
{
	public class InsertStatsHistory
	{
        public void Insert(StatHistoryDetail history, long profileId)
        {
            string[] stats1;
            int i;
            long year = long.Parse(history.Year);
            long month = long.Parse(history.Month);
            long index = 1;
            try
            {
                if (history.Stats1 != null)
                {
                    try
                    {
                        stats1 = history.Stats1;
                        for (i = 0; i < stats1.Length; i++)
                        {
                            string statValue = stats1[i];
                            if (!statValue.Trim().Equals("0"))
                            {
                                InsertStats insertStats = new InsertStats();
                                insertStats.Insert(profileId, 1, year, month, index, long.Parse(statValue));
                            }
                            index += 1;
                        }
                    }
                    catch (Exception exception)
                    {
                        new EventWriter().Write(exception.ToString());
                    }
                }
            }
            catch (Exception exception1)
            {
                new EventWriter().Write(exception1.ToString());
            }
            try
            {
                if (history.Stats2 != null)
                {
                    try
                    {
                        index = 1;
                        stats1 = history.Stats2;
                        for (i = 0; i < stats1.Length; i++)
                        {
                            string statValue = stats1[i];
                            if (!statValue.Trim().Equals("0"))
                            {
                                InsertStats insertStats = new InsertStats();
                                insertStats.Insert(profileId, 2, year, month, index, long.Parse(statValue));
                            }
                            index += 1;
                        }
                    }
                    catch (Exception exception2)
                    {
                        new EventWriter().Write(exception2.ToString());
                    }
                }
            }
            catch (Exception exception3)
            {
                new EventWriter().Write(exception3.ToString());
            }
            try
            {
                if (history.Stats3 != null)
                {
                    try
                    {
                        index = 1;
                        stats1 = history.Stats3;
                        for (i = 0; i < stats1.Length; i++)
                        {
                            string statValue = stats1[i];
                            if (!statValue.Trim().Equals("0"))
                            {
                                InsertStats insertStats = new InsertStats();
                                insertStats.Insert(profileId, 3, year, month, index, long.Parse(statValue));
                            }
                            index += 1;
                        }
                    }
                    catch (Exception exception4)
                    {
                        new EventWriter().Write(exception4.ToString());
                    }
                }
            }
            catch (Exception exception5)
            {
                new EventWriter().Write(exception5.ToString());
            }
            try
            {
                if (history.Stats4 != null)
                {
                    try
                    {
                        index = 1;
                        stats1 = history.Stats4;
                        for (i = 0; i < stats1.Length; i++)
                        {
                            string statValue = stats1[i];
                            if (!statValue.Trim().Equals("0"))
                            {
                                InsertStats insertStats = new InsertStats();
                                insertStats.Insert(profileId, 4, year, month, index, long.Parse(statValue));
                            }
                            index += 1;
                        }
                    }
                    catch (Exception exception6)
                    {
                        new EventWriter().Write(exception6.ToString());
                    }
                }
            }
            catch (Exception exception7)
            {
                new EventWriter().Write(exception7.ToString());
            }
            try
            {
                if (history.Stats5 != null)
                {
                    try
                    {
                        index = 1;
                        stats1 = history.Stats5;
                        for (i = 0; i < stats1.Length; i++)
                        {
                            string statValue = stats1[i];
                            if (!statValue.Trim().Equals("0"))
                            {
                                InsertStats insertStats = new InsertStats();
                                insertStats.Insert(profileId, 5, year, month, index, long.Parse(statValue));
                            }
                            index += 1;
                        }
                    }
                    catch (Exception exception8)
                    {
                        new EventWriter().Write(exception8.ToString());
                    }
                }
            }
            catch (Exception exception9)
            {
                new EventWriter().Write(exception9.ToString());
            }
            try
            {
                if (history.Stats6 != null)
                {
                    try
                    {
                        index = 1;
                        stats1 = history.Stats6;
                        for (i = 0; i < stats1.Length; i++)
                        {
                            string statValue = stats1[i];
                            if (!statValue.Trim().Equals("0"))
                            {
                                InsertStats insertStats = new InsertStats();
                                insertStats.Insert(profileId, 6, year, month, index, long.Parse(statValue));
                            }
                            index += 1;
                        }
                    }
                    catch (Exception exception10)
                    {
                        new EventWriter().Write(exception10.ToString());
                    }
                }
            }
            catch (Exception exception11)
            {
                new EventWriter().Write(exception11.ToString());
            }
            try
            {
                if (history.Stats7 != null)
                {
                    try
                    {
                        index = 1;
                        stats1 = history.Stats7;
                        for (i = 0; i < stats1.Length; i++)
                        {
                            string statValue = stats1[i];
                            if (!statValue.Trim().Equals("0"))
                            {
                                InsertStats insertStats = new InsertStats();
                                insertStats.Insert(profileId, 7, year, month, index, long.Parse(statValue));
                            }
                            index += 1;
                        }
                    }
                    catch (Exception exception12)
                    {
                        new EventWriter().Write(exception12.ToString());
                    }
                }
            }
            catch (Exception exception13)
            {
                new EventWriter().Write(exception13.ToString());
            }
            try
            {
                if (history.Stats11 != null)
                {
                    try
                    {
                        index = 1;
                        stats1 = history.Stats11;
                        for (i = 0; i < stats1.Length; i++)
                        {
                            string statValue = stats1[i];
                            if (!statValue.Trim().Equals("0"))
                            {
                                InsertStats insertStats = new InsertStats();
                                insertStats.Insert(profileId, 11, year, month, index, long.Parse(statValue));
                            }
                            index += 1;
                        }
                    }
                    catch (Exception exception14)
                    {
                        new EventWriter().Write(exception14.ToString());
                    }
                }
            }
            catch (Exception exception15)
            {
                new EventWriter().Write(exception15.ToString());
            }
            try
            {
                if (history.Stats12 != null)
                {
                    try
                    {
                        index = 1;
                        stats1 = history.Stats12;
                        for (i = 0; i < stats1.Length; i++)
                        {
                            string statValue = stats1[i];
                            if (!statValue.Trim().Equals("0"))
                            {
                                InsertStats insertStats = new InsertStats();
                                insertStats.Insert(profileId, 12, year, month, index, long.Parse(statValue));
                            }
                            index += 1;
                        }
                    }
                    catch (Exception exception16)
                    {
                        new EventWriter().Write(exception16.ToString());
                    }
                }
            }
            catch (Exception exception17)
            {
                new EventWriter().Write(exception17.ToString());
            }
            try
            {
                if (history.Stats13 != null)
                {
                    try
                    {
                        index = 1;
                        stats1 = history.Stats13;
                        for (i = 0; i < stats1.Length; i++)
                        {
                            string statValue = stats1[i];
                            if (!statValue.Trim().Equals("0"))
                            {
                                InsertStats insertStats = new InsertStats();
                                insertStats.Insert(profileId, 13, year, month, index, long.Parse(statValue));
                            }
                            index += 1;
                        }
                    }
                    catch (Exception exception18)
                    {
                        new EventWriter().Write(exception18.ToString());
                    }
                }
            }
            catch (Exception exception19)
            {
                new EventWriter().Write(exception19.ToString());
            }
        }
    }
}
