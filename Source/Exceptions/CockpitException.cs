using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cockpit.Source.Exceptions
{
    public abstract class CockpitException : Exception
    {
        protected SEVERITY _sev;

        /// <summary>
        /// severity of the exception
        /// </summary>
        public SEVERITY severity
        {
            get
            {
                return _sev;
            }
        }
    }
}
