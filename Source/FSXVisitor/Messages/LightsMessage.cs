using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cockpit.Source.FSXVisitor.Messages.Values;

namespace Cockpit.Source.FSXVisitor.Messages
{
    class LightsMessage : ToFSXMessage
    {
        private ByteValue value;

        public LightsMessage(ByteValue v)
        {
            value = v;
        }

        //Visitor Accept
        public override void Execute(FSXVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}
