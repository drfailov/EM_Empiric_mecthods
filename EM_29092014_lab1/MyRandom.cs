using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_29092014_lab1
{
    public class MyRandom : Random
    {
        protected Log logd = null;
        public delegate void Log(string text);

        public MyRandom() : base()
        {

        }
        public void setLog(Log nLog)
        {
            logd = nLog;
        }
        public Log getLog()
        {
            return logd;
        }
        protected void log(String text)
        {
            if(logd != null)
                logd(text);
        }
        public override string ToString()
        {
            return "Системний рандом 0...2'300'000'000";
        }
    }
}
