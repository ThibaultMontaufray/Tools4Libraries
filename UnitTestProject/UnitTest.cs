using NUnit.Framework;
using System;
using Tools4Libraries;
using System.Drawing;
using System.Windows.Forms;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void TestUTRuns()
        {
            Assert.IsTrue(true);
        }
        //[Test]
        //public void Test_Tools4Lib_creationParamFile()
        //{
        //    try
        //    {
        //        var v = Params.CommunicationMailLogin;
        //        Assert.IsTrue(true);
        //    }
        //    catch (Exception exp)
        //    {
        //        Assert.Fail(exp.Message);
        //    }
        //}
        //[Test]
        //public void Test_Tools4Lib_params_data_communication()
        //{
        //    try
        //    {
        //        string ret;
        //        ret = Params.CommunicationMailLogin;
        //        ret = Params.CommunicationMailPassword;
        //        ret = Params.CommunicationMailSmtpHost;
        //        ret = Params.CommunicationMailSmtpPort;

        //        ret = Params.CommunicationSlackAccount;
        //        ret = Params.CommunicationSlackToken;
        //        ret = Params.CommunicationSlackTopic;
        //        ret = Params.CommunicationSlackUrl;
        //        Assert.IsTrue(true);
        //    }
        //    catch (Exception exp)
        //    {
        //        Assert.Fail(exp.Message);
        //    }
        //}
        //[Test]
        //public void Test_Tools4Lib_params_data_database()
        //{
        //    try
        //    {
        //        string ret;
        //        ret = Params.DatabaseHost;
        //        ret = Params.DatabaseLogin;
        //        ret = Params.DatabaseName;
        //        ret = Params.DatabasePassword;
        //        Assert.IsTrue(true);
        //    }
        //    catch (Exception exp)
        //    {
        //        Assert.Fail(exp.Message);
        //    }
        //}
        //[Test]
        //public void Test_Tools4Lib_params_deployer()
        //{
        //    try
        //    {
        //        string ret;
        //        ret = Params.DockerHost;
        //        ret = Params.DockerLogin;
        //        ret = Params.DockerPassword;

        //        ret = Params.GithubHost;
        //        ret = Params.GithubLogin;
        //        ret = Params.GithubPassword;

        //        ret = Params.JenkinsHost;
        //        ret = Params.JenkinsLogin;
        //        ret = Params.JenkinsPassword;

        //        ret = Params.JiraHost;
        //        ret = Params.JiraLogin;
        //        ret = Params.JiraPassword;

        //        ret = Params.SonarHost;
        //        ret = Params.SonarLogin;
        //        ret = Params.SonarPassword;

        //        ret = Params.TeamCityHost;
        //        ret = Params.TeamCityLogin;
        //        ret = Params.TeamCityPassword;
        //        Assert.IsTrue(true);
        //    }
        //    catch (Exception exp)
        //    {
        //        Assert.Fail(exp.Message);
        //    }
        //}
        //[Test]
        //public void Test_Tools4Lib_params_logistique()
        //{
        //    try
        //    {
        //        string ret;
        //        ret = Params.LogisticSncfToken;
        //        Assert.IsTrue(true);
        //    }
        //    catch (Exception exp)
        //    {
        //        Assert.Fail(exp.Message);
        //    }
        //}
        //[Test]
        //public void Test_Tools4Lib_params_web()
        //{
        //    try
        //    {
        //        string ret;
        //        ret = Params.WebHttpLogin;
        //        ret = Params.WebHttpPassword;
        //        ret = Params.WebProxyHost;
        //        ret = Params.WebProxyLogin;
        //        ret = Params.WebProxyPassword;
        //        ret = Params.WebProxyPort;
        //        Assert.IsTrue(true);
        //    }
        //    catch (Exception exp)
        //    {
        //        Assert.Fail(exp.Message);
        //    }
        //}
        //[Test]
        //public void Test_Tools4Lib_custom_window()
        //{
        //    try
        //    {
        //        window_black wb = new window_black();
        //        window_classic wc = new window_classic();
        //        window_dialog wd = new window_dialog();
        //        window_jarvis wj = new window_jarvis();
        //        window_popup wp = new window_popup();
        //        window_tile_postit wtp = new window_tile_postit();
        //        window_tile_round_border wt = new window_tile_round_border();

        //        Assert.IsTrue(true);
        //    }
        //    catch (Exception exp)
        //    {
        //        Assert.Fail(exp.Message);
        //    }
        //}
        //[Test]
        //public void Test_Tools4Lib_ressource16()
        //{
        //    try
        //    {
        //        var v1 = Tools4Libraries.Resources.ResourceIconSet16Default.arrow_down;
        //        var v2 = Tools4Libraries.Resources.ResourceIconSet16Default.bullet_red;

        //        Assert.IsTrue(true);
        //    }
        //    catch (Exception exp)
        //    {
        //        Assert.Fail(exp.Message);
        //    }
        //}
        //[Test]
        //public void Test_Tools4Lib_ressource32()
        //{
        //    try
        //    {
        //        var v1 = Tools4Libraries.Resources.ResourceIconSet32Default.arrow_down;
        //        var v2 = Tools4Libraries.Resources.ResourceIconSet32Default.bullet_red;

        //        Assert.IsTrue(true);
        //    }
        //    catch (Exception exp)
        //    {
        //        Assert.Fail(exp.Message);
        //    }
        //}
        //[Test]
        //public void Test_Tools4Lib_log()
        //{
        //    try
        //    {
        //        Log.LogLevel = 5;

        //        Log.write("[ DEB : 0001 ] test log debug.");
        //        Log.write("[ INF : 0002 ] test log info.");
        //        Log.write("[ WRN : 0003 ] test log warning.");
        //        Log.write("[ ERR : 0004 ] test log error.");
        //        Log.write("[ CRT : 0005 ] test log critical.");
        //        Log.write("[ EMY : 0006 ] test log emergency.");
        //        Log.write("[ OTH : 0007 ] test log other.");
                
        //        Assert.IsTrue(true);
        //    }
        //    catch (Exception exp)
        //    {
        //        Assert.Fail(exp.Message);
        //    }
        //}
    }
}
