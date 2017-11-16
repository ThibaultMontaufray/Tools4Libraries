//namespace Tools4Libraries
//{
//    using System.IO;
//    using System.Xml;

//    public static class Params
//    {
//        #region Attribute
//        private static string _configFile;
//        private static string _webProxyHost;
//        private static string _webProxyLogin;
//        private static string _webProxyPassword;
//        private static string _webProxyPort;
//        private static string _webHttpLogin;
//        private static string _webHttpPassword;
//        private static string _communicationSlackUrl;
//        private static string _communicationSlackToken;
//        private static string _communicationSlackAccount;
//        private static string _communicationSlackTopic;
//        private static string _communicationMailLogin;
//        private static string _communicationMailPassword;
//        private static string _communicationMailSmtpPort;
//        private static string _communicationMailSmtpHost;
//        private static string _communicationMailSmtpEncryption;
//        private static string _communicationMailImapPort;
//        private static string _communicationMailImapHost;
//        private static string _communicationMailImapEncryption;
//        private static string _logisticSncfToken;
//        private static string _databaseLogin;
//        private static string _databasePassword;
//        private static string _databaseHost;
//        private static string _databaseName;
//        private static string _githubLogin;
//        private static string _githubPassword;
//        private static string _githubHost;
//        private static string _jiraLogin;
//        private static string _jiraPassword;
//        private static string _jiraHost;
//        private static string _sonarLogin;
//        private static string _sonarPassword;
//        private static string _sonarHost;
//        private static string _teamcityLogin;
//        private static string _teamcityPassword;
//        private static string _teamcityHost;
//        private static string _jenkinsLogin;
//        private static string _jenkinsPassword;
//        private static string _jenkinsHost;
//        private static string _dockerLogin;
//        private static string _dockerPassword;
//        private static string _dockerHost;
//        private static string _bitbucketLogin;
//        private static string _bitbucketPassword;
//        #endregion

//        #region Properties
//        public static string ConfigFile
//        {
//            get { return _configFile; }
//            set
//            {
//                _configFile = value;
//                LoadXmlParamsFile();
//            }
//        }
//        public static string WebProxyHost { get { return _webProxyHost; } set { _webProxyHost =value; SaveConfig(); } }
//        public static string WebProxyLogin { get { return _webProxyLogin; } set { _webProxyLogin =value; SaveConfig(); } }
//        public static string WebProxyPassword { get { return _webProxyPassword; } set { _webProxyPassword =value; SaveConfig(); } }
//        public static string WebProxyPort { get { return _webProxyPort; } set { _webProxyPort =value; SaveConfig(); } }
//        public static string WebHttpLogin { get { return _webHttpLogin; } set { _webHttpLogin =value; SaveConfig(); } }
//        public static string WebHttpPassword { get { return _webHttpPassword; } set { _webHttpPassword =value; SaveConfig(); } }
//        public static string CommunicationSlackUrl { get { return _communicationSlackUrl; } set { _communicationSlackUrl =value; SaveConfig(); } }
//        public static string CommunicationSlackAccount { get { return _communicationSlackAccount; } set { _communicationSlackAccount =value; SaveConfig(); } }
//        public static string CommunicationSlackTopic { get { return _communicationSlackTopic; } set { _communicationSlackTopic =value; SaveConfig(); } }
//        public static string CommunicationSlackToken { get { return _communicationSlackToken; } set { _communicationSlackToken =value; SaveConfig(); } }
//        public static string CommunicationMailLogin { get { return _communicationMailLogin; } set { _communicationMailLogin = value; SaveConfig(); } }
//        public static string CommunicationMailPassword { get { return _communicationMailPassword; } set { _communicationMailPassword =value; SaveConfig(); } }
//        public static string CommunicationMailSmtpPort { get { return _communicationMailSmtpPort; } set { _communicationMailSmtpPort = value; SaveConfig(); } }
//        public static string CommunicationMailSmtpHost { get { return _communicationMailSmtpHost; } set { _communicationMailSmtpHost = value; SaveConfig(); } }
//        public static string CommunicationMailSmtpEncryption { get { return _communicationMailSmtpEncryption; } set { _communicationMailSmtpEncryption = value; SaveConfig(); } }
//        public static string CommunicationMailImapPort { get { return _communicationMailImapPort; } set { _communicationMailImapPort = value; SaveConfig(); } }
//        public static string CommunicationMailImapHost { get { return _communicationMailImapHost; } set { _communicationMailImapHost = value; SaveConfig(); } }
//        public static string CommunicationMailImapEncryption { get { return _communicationMailImapEncryption; } set { _communicationMailImapEncryption = value; SaveConfig(); } }
//        public static string LogisticSncfToken { get { return _logisticSncfToken; } set { _logisticSncfToken =value; SaveConfig(); } }
//        public static string DatabaseHost { get { return _databaseHost; } set { _databaseHost =value; SaveConfig(); } }
//        public static string DatabaseLogin { get { return _databaseLogin; } set { _databaseLogin =value; SaveConfig(); } }
//        public static string DatabaseName { get { return _databaseName; } set { _databaseName =value; SaveConfig(); } }
//        public static string DatabasePassword { get { return _databasePassword; } set { _databasePassword =value; SaveConfig(); } }
//        public static string GithubHost { get { return _githubHost; } set { _githubHost =value; SaveConfig(); } }
//        public static string GithubLogin { get { return _githubLogin; } set { _githubLogin =value; SaveConfig(); } }
//        public static string GithubPassword { get { return _githubPassword; } set { _githubPassword =value; SaveConfig(); } }
//        public static string SonarHost { get { return _sonarHost; } set { _sonarHost =value; SaveConfig(); } }
//        public static string SonarLogin { get { return _sonarLogin; } set { _sonarLogin =value; SaveConfig(); } }
//        public static string SonarPassword { get { return _sonarPassword; } set { _sonarPassword =value; SaveConfig(); } }
//        public static string JiraHost { get { return _jiraHost; } set { _jiraHost =value; SaveConfig(); } }
//        public static string JiraLogin { get { return _jiraLogin; } set { _jiraLogin =value; SaveConfig(); } }
//        public static string JiraPassword { get { return _jiraPassword; } set { _jiraPassword =value; SaveConfig(); } }
//        public static string TeamCityHost { get { return _teamcityHost; } set { _teamcityHost =value; SaveConfig(); } }
//        public static string TeamCityLogin { get { return _teamcityLogin; } set { _teamcityLogin =value; SaveConfig(); } }
//        public static string TeamCityPassword { get { return _teamcityPassword; } set { _teamcityPassword =value; SaveConfig(); } }
//        public static string JenkinsHost { get { return _jenkinsHost; } set { _jenkinsHost =value; SaveConfig(); } }
//        public static string JenkinsLogin { get { return _jenkinsLogin; } set { _jenkinsLogin =value; SaveConfig(); } }
//        public static string JenkinsPassword { get { return _jenkinsPassword; } set { _jenkinsPassword =value; SaveConfig(); } }
//        public static string DockerHost { get { return _dockerHost; } set { _dockerHost =value; SaveConfig(); } }
//        public static string DockerLogin { get { return _dockerLogin; } set { _dockerLogin =value; SaveConfig(); } }
//        public static string DockerPassword { get { return _dockerPassword; } set { _dockerPassword =value; SaveConfig(); } }
//        public static string BitbucketLogin { get { return _bitbucketLogin; } set { _bitbucketLogin =value; SaveConfig(); } }
//        public static string BitbucketPassword { get { return _bitbucketPassword; } set { _bitbucketPassword =value; SaveConfig(); } }
//        #endregion

//        #region Constructor
//        static Params()
//        {
//            LoadXmlParamsFile();
//        }
//        #endregion
        
//        #region Methods private
//        private static void SaveConfig()
//        {
//            //File.Create(CONFIGFILE);
//            using (StreamWriter sw = new StreamWriter(_configFile, false))
//            {
//                sw.WriteLine(string.Format(@"<configmanager>
//	<web>
//		<proxy>
//			<host>{0}</host>
//			<login>{1}</login>
//			<password>{2}</password>
//			<port>{3}</port>
//		</proxy>
//		<http>
//			<login>{4}</login>
//			<password>{5}</password>
//		</http>
//	</web>
//	<communication>
//		<slack>
//			<token>{6}</token>
//			<url>{7}</url>
//			<account>{8}</account>
//			<topic>{9}</topic>
//		</slack>
//		<mail>
//			<login>{10}</login>
//			<password>{11}</password>
//			<smtp port='{12}' host='{13}' encrypt='{14}' />
//			<imap port='{15}' host='{16}' encrypt='{17}' />
//		</mail>
//	</communication>
//	<logistic>
//		<sncf>
//			<key>{18}</key>
//		</sncf>
//	</logistic>
//	<database>
//		<host>{19}</host>
//		<login>{20}</login>
//		<password>{21}</password>
//		<name>{22}</name>
//	</database>
//	<github>
//		<host>{23}</host>
//		<login>{24}</login>
//		<password>{21}</password>
//	</github>
//	<jira>
//		<host>{25}</host>
//		<login>{26}</login>
//		<password>{27}</password>
//	</jira>
//	<sonar>
//		<host>{28}</host>
//		<login>{29}</login>
//		<password>{30}</password>
//	</sonar>
//	<teamcity>
//		<host>{31}</host>
//		<login>{32}</login>
//		<password>{33}</password>
//	</teamcity>
//	<jenkins>
//		<host>{34}</host>
//		<login>{35}</login>
//		<password>{36}</password>
//	</jenkins>
//	<docker>
//		<host>{37}</host>
//		<login>{38}</login>
//		<password>{39}</password>
//	</docker>
//	<bitbucket>
//		<login>{40}</login>
//		<password>{41}</password>
//	</bitbucket>
//</configmanager>
//                ", _webProxyHost, _webProxyLogin, _webProxyPassword, _webProxyPort, _webHttpLogin, _webHttpPassword, _communicationSlackUrl, _communicationSlackToken, _communicationSlackAccount, _communicationSlackTopic, _communicationMailLogin, _communicationMailPassword, _communicationMailSmtpPort, _communicationMailSmtpHost, _communicationMailSmtpEncryption, _communicationMailImapPort, _communicationMailImapHost, _communicationMailImapEncryption, _logisticSncfToken, _databaseLogin, _databasePassword, _databaseHost, _databaseName, _githubLogin, _githubPassword, _githubHost, _jiraLogin, _jiraPassword, _jiraHost, _sonarLogin, _sonarPassword, _sonarHost, _teamcityLogin, _teamcityPassword, _teamcityHost, _jenkinsLogin, _jenkinsPassword, _jenkinsHost, _dockerLogin, _dockerPassword, _dockerHost, _bitbucketLogin, _bitbucketPassword));
//            }
//        }
//        private static void LoadXmlParamsFile()
//        {
//            if (File.Exists(_configFile))
//            { 
//                XmlDocument xml = new XmlDocument();
//                xml.Load(_configFile);

//                _webProxyHost = xml.SelectNodes("/configmanager/web/proxy/host").Count > 0 ? xml.SelectNodes("/configmanager/web/proxy/host")[0].InnerText : string.Empty;
//                _webProxyLogin = xml.SelectNodes("/configmanager/web/proxy/login").Count > 0 ? xml.SelectNodes("/configmanager/web/proxy/login")[0].InnerText : string.Empty;
//                _webProxyPassword = xml.SelectNodes("/configmanager/web/proxy/password").Count > 0 ? xml.SelectNodes("/configmanager/web/proxy/password")[0].InnerText : string.Empty;
//                _webProxyPort = xml.SelectNodes("/configmanager/web/proxy/port").Count > 0 ? xml.SelectNodes("/configmanager/web/proxy/port")[0].InnerText : string.Empty;
//                _webHttpLogin = xml.SelectNodes("/configmanager/web/http/login").Count > 0 ? xml.SelectNodes("/configmanager/web/http/login")[0].InnerText : string.Empty;
//                _webHttpPassword = xml.SelectNodes("/configmanager/web/http/password").Count > 0 ? xml.SelectNodes("/configmanager/web/http/password")[0].InnerText : string.Empty;
//                _communicationSlackToken = xml.SelectNodes("/configmanager/communication/slack/token").Count > 0 ? xml.SelectNodes("/configmanager/communication/slack/token")[0].InnerText : string.Empty;
//                _communicationSlackUrl = xml.SelectNodes("/configmanager/communication/slack/url").Count > 0 ? xml.SelectNodes("/configmanager/communication/slack/url")[0].InnerText : string.Empty;
//                _communicationSlackAccount = xml.SelectNodes("/configmanager/communication/slack/account").Count > 0 ? xml.SelectNodes("/configmanager/communication/slack/account")[0].InnerText : string.Empty;
//                _communicationSlackTopic = xml.SelectNodes("/configmanager/communication/slack/topic").Count > 0 ? xml.SelectNodes("/configmanager/communication/slack/topic")[0].InnerText : string.Empty;
//                _communicationMailLogin = xml.SelectNodes("/configmanager/communication/mail/login").Count > 0 ? xml.SelectNodes("/configmanager/communication/mail/login")[0].InnerText : string.Empty;
//                _communicationMailPassword = xml.SelectNodes("/configmanager/communication/mail/password").Count > 0 ? xml.SelectNodes("/configmanager/communication/mail/password")[0].InnerText : string.Empty;
//                _communicationMailSmtpPort = xml.SelectNodes("/configmanager/communication/mail/smtp").Count > 0 ? xml.SelectNodes("/configmanager/communication/mail/smtp")[0].Attributes.GetNamedItem("port").Value : string.Empty;
//                _communicationMailSmtpHost = xml.SelectNodes("/configmanager/communication/mail/smtp").Count > 0 ? xml.SelectNodes("/configmanager/communication/mail/smtp")[0].Attributes.GetNamedItem("host").Value : string.Empty;
//                _communicationMailSmtpEncryption = xml.SelectNodes("/configmanager/communication/mail/smtp").Count > 0 ? xml.SelectNodes("/configmanager/communication/mail/smtp")[0].Attributes.GetNamedItem("encryption").Value : string.Empty;
//                _communicationMailImapPort = xml.SelectNodes("/configmanager/communication/mail/imap").Count > 0 ? xml.SelectNodes("/configmanager/communication/mail/imap")[0].Attributes.GetNamedItem("port").Value : string.Empty;
//                _communicationMailImapHost = xml.SelectNodes("/configmanager/communication/mail/imap").Count > 0 ? xml.SelectNodes("/configmanager/communication/mail/imap")[0].Attributes.GetNamedItem("host").Value : string.Empty;
//                _communicationMailImapEncryption = xml.SelectNodes("/configmanager/communication/mail/imap").Count > 0 ? xml.SelectNodes("/configmanager/communication/mail/imap")[0].Attributes.GetNamedItem("encryption").Value : string.Empty;
//                _logisticSncfToken = xml.SelectNodes("/configmanager/logistic/sncfkey").Count > 0 ? xml.SelectNodes("/configmanager/logistic/sncfkey")[0].InnerText : string.Empty;
//                _databaseHost = xml.SelectNodes("/configmanager/database/host").Count > 0 ? xml.SelectNodes("/configmanager/database/host")[0].InnerText : string.Empty;
//                _databasePassword = xml.SelectNodes("/configmanager/database/password").Count > 0 ? xml.SelectNodes("/configmanager/database/password")[0].InnerText : string.Empty;
//                _databaseLogin = xml.SelectNodes("/configmanager/database/login").Count > 0 ? xml.SelectNodes("/configmanager/database/login")[0].InnerText : string.Empty;
//                _databaseName = xml.SelectNodes("/configmanager/database/name").Count > 0 ? xml.SelectNodes("/configmanager/database/name")[0].InnerText : string.Empty;
//                _githubHost = xml.SelectNodes("/configmanager/github/host").Count > 0 ? xml.SelectNodes("/configmanager/github/host")[0].InnerText : string.Empty;
//                _githubPassword = xml.SelectNodes("/configmanager/github/password").Count > 0 ? xml.SelectNodes("/configmanager/github/password")[0].InnerText : string.Empty;
//                _githubLogin = xml.SelectNodes("/configmanager/github/login").Count > 0 ? xml.SelectNodes("/configmanager/github/login")[0].InnerText : string.Empty;
//                _jiraHost = xml.SelectNodes("/configmanager/jira/host").Count > 0 ? xml.SelectNodes("/configmanager/jira/host")[0].InnerText : string.Empty;
//                _jiraPassword = xml.SelectNodes("/configmanager/jira/password").Count > 0 ? xml.SelectNodes("/configmanager/jira/password")[0].InnerText : string.Empty;
//                _jiraLogin = xml.SelectNodes("/configmanager/jira/login").Count > 0 ? xml.SelectNodes("/configmanager/jira/login")[0].InnerText : string.Empty;
//                _sonarHost = xml.SelectNodes("/configmanager/sonar/host").Count > 0 ? xml.SelectNodes("/configmanager/sonar/host")[0].InnerText : string.Empty;
//                _sonarPassword = xml.SelectNodes("/configmanager/sonar/password").Count > 0 ? xml.SelectNodes("/configmanager/sonar/password")[0].InnerText : string.Empty;
//                _sonarLogin = xml.SelectNodes("/configmanager/sonar/login").Count > 0 ? xml.SelectNodes("/configmanager/sonar/login")[0].InnerText : string.Empty;
//                _teamcityHost = xml.SelectNodes("/configmanager/teamcity/host").Count > 0 ? xml.SelectNodes("/configmanager/teamcity/host")[0].InnerText : string.Empty;
//                _teamcityPassword = xml.SelectNodes("/configmanager/teamcity/password").Count > 0 ? xml.SelectNodes("/configmanager/teamcity/password")[0].InnerText : string.Empty;
//                _teamcityLogin = xml.SelectNodes("/configmanager/teamcity/login").Count > 0 ? xml.SelectNodes("/configmanager/teamcity/login")[0].InnerText : string.Empty;
//                _jenkinsHost = xml.SelectNodes("/configmanager/jenkins/host").Count > 0 ? xml.SelectNodes("/configmanager/jenkins/host")[0].InnerText : string.Empty;
//                _jenkinsPassword = xml.SelectNodes("/configmanager/jenkins/password").Count > 0 ? xml.SelectNodes("/configmanager/jenkins/password")[0].InnerText : string.Empty;
//                _jenkinsLogin = xml.SelectNodes("/configmanager/jenkins/login").Count > 0 ? xml.SelectNodes("/configmanager/jenkins/login")[0].InnerText : string.Empty;
//                _dockerHost = xml.SelectNodes("/configmanager/docker/host").Count > 0 ? xml.SelectNodes("/configmanager/docker/host")[0].InnerText : string.Empty;
//                _dockerPassword = xml.SelectNodes("/configmanager/docker/password").Count > 0 ? xml.SelectNodes("/configmanager/docker/password")[0].InnerText : string.Empty;
//                _dockerLogin = xml.SelectNodes("/configmanager/docker/login").Count > 0 ? xml.SelectNodes("/configmanager/docker/login")[0].InnerText : string.Empty;
//                _bitbucketPassword = xml.SelectNodes("/configmanager/bitbucket/password").Count > 0 ? xml.SelectNodes("/configmanager/bitbucket/password")[0].InnerText : string.Empty;
//                _bitbucketLogin = xml.SelectNodes("/configmanager/bitbucket/login").Count > 0 ? xml.SelectNodes("/configmanager/bitbucket/login")[0].InnerText : string.Empty;
//            }
//        }
//        #endregion
//    }
//}
