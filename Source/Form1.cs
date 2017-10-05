using System;
using System.Windows.Forms;
using Cockpit.Source.FSXVisitor;
using Cockpit.Source.Exceptions;

namespace Cockpit
{
    public partial class Form1 : Form
    {
        private FSXMiddleLayer SCVisitor;
        private bool FSXConnected = false;

        public Form1()
        {
            InitializeComponent();

            while (!FSXConnected) ;

            //disconnect to SimConnect server
            //SCVisitor.Disconnect();
        }

        /// <summary>
        /// Tries to connect to FSX
        /// </summary>
        private void FSXConnect()
        {
            if (FSXConnected)
                return;
            try
            {
                TxtConnection.Text = "Connecting ...";
                LblConnection.BackColor = System.Drawing.ColorTranslator.FromHtml("#EFE145");
                SCVisitor = new FSXMiddleLayer(this);
                TxtConnection.Text = "Connected";
                LblConnection.BackColor = System.Drawing.Color.Green;
                FSXConnected = true;
            }
            catch (FSXException e)
            {
                TxtConnection.Text = "Disconnected";
                LblConnection.BackColor = System.Drawing.Color.Red;
                switch (e.Severity)
                {
                    case SEVERITY.ERROR:
                        TxtInfo.ForeColor = System.Drawing.Color.Red;
                        break;
                    case SEVERITY.WARNING:
                        TxtInfo.ForeColor = System.Drawing.ColorTranslator.FromHtml("#EDD417");
                        break;
                    default:
                        TxtInfo.ForeColor = System.Drawing.Color.Black;
                        break;
                }
                TxtInfo.Text = e.ToString();
            }
            catch (Exception e)
            {
                TxtInfo.ForeColor = System.Drawing.Color.Red;
                TxtInfo.Text = "Unknown Error: " + e.ToString();
            }
        }

        /// <summary>
        /// Disconnects from FSX
        /// </summary>
        private void FSXDisconnect()
        {
            if (!FSXConnected)
                return;
            try
            {
                SCVisitor.Disconnect();
                TxtConnection.Text = "Disconnected";
                LblConnection.BackColor = System.Drawing.Color.Red;
            }
            catch (Exception e)
            {
                TxtConnection.Text = "Disconnected";
                LblConnection.BackColor = System.Drawing.Color.Red;
                TxtInfo.ForeColor = System.Drawing.Color.Red;
                TxtInfo.Text = e.ToString();
            }

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

        private void BtConnect_Click(object sender, EventArgs e)
        {
            if (!FSXConnected)
                FSXConnect();
            else
                FSXDisconnect();
        }
    }
}
