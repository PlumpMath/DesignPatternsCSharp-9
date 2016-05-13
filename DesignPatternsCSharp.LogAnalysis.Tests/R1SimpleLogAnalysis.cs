using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace DesignPatternsCSharp.UserLogAnalysis.Tests
{
    [TestClass]
    public class R1SimpleLogAnalysis
    {
        [TestMethod]
        public void TestMethod1()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            LogRecord record1 = new LogRecord(
            new DateTime(2016,05,13,14,0,0),
            new DateTime(2016, 05, 13, 16, 0, 0)
            );
        
            List<LogRecord> records = new List<LogRecord>();
            records.Add(record1);
            List<LogRecord> analyzedRecords = analyzer.analyze(records);
        }
    }
}
