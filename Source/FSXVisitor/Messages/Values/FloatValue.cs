/**
 * Represents a float (32-bit) value
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cockpit.Source.FSXVisitor.Messages.Values
{
    class FloatValue : Value
    {
        private const int DEC_NUM = 3;
        private float value;
        private int decNum;   //Number of significant decimal

        public FloatValue(float v)
        {
            value = v;
            decNum = DEC_NUM;
        }

        public FloatValue(float v, int dcNum)
        {
            value = v;
            decNum = dcNum;
        }

        public float get()
        {
            return value;
        }

        public int getDecNum()
        {
            return decNum;
        }
    }
}
