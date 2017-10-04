using System;
using System.Windows.Forms;
using Cockpit.Source.FSXVisitor;

namespace Cockpit
{
    public partial class Form1 : Form
    {
        private FSXMiddleLayer SCVisitor;

        public Form1()
        {
            InitializeComponent();
            SCVisitor = new FSXMiddleLayer(this);


            //disconnect to SimConnect server
            SCVisitor.Disconnect();
        }

     

        /// <summary>
        /// Intercept SimConnect message
        /// </summary>
        /// <param name="m">intercepted message</param>
        protected override void DefWndProc(ref Message m)
        {
            if (m.Msg == FSXMiddleLayer.WM_USER_SIMCONNECT)
            {
                if (SCVisitor.SCHandler!= null)
                {
                    SCVisitor.SCHandler.ReceiveMessage();
                }
            }
            else
            {
                base.DefWndProc(ref m);
            }
        }
    }
}
