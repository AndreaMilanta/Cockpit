/**
 * Represents a boolean value
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cockpit.Source.FSXVisitor.Messages.Values
{
    class BoolValue : Value
    {
        private bool value;

        public BoolValue(bool v)
        {
            value = v;
        }

        public BoolValue(int v)
        {
            if (v == 0)
                value = false;
            else
                value = true;
        }

        public int getInt()
        {
            if (value)
                return 1;
            return 0;
        }

        public bool get()
        {
            return value;
        }
    }
}
