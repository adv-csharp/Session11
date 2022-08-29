using System;
using System.IO;

namespace _3_di_sample_asli.Service
{
    public class LogFile : ILog
    {
        public void Error(string msg)
        {
            File.WriteAllText("d://1.txt", $"{DateTime.Now} - ERROR : {msg}");
        }

        public void Info(string msg)
        {
            File.WriteAllText("d://1.txt", $"{DateTime.Now} - INFO : {msg}");
        }

        public void Warn(string msg)
        {
            File.WriteAllText("d://1.txt", $"{DateTime.Now} - Warn : {msg}");
        }
    }
}