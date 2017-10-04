/**
 * Generic message
 * There will be implementation for every command
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cockpit.Source.FSXVisitor.Messages.Values;

namespace Cockpit.Source.FSXVisitor.Messages
{
    abstract class ToFSXMessage
    {
        private Value value;
        
        public Value getValue()
        {
            return value;
        }

        //Visitor Accept
        public abstract void Execute(FSXVisitor visitor);    
    }
}
