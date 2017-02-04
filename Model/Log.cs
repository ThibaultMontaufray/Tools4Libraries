
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
		private static int logLevel;
		private static StreamWriter sw;
        private static string _applicationAppData;
        #endregion

        #region Properties
        public static int LogLevel
		{
			get { return logLevel; }
			set { logLevel = value; }
        }
        public static string ApplicationAppData
        {
            get { return _applicationAppData; }
            set
            {
                _applicationAppData = value;
                if (_applicationAppData != null && !Directory.Exists(_applicationAppData)) { Directory.CreateDirectory(_applicationAppData); }
            }
        }
        #endregion

        #region Methods public
        public static void Write(string text)
		{
            try
            {
			    int level = 0;
			    string levelstring = "";
			    string[] tmp = text.Split(' ');
			    levelstring = tmp[1];
			    switch (levelstring) 
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
					    text = "->" + text;
					    break;
			    }
			
			    if (level <= logLevel)
			    {
				    MessageBox.Show(text, "Debug messages", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			    }
			
			    Tofile(text);
            }
            catch (Exception)
            {

            }
            finally
            {

            }
        }
        public static void Happen(string fileName, string newRow)
        {
            try
            {
                if (!File.Exists(_applicationAppData + "\\" + fileName)) { File.Create(_applicationAppData + "\\" + fileName); }
                using (StreamWriter sw = new StreamWriter(_applicationAppData + "\\" + fileName, true))
                {
                    sw.WriteLine(newRow);
                }
            }
            catch (Exception exp)
            {
                Log.Write("[ ERR 0000 ] : cannot write row for the file " + _applicationAppData + "\\" + fileName + " exp : " + exp.Message);
            }
        }
        public static string GetFile(string fileName)
        {
            string text = string.Empty;

            if (!File.Exists(_applicationAppData + "\\" + fileName)) return string.Empty;
            else
            {
                using (StreamReader sr = new StreamReader(_applicationAppData + "\\" + fileName))
                {
                    text = sr.ReadToEnd();
                }
                return text;
            }
        }
        public static void Clean(string fileName)
        {
            if (File.Exists(_applicationAppData + "\\" + fileName)) File.Delete(_applicationAppData + "\\" + fileName);
        }
        #endregion

        #region Meghods private
        private static void Tofile(string text)
		{
            try
            {
                if (File.Exists(_applicationAppData + @"\application.log"))
                {
                    using (sw = File.AppendText(_applicationAppData + @"\application.log"))
                    {
                        Buildfile(text);
                    }
                }
                else
                {
                    using (sw = File.CreateText(_applicationAppData + @"\application.log"))
                    {
                        Buildfile(text);
                    }
                }
            }
            catch (Exception exp)
            {
                Log.Write("[ERR 0000] : cannot write issue text to file : " + exp.Message) ;
            }
		}
		
		private static void Buildfile(string text)
		{
			string level = "";
        	string num = "";
        	string desc = "";
        	string date = "";
        	
			string[] tmps = text.Split(' ');
			
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
			num = string.Format("<EventID=\"{0}\"/>", tmps[3].Equals("]") ? tmps[2] : tmps[3]);
			
        	// description -----------------------------
			tmps = text.Split(']');
			desc = string.Format("<EventText=\"{0}\"/>", tmps[1].Replace('\n', '#'));
			
        	// date ------------------------------------
        	date = string.Format("<DateTime=\"{0}\"/>", DateTime.Now);
        	
            sw.WriteLine("<log>" + date + level + num + desc + "</log>");
			
		}
		#endregion
	}
}
