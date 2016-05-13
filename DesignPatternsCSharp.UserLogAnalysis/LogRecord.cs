using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsCSharp.UserLogAnalysis
{
    public class LogRecord
    {
        public DateTime From { get; private set; }
        public DateTime To { get; private set; }


        public LogRecord(DateTime from,DateTime to)
        {
            this.From = from;
            this.To = to;
        }
    }
}