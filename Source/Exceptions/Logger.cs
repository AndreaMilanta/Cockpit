using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cockpit.Source.Exceptions
{
    /// <summary>
    /// Severity of the exception
    /// </summary>
    public enum SEVERITY
    {
        INFO,
        WARNING,
        ERROR,
        CRITICAL
    }

    public static class Logger
    { 
        public static void Start()
        {

        }

        public static void Log(CockpitException e)
        {
            throw new NotImplementedException();
        }

        public static void Log(String mex, SEVERITY s)
        {
            throw new NotImplementedException();
        }
    }
}
