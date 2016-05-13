using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DesignPatternsCSharp.LogAnalysis
{
    public class LogAnalyzer
    {
        public List<LogRecord> analyze(List<LogRecord> logs)
        {
            List<LogRecord> analyzedLogs = new List<LogRecord>();
            foreach(LogRecord record in logs)
            {
                DateTime from = record.From;
                DateTime to = record.To;
                int fromHour = 13;
                int toHour = 17;
                if (to.Hour <= fromHour || from.Hour >= toHour)
                    continue;
                LogRecord newLogRecord;
                if (from.Hour >= fromHour && to.Hour <= toHour)
                {
                    newLogRecord = new LogRecord(from, to);
                }
                else
                {
                    DateTime newFrom;
                    DateTime newTo;

                    if (fromHour >= from.Hour)
                        newFrom = new DateTime(from.Year, from.Month, from.Day, fromHour, 0, 0);
                    else
                        newFrom = from;

                    if (toHour <= to.Hour)
                        newTo = new DateTime(from.Year, from.Month, from.Day, toHour, 0, 0);
                    else
                        newTo = to;
                    newLogRecord = new LogRecord(newFrom, newTo);
                }
                analyzedLogs.Add(newLogRecord);
            }
            return analyzedLogs;
        }
    }
}