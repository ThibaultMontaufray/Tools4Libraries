namespace Tools4Libraries
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Runtime.Serialization.Formatters.Soap;
    using System.Xml;
    using System.Xml.Serialization;

    [Serializable]
    public static class Params
    {
        #region Attribute
        private static string _configFile;
        public static string _webProxyHost;
        public static string _webProxyLogin;
        public static string _webProxyPassword;
        public static string _webProxyPort;
        public static string _webHttpLogin;
        public static string _webHttpPassword;
        public static string _communicationSlackUrl;
        public static string _communicationSlackToken;
        public static string _communicationSlackAccount;
        public static string _communicationSlackTopic;
        public static string _communicationMailLogin;
        public static string _communicationMailPassword;
        public static string _communicationMailSmtpPort;
        public static string _communicationMailSmtpHost;
        public static string _communicationMailSmtpEncryption;
        public static string _communicationMailImapPort;
        public static string _communicationMailImapHost;
        public static string _communicationMailImapEncryption;
        public static string _logisticSncfToken;
        public static string _databaseLogin;
        public static string _databasePassword;
        public static string _databaseHost;
        public static string _databaseName;
        public static string _githubLogin;
        public static string _githubPassword;
        public static string _githubHost;
        public static string _jiraLogin;
        public static string _jiraPassword;
        public static string _jiraHost;
        public static string _sonarLogin;
        public static string _sonarPassword;
        public static string _sonarHost;
        public static string _teamcityLogin;
        public static string _teamcityPassword;
        public static string _teamcityHost;
        public static string _jenkinsLogin;
        public static string _jenkinsPassword;
        public static string _jenkinsHost;
        public static string _dockerLogin;
        public static string _dockerPassword;
        public static string _dockerHost;
        public static string _bitbucketLogin;
        public static string _bitbucketPassword;
        #endregion

        #region Properties
        public static string ConfigFile
        {
            get { return _configFile; }
            set
            {
                _configFile = value;
                LoadXmlParamsFile();
            }
        }
        public static string WebProxyHost { get { return _webProxyHost; } set { _webProxyHost =value; SaveConfig(); } }
        public static string WebProxyLogin { get { return _webProxyLogin; } set { _webProxyLogin =value; SaveConfig(); } }
        public static string WebProxyPassword { get { return _webProxyPassword; } set { _webProxyPassword =value; SaveConfig(); } }
        public static string WebProxyPort { get { return _webProxyPort; } set { _webProxyPort =value; SaveConfig(); } }
        public static string WebHttpLogin { get { return _webHttpLogin; } set { _webHttpLogin =value; SaveConfig(); } }
        public static string WebHttpPassword { get { return _webHttpPassword; } set { _webHttpPassword =value; SaveConfig(); } }
        public static string CommunicationSlackUrl { get { return _communicationSlackUrl; } set { _communicationSlackUrl =value; SaveConfig(); } }
        public static string CommunicationSlackAccount { get { return _communicationSlackAccount; } set { _communicationSlackAccount =value; SaveConfig(); } }
        public static string CommunicationSlackTopic { get { return _communicationSlackTopic; } set { _communicationSlackTopic =value; SaveConfig(); } }
        public static string CommunicationSlackToken { get { return _communicationSlackToken; } set { _communicationSlackToken =value; SaveConfig(); } }
        public static string CommunicationMailLogin { get { return _communicationMailLogin; } set { _communicationMailLogin = value; SaveConfig(); } }
        public static string CommunicationMailPassword { get { return _communicationMailPassword; } set { _communicationMailPassword =value; SaveConfig(); } }
        public static string CommunicationMailSmtpPort { get { return _communicationMailSmtpPort; } set { _communicationMailSmtpPort = value; SaveConfig(); } }
        public static string CommunicationMailSmtpHost { get { return _communicationMailSmtpHost; } set { _communicationMailSmtpHost = value; SaveConfig(); } }
        public static string CommunicationMailSmtpEncryption { get { return _communicationMailSmtpEncryption; } set { _communicationMailSmtpEncryption = value; SaveConfig(); } }
        public static string CommunicationMailImapPort { get { return _communicationMailImapPort; } set { _communicationMailImapPort = value; SaveConfig(); } }
        public static string CommunicationMailImapHost { get { return _communicationMailImapHost; } set { _communicationMailImapHost = value; SaveConfig(); } }
        public static string CommunicationMailImapEncryption { get { return _communicationMailImapEncryption; } set { _communicationMailImapEncryption = value; SaveConfig(); } }
        public static string LogisticSncfToken { get { return _logisticSncfToken; } set { _logisticSncfToken =value; SaveConfig(); } }
        public static string DatabaseHost { get { return _databaseHost; } set { _databaseHost =value; SaveConfig(); } }
        public static string DatabaseLogin { get { return _databaseLogin; } set { _databaseLogin =value; SaveConfig(); } }
        public static string DatabaseName { get { return _databaseName; } set { _databaseName =value; SaveConfig(); } }
        public static string DatabasePassword { get { return _databasePassword; } set { _databasePassword =value; SaveConfig(); } }
        public static string GithubHost { get { return _githubHost; } set { _githubHost =value; SaveConfig(); } }
        public static string GithubLogin { get { return _githubLogin; } set { _githubLogin =value; SaveConfig(); } }
        public static string GithubPassword { get { return _githubPassword; } set { _githubPassword =value; SaveConfig(); } }
        public static string SonarHost { get { return _sonarHost; } set { _sonarHost =value; SaveConfig(); } }
        public static string SonarLogin { get { return _sonarLogin; } set { _sonarLogin =value; SaveConfig(); } }
        public static string SonarPassword { get { return _sonarPassword; } set { _sonarPassword =value; SaveConfig(); } }
        public static string JiraHost { get { return _jiraHost; } set { _jiraHost =value; SaveConfig(); } }
        public static string JiraLogin { get { return _jiraLogin; } set { _jiraLogin =value; SaveConfig(); } }
        public static string JiraPassword { get { return _jiraPassword; } set { _jiraPassword =value; SaveConfig(); } }
        public static string TeamCityHost { get { return _teamcityHost; } set { _teamcityHost =value; SaveConfig(); } }
        public static string TeamCityLogin { get { return _teamcityLogin; } set { _teamcityLogin =value; SaveConfig(); } }
        public static string TeamCityPassword { get { return _teamcityPassword; } set { _teamcityPassword =value; SaveConfig(); } }
        public static string JenkinsHost { get { return _jenkinsHost; } set { _jenkinsHost =value; SaveConfig(); } }
        public static string JenkinsLogin { get { return _jenkinsLogin; } set { _jenkinsLogin =value; SaveConfig(); } }
        public static string JenkinsPassword { get { return _jenkinsPassword; } set { _jenkinsPassword =value; SaveConfig(); } }
        public static string DockerHost { get { return _dockerHost; } set { _dockerHost =value; SaveConfig(); } }
        public static string DockerLogin { get { return _dockerLogin; } set { _dockerLogin =value; SaveConfig(); } }
        public static string DockerPassword { get { return _dockerPassword; } set { _dockerPassword =value; SaveConfig(); } }
        public static string BitbucketLogin { get { return _bitbucketLogin; } set { _bitbucketLogin =value; SaveConfig(); } }
        public static string BitbucketPassword { get { return _bitbucketPassword; } set { _bitbucketPassword =value; SaveConfig(); } }
        #endregion

        #region Constructor
        static Params()
        {
            LoadXmlParamsFile();
        }
        #endregion
        
        #region Methods private
        public static void SaveConfig()
        {
            try
            {
                FieldInfo[] fields = typeof(Params).GetFields(BindingFlags.Static | BindingFlags.Public);
                object[,] a = new object[fields.Length, 2];
                int i = 0;
                foreach (FieldInfo field in fields)
                {
                    a[i, 0] = field.Name;
                    a[i, 1] = field.GetValue(null);
                    i++;
                };
                Stream f = File.Open(_configFile, FileMode.Create);
                SoapFormatter formatter = new SoapFormatter();
                formatter.Serialize(f, a);
                f.Close();
            }
            catch
            {
            }
        }
        private static void LoadXmlParamsFile()
        {
            if (File.Exists(_configFile))
            {
                try
                {
                    FieldInfo[] fields = typeof(Params).GetFields(BindingFlags.Static | BindingFlags.Public);
                    object[,] a;
                    Stream f = File.Open(_configFile, FileMode.Open);
                    SoapFormatter formatter = new SoapFormatter();
                    a = formatter.Deserialize(f) as object[,];
                    f.Close();
                    if (a.GetLength(0) != fields.Length) return; // false
                    int i = 0;
                    foreach (FieldInfo field in fields)
                    {
                        if (field.Name == (a[i, 0] as string))
                        {
                            field.SetValue(null, a[i, 1]);
                        }
                        i++;
                    };
                }
                catch
                {
                }
            }
        }
        #endregion
    }
}
