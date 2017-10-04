/**
 * Represents an integer (16-bit) value
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cockpit.Source.FSXVisitor.Messages.Values
{
    class IntValue : Value
    {
        private short value;

        public IntValue(short v)
        {
            value = v;
        }

        public short get()
        {
            return value;
        }
    }
}
