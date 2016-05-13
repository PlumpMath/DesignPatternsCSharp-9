using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DesignPatternsCSharp.UserLogAnalysis;

namespace DesignPatternsCSharp.UserLogAnalysis.Tests
{
    [TestClass]
    public class R2MoreAnalysisConditions
    {
        [TestMethod]
        public void TestMethod1()
        {
            MoreAnalysisConditions analyzer = new MoreAnalysisConditions();
            LogRecord record1 = new LogRecord(
            new DateTime(2016,05,13,10,0,0),
            new DateTime(2016, 05, 13,18, 0, 0)
            );
            LogRecord record2 = new LogRecord(
           new DateTime(2016, 05, 14, 10, 0, 0),
           new DateTime(2016, 05, 14, 18, 0, 0)
           );

            LogRecord record3 = new LogRecord(
           new DateTime(2016, 05, 15, 10, 0, 0),
           new DateTime(2016, 05, 15, 18, 0, 0)
           );

            List<LogRecord> records = new List<LogRecord>();
            records.Add(record1);
            records.Add(record2);
            records.Add(record3);
            List<LogRecord> analyzedRecords = analyzer.analyze(records);
        }
    }
}
