
// les 10 commandements des logs applicatives
// http://blog.xebia.fr/2008/07/11/les-10-commandements-des-logs-applicatives/


/* 
 * wiki definition
 * 
 * 0 Emerg (emergency)       ⇒ Système inutilisable
 * 1 Alert                   ⇒ Une intervention immédiate est nécessaire
 * 2 Crit (critical)         ⇒ Erreur critique pour le système
 * 3 Err (error)             ⇒ Erreur de fonctionnement
 * 4 Warning                 ⇒ Avertissement
 * 5 Notice                  ⇒ Événement normal méritant d'être signalé
 * 6 Info (informational)    ⇒ pour information seulement
 * 7 Debug                   ⇒ Message de mise au point
 * 
 */

// ----------------------

// level 0 : emergency
// level 1 : critical
// level 2 : error
// level 3 : warning
// level 4 : info
// level 5 : debug

using System;
using System.IO;
using System.Windows.Forms;

namespace Tools4Libraries
{
	/// <summary>
	/// Description of Log.
	/// </summary>
	public static class Log
	{
        #region Attribute
        public static readonly string LOGPATH = Environment.CurrentDirectory +  @"\Log\application.log";

        private static int _logLevel;
		#endregion
		
		#region Properties
		public static int LogLevel
		{
			get { return _logLevel; }
			set { _logLevel = value; }
		}
		#endregion
		
		#region Methods public
		public static void write(string text)
		{	
			int level = 0;
			string levelstring = "";
			string[] tmp = text.Split(' ');
			levelstring = tmp[1];
            if (!string.IsNullOrEmpty(levelstring))
            { 
			    switch (levelstring.ToUpper()) 
			    {
				    case "DEB":
					    level = 5;
					    break;
				    case "INF":
					    level = 4;
					    break;
				    case "WRN":
					    level = 3;
					    break;
				    case "ERR":
					    level = 2;
					    break;
				    case "CRT":
					    level = 1;
					    break;
				    case "EMY":
					    level = 0;
					    break;
				    default:
					    // we don't recognise the level so we show the message.
					    level = 0;
					    text = text;
					    break;
			    }
			
			    if (level <= _logLevel)
			    {
				    MessageBox.Show(text, "Debug messages", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			    }
            }
            tofile(text);
		}
		#endregion
		
		#region Meghods private
		private static void tofile(string text)
		{
            try
            {
            	if (File.Exists(LOGPATH)) 
		        {
                    buildfile(text);
			    }
            	else
            	{
            		AppliParams ap = new AppliParams();
            		ap.CreateAppliPlateform();
		            buildfile(text);
            	}
		    }
            catch (Exception exp)
            {
            	MessageBox.Show("Error when writing the log date : " + exp.Message);
            }
		}
		
		private static void buildfile(string text)
		{
			string level = "";
        	string num = "";
        	string desc = "";
        	string date = "";
        	
			string[] tmps = text.Split(':')[0].Trim().Split(' ');

            // level -------------------------------------
            string tmp = tmps[1];
			switch (tmp) 
			{
				case "DEB":
					level = "<Severity=\"DEBUG\"/><Level=\"0\"/>";
					break;
				case "INF":
					level = "<Severity=\"INFO\"/><Level=\"1\"/>";
					break;
				case "WRN":
					level = "<Severity=\"WARNING\"/><Level=\"2\"/>";
					break;
				case "ERR":
					level = "<Severity=\"ERROR\"/><Level=\"3\"/>";
					break;
				case "CRT":
					level = "<Severity=\"CRITICAL\"/><Level=\"4\"/>";
					break;
				case "EMY":
					level = "<Severity=\"EMERGENCY\"/><Level=\"5\"/>";
					break;
				default:
					level = "<Severity=\"UNKNOW\"/><Level=\"99\"/>";
					break;
			}
			
        	// num -------------------------------------
			num = "<EventID=\"" + tmps[0] + "\"/>";
			
        	// description -----------------------------
			tmps = text.Split(']');
			desc = "<EventText=\"" + text.Split(':')[1].Replace('\n', '#').Trim() + "\"/>";
			
        	// date ------------------------------------
        	date = "<DateTime=\"" + DateTime.Now.ToString("yyyyMMdd:HHmmss") + "\"/>";

            using (StreamWriter sw = File.CreateText(LOGPATH))
            {
                sw.WriteLine("<log>" + date + level + num + desc + "</log>");
            }
			
		}
		#endregion
	}
}
