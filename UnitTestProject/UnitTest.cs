using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tools4Libraries;
using System.IO;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestUTRuns()
        {
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void TestParamsFile()
        {
            if (!File.Exists(Log.LOGPATH))
            {
                var v = Params.CommunicationSlackUrl;
                Assert.IsTrue(File.Exists(Log.LOGPATH));
            }
            else
            {
                Assert.IsTrue(true);
            }
        }
        [TestMethod]
        public void TestParamsValue()
        {
            try
            {
                var v = Params.CommunicationSlackUrl;
                Assert.IsTrue(!string.IsNullOrEmpty(v));
            }
            catch (Exception exp)
            {
                Assert.Fail(exp.Message);
            }
        }
        [TestMethod]
        public void TestLoggerDebug()
        {
            TestLogger("DEB", "DEBUG", 0);
        }
        [TestMethod]
        public void TestLoggerInformation()
        {
            TestLogger("INF", "INFO", 1);
        }
        [TestMethod]
        public void TestLoggerWarning()
        {
            TestLogger("WRN", "WARNING", 2);
        }
        [TestMethod]
        public void TestLoggerError()
        {
            TestLogger("ERR", "ERROR", 3);
        }
        [TestMethod]
        public void TestLoggerCritical()
        {
            TestLogger("CRT", "CRITICAL", 4);
        }
        [TestMethod]
        public void TestLoggerEmergency()
        {
            TestLogger("EMY", "EMERGENCY", 5);
        }
        [TestMethod]
        public void TestLoggerUnknow()
        {
            TestLogger("#", "UNKNOW", 99);
        }

        #region Methods private
        private void TestLogger(string level, string levelString, int id)
        {
            Log.LogLevel = -1;
            Log.write("123456789 "+ level + " : I'm a seagull");
            string fileText;
            using (StreamReader sr = new StreamReader(Log.LOGPATH)) { fileText = sr.ReadToEnd(); }

            string expectedlog = "<log><DateTime=\"" + DateTime.Now.ToString("yyyyMMdd:HHmmss") + "\"/><Severity=\"" + levelString + "\"/><Level=\""+id+"\"/><EventID=\"123456789\"/><EventText=\"I'm a seagull\"/></log>\r\n";
            if (fileText.EndsWith(expectedlog))
            {
                Assert.IsTrue(true);
            }
            else
            {
                if (fileText.Length > 129) { Assert.IsTrue(false, fileText.Substring(fileText.Length - 128, fileText.Length)); }
                else { Assert.IsTrue(false, "File not ended with the log line. Here is the end of the log file : \"" + fileText + "\" instead of : \"" + expectedlog + "\""); }
            }
        }
        #endregion
    }
}
