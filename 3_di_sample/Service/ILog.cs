using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _3_di_sample.Service
{
    public interface ILog
    {
        void Warn(string msg);
        void Error(string msg);
        void Info(string msg);
    }
}