using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Threading;


namespace MyLog
{
    [CLSCompliant(true)]
    public class LogWriter
    {
        // Fields
        private bool m_bFound;
        private static bool m_bInitialized = false;
        private static bool m_bLogEnabled = true;
        private bool m_bLogPathSet;
        private static long m_nLogSize = 0x100000L;
        private static long m_nMaxLogFiles = 10L;
        private static long m_nMaxPriority = 0L;
        private static long m_nMinPriority = 0L;
        private StreamWriter m_oLogFileStream;
        private static object m_oSync = new object();
        private static string m_strInitialLog = @"C:/Log/Log_0.txt";
        private static string m_strLastFile = string.Empty;
        private string m_strLogFile = @"C:/Log/Log_0.txt";
        private static string m_strRootDirectory = string.Empty;
        private static string m_strUId = string.Empty;

        // Methods
        public LogWriter()
        {
            lock (typeof(LogWriter))
            {
                if (!m_bInitialized)
                {
                    this.Initialize();
                    m_bInitialized = true;
                }
            }
        }

        private void Backup()
        {
            try
            {
                string directoryName = Path.GetDirectoryName(this.FilePath);
                if (Directory.Exists(directoryName))
                {
                    DirectoryInfo info = new DirectoryInfo(directoryName);
                    Directory.Move(directoryName, Path.GetDirectoryName(directoryName) + @"\" + (info.Name + "_" + DateTime.Now.ToString("dd_MMM_yyyy") + "_" + DateTime.Now.Ticks.ToString()));
                }
            }
            catch (Exception exception)
            {
                string message = exception.Message;
            }
        }

        private void GenerateNewLogFileName()
        {
            int length = this.m_strLogFile.LastIndexOf("_");
            if (length == -1)
            {
                length = this.m_strLogFile.LastIndexOf(".");
            }
            int num2 = this.m_strLogFile.LastIndexOf(".");
            if ((num2 != -1) && (((num2 - length) - 1) >= 0))
            {
                string str = this.m_strLogFile.Substring(length + 1, (num2 - length) - 1);
                int num3 = 0;
                int.TryParse(str, out num3);
                if (num3 > (m_nMaxLogFiles - 1L))
                {
                    num3 = -1;
                }
                int nNum4 = ++num3;
                this.m_strLogFile = this.m_strLogFile.Substring(0, length) + "_";
                this.m_strLogFile = this.m_strLogFile + nNum4.ToString() + ".log";
            }
            else
            {
                this.m_strLogFile = this.m_strLogFile.Substring(0, length) + "_";
                this.m_strLogFile = this.m_strLogFile + "0.log";
            }
        }

        private void GetLastLogFile()
        {
            int length = this.m_strLogFile.LastIndexOf("_");
            if (length == -1)
            {
                length = this.m_strLogFile.LastIndexOf(".");
            }
            int num2 = this.m_strLogFile.LastIndexOf(".");
            if (num2 != -1)
            {
                string str = this.m_strLogFile.Substring(length + 1, (num2 - length) - 1);
                int num3 = 0;
                int.TryParse(str, out num3);
                if (num3 > (m_nMaxLogFiles - 1L))
                {
                    num3 = 0;
                }
                this.m_strLogFile = this.m_strLogFile.Substring(0, length) + "_";
                this.m_strLogFile = this.m_strLogFile + num3.ToString() + ".log";
            }
            else
            {
                this.m_strLogFile = this.m_strLogFile.Substring(0, length) + "_";
                this.m_strLogFile = this.m_strLogFile + "0.log";
            }
        }

        private string GetLogData(params string[] strDataArray)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(DateTime.Now);
            builder.Append("\t");
            builder.Append(m_strUId);
            builder.Append("\t");
            for (int i = 0; i < strDataArray.Length; i++)
            {
                builder.Append(strDataArray[i]);
                builder.Append("\r\n\t\t\t\t\t");
            }
            return builder.ToString().Trim("\r\n\t".ToCharArray());
        }

        private string GetLogData(string strUniqueKey, params string[] strDataArray)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(DateTime.Now);
            builder.Append("\t");
            builder.Append(strUniqueKey);
            builder.Append("\t");
            for (int i = 0; i < strDataArray.Length; i++)
            {
                builder.Append(strDataArray[i]);
                builder.Append("\r\n\t\t\t\t\t");
            }
            return builder.ToString().Trim("\r\n\t".ToCharArray());
        }

        private void Initialize()
        {
            m_strRootDirectory = Path.GetDirectoryName(m_strInitialLog);
            Directory.CreateDirectory(m_strRootDirectory);
            long num = 100L;
            if (num != 0L)
            {
                m_nLogSize = num;
            }
            num = 100L;
            if (num != 0L)
            {
                m_nMaxLogFiles = num;
            }
            if (File.Exists((m_strRootDirectory + @"\LastIndex.xml").ToString()))
            {
                m_strInitialLog = this.ReadLastFile();
            }
            this.m_bFound = true;
        }
        private void InitializedLogFileName()
        {
            int length = m_strLastFile.LastIndexOf("_");
            if (length == -1)
            {
                length = m_strLastFile.LastIndexOf(".");
            }
            int num2 = m_strLastFile.LastIndexOf(".");
            if ((num2 != -1) && (((num2 - length) - 1) >= 0))
            {
                string str = m_strLastFile.Substring(length + 1, (num2 - length) - 1);
                int num3 = 0;
                int.TryParse(str, out num3);
                if (num3 > (m_nMaxLogFiles - 1L))
                {
                    num3 = -1;
                }
                int nNum4 = ++num3;
                this.m_strLogFile = this.m_strLogFile.Substring(0, length) + "_";
                this.m_strLogFile = this.m_strLogFile + nNum4.ToString() + ".log";
            }
            else
            {
                this.m_strLogFile = this.m_strLogFile.Substring(0, length) + "_";
                this.m_strLogFile = this.m_strLogFile + "0.log";
            }
        }

        private bool LogRequired(long nPriority)
        {
            if (!m_bLogEnabled || string.IsNullOrEmpty(this.m_strLogFile))
            {
                return false;
            }
            return (((nPriority >= m_nMinPriority) && (nPriority <= m_nMaxPriority)) || (nPriority == -1L));
        }

        private string ReadLastFile()
        {
            try
            {
                string filename = m_strRootDirectory + @"\LastIndex.xml";
                XmlDocument document = new XmlDocument();
                document.Load(filename);
                string str2 = document.GetElementsByTagName("StoreLastFile")[0].Attributes[0].Value.ToString();
                return (m_strInitialLog.Substring(0, m_strInitialLog.LastIndexOf(@"\")) + @"\" + str2);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void SetUniqueData(string strData)
        {
            m_strUId = strData;
        }

        private void storeLastFile(string strFile)
        {
            try
            {
                string path = m_strRootDirectory + @"\LastIndex.xml";
                string str2 = strFile.Substring(this.m_strLogFile.LastIndexOf(@"\") + 1);
                FileStream w = new FileStream(path, FileMode.Create);
                XmlTextWriter writer = new XmlTextWriter(w, null);
                writer.WriteStartDocument();
                writer.WriteStartElement("StoreLastFile");
                writer.WriteAttributeString("FileName", str2);
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
            catch (Exception)
            {
            }
        }

        public bool WriteException(Exception e)
        {
            bool flag = true;
            try
            {
                lock (m_oSync)
                {
                    if (!this.m_bLogPathSet)
                    {
                        this.m_strLogFile = m_strInitialLog;
                    }
                    else
                    {
                        this.GetLastLogFile();
                    }
                    if (!this.LogRequired(-1L))
                    {
                        return false;
                    }
                    this.m_oLogFileStream = new StreamWriter(this.m_strLogFile, true);
                    this.WriteFullException(e);
                    this.m_oLogFileStream.Close();
                    this.m_oLogFileStream.Dispose();
                }
                flag = true;
            }
            catch (Exception)
            {
            }
            return flag;
        }

        private void WriteFullException(Exception e)
        {
            string logData = this.GetLogData(e.Message, new string[] { e.StackTrace });
            if ((this.m_oLogFileStream.BaseStream.Length / 0x400L) >= m_nLogSize)
            {
                this.m_oLogFileStream.Close();
                this.m_oLogFileStream.Dispose();
                this.GenerateNewLogFileName();
                this.m_oLogFileStream = new StreamWriter(this.m_strLogFile, false);
                if (!this.m_bLogPathSet)
                {
                    m_strInitialLog = this.m_strLogFile;
                }
            }
            this.m_oLogFileStream.WriteLine(logData, 0, logData.Length);
            Exception innerException = e.InnerException;
        }



        public bool WriteLog(string strData, string strUniqueString)
        {
            bool flag = false;
            try
            {
                lock (m_oSync)
                {
                    string[] files = Directory.GetFiles(m_strRootDirectory);
                    if (files.Length != 0)
                    {
                        int length = files.Length;
                    }
                    if (!this.m_bLogPathSet)
                    {
                        this.m_strLogFile = m_strInitialLog;
                    }
                    else
                    {
                        this.GetLastLogFile();
                    }

                    strData = this.GetLogData(strUniqueString, new string[] { strData });
                    this.m_oLogFileStream = new StreamWriter(this.m_strLogFile, true);
                    if ((this.m_oLogFileStream.BaseStream.Length / 0x400L) >= m_nLogSize)
                    {
                        this.m_oLogFileStream.Close();
                        this.m_oLogFileStream.Dispose();
                        Thread.Sleep(0);
                        this.GenerateNewLogFileName();
                        this.m_oLogFileStream = new StreamWriter(this.m_strLogFile, false);
                        if (!this.m_bLogPathSet)
                        {
                            m_strInitialLog = this.m_strLogFile;
                        }
                    }
                    this.m_oLogFileStream.WriteLine(strData, 0, strData.Length);
                    this.m_oLogFileStream.Close();
                    this.m_oLogFileStream.Dispose();
                    this.storeLastFile(this.m_strLogFile);
                }
                flag = true;
            }
            catch (Exception)
            {
            }
            return flag;
        }

        // Properties
        public string FilePath
        {
            get
            {
                if (string.IsNullOrEmpty(this.m_strLogFile))
                {
                    return m_strInitialLog;
                }
                return this.m_strLogFile;
            }
            set
            {
                this.m_bLogPathSet = true;
                this.m_strLogFile = value;
            }
        }
    }
}

 

 
