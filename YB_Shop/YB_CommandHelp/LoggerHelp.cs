using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace YB_CommandHelp
{
    public static class LoggerHelp
    {
        public static ILog m_Log;

         static LoggerHelp()
        {
            m_Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        }
        /// <summary>
        /// 异步 error message
        /// </summary>
        /// <param name="message"></param>
        public static void Log(string message)
        {
            Task.Run(()=>m_Log.Warn(message));
        }
    }
}
