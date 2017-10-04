using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cockpit.Source.Exceptions
{
    public enum FSXFAILURE
    {
        NONE,
        CONNECTION_FAILED
    }
    public class FSXException : CockpitException
    {
        private FSXFAILURE _f;
        private const uint baseline = 25000;

        /// <summary>
        /// Exception related to FSX
        /// Exception baseline is 25000;
        /// </summary>
        /// <param name="f">Exception Type</param>
        public FSXException(FSXFAILURE f)
        {
            _f = f;
            _sev = FSXException.GetDefaultSeverity(f);
        }

        public FSXException(FSXFAILURE f, SEVERITY s)
        {
            _f = f;
            _sev = s;        
        }

        public FSXFAILURE failure
        {
            get 
            {
                return _f;
            }
        }
        
        /// <summary>
        /// Exception Code
        /// </summary>
        public uint Code
        {
            get
            {
                return baseline + (uint)_f;
            }
        }

        public override String ToString()
        {
            switch (_f)
            {
                case FSXFAILURE.NONE:
                    return "Test call";
                case FSXFAILURE.CONNECTION_FAILED:
                    return "Failed to connect to FSX";
                default:
                    return "Uknown Error";
            }
        }

        private static SEVERITY GetDefaultSeverity(FSXFAILURE f)
        {
            switch (f)
            {
                case FSXFAILURE.NONE:
                    return SEVERITY.INFO;
                case FSXFAILURE.CONNECTION_FAILED:
                    return SEVERITY.ERROR;
                default:
                    return SEVERITY.CRITICAL;
            }
        }
    }
}
