using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.UserLogAnalysis
{
    public class Condition
    {
        public int FromHour { get; private set; }
        public int ToHour { get; private set; }

        public Condition(int fromHour,int toHour)
        {
            this.FromHour = fromHour;
            this.ToHour = toHour;
        }

        public void analyze(LogRecord record,List<LogRecord> logRecords)
        {
            DateTime from = record.From;
            DateTime to = record.To;
            int fromHour = this.FromHour;
            int toHour = this.ToHour;
            if (to.Hour <= fromHour || from.Hour >= toHour)
                return;
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
            logRecords.Add(newLogRecord);
        }
    }
}
