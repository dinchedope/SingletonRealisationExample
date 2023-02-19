using System;
using System.IO;
using System.Text;
using System.Text.Json;
using SystemCore.Log;


namespace SystemCore
{
    public sealed class Singleton
    {
        private string rootFolder;
        private string logFile;
        private Singleton(string rootFolder)
        {
            this.rootFolder = rootFolder;
            this.logFile = rootFolder + "logs.json";
            CreateLogsFile();
        }

        private static Singleton _instance;

        public static Singleton GetInstance(string rootFolder)
        {
            if (_instance == null)
            {
                _instance = new Singleton(rootFolder);
            }
            return _instance;
        }

        public bool WriteLog(string JSONLog)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(logFile, true))
                {
                    streamWriter.WriteLine(JSONLog);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string ReadLogList()
        {
            string lines = null;
            using (StreamReader reader = new StreamReader(logFile))
            {
                string line = null;
                while ((line =  reader.ReadLine()) != null)
                {
                    lines += line + "\n";
                }
            }
            return lines;
        }

        private void CreateLogsFile()
        {
            StreamWriter streamWriter = new StreamWriter(logFile, false);
            streamWriter.Write("");
            streamWriter.Close();
        }
    }
}
