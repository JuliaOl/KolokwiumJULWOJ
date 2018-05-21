using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewFactoryJULWOJ.Logs
{
    public interface ILogger
    {
        void Write(string msg, LogLevel lvl);
    }

    public enum LogLevel
    {
        FATAL,
        ERROR,
        WARN,
        INFO,
        DEBUG
    }
}