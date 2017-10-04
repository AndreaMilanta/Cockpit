/**
 * Represents a byte value
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cockpit.Source.FSXVisitor.Messages.Values
{
    class ByteValue : Value
    {
        private byte value;

        public ByteValue(byte v)
        {
            value = v;
        }

        public byte get()
        {
            return value;
        }
    }
}
