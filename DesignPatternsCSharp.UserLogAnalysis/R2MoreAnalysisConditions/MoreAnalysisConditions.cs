using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.UserLogAnalysis
{
    public class MoreAnalysisConditions
    {
        public List<LogRecord> analyze(List<LogRecord> logs)
        {
            List<LogRecord> analyzedLogs = new List<LogRecord>();
            List<Condition> conditions = new List<Condition>();
            conditions.Add(new Condition(13, 17));
            conditions.Add(new Condition(19, 22));
            foreach (LogRecord record in logs)
            {
               foreach(Condition condition in conditions)
                {
                    condition.analyze(record,analyzedLogs);
                }
            }
            return analyzedLogs;
        }
    }
}
