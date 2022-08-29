using System;

namespace _3_di_sample_asli.Service
{
    public class LogDB : ILog
    {
        public void Error(string msg)
        {
            throw new NotImplementedException();
        }

        public void Info(string msg)
        {
            throw new NotImplementedException();
        }

        public void Warn(string msg)
        {
            throw new NotImplementedException();
        }
    }
}