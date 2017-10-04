using System;
using System.Runtime.InteropServices;
using Microsoft.FlightSimulator.SimConnect;
using Cockpit.Source.Exceptions;
using Cockpit.Source.FSXVisitor;

namespace Cockpit.Source.FSXVisitor
{
    /// <summary>
    /// Client Events
    /// </summary>
    enum CLIENT_EVENT
    {
        GEAR_UP
    }

    /// <summary>
    /// Notification Groups
    /// </summary>
    enum NOTI_GROUP
    {
        GEAR
    }

    /// <summary>
    /// Provides the middle layer between FSX and our program.
    /// </summary>
    class FSXMiddleLayer
    {
        private Form1 form = null;
        private SimConnect simconnect = null;           //SimConnect reference
        public const int WM_USER_SIMCONNECT = 0x0402;  //SimConnect client reference

        /// <summary>
        /// Reference to simconnect handler
        /// </summary>
        public SimConnect SCHandler
        {
            get
            {
                return simconnect;
            }
        }

        /// <summary>
        /// Constructor. Pass starting form
        /// </summary>
        /// <param name="_form"></param>
        public FSXMiddleLayer(Form1 _form)
        {
            form = _form;
            Load();
        }

        /// <summary>
        /// Starts the connectiona and attaches all the required Event handlers
        /// </summary>
        /// <param name="_sc">opened simconnect reference</param>
        /// <exception cref="Exceptions.FSXException">connection failed</exception>
        private void Load()
        {
            if(simconnect == null)
            {
                try
                {
                    simconnect = new SimConnect("Cockpit", form.Handle, WM_USER_SIMCONNECT, null, 0);
                }
                catch (COMException)
                {
                    throw new FSXException(FSXFAILURE.CONNECTION_FAILED);
                }
            }

            simconnect.OnRecvOpen += new SimConnect.RecvOpenEventHandler(Simconnect_OnRecvOpen);
            simconnect.OnRecvEvent += new SimConnect.RecvEventEventHandler(Simconnect_OnRecvEvent);
            simconnect.OnRecvQuit += new SimConnect.RecvQuitEventHandler(Simconnect_OnRecvQuit);
        }

        private void Simconnect_OnRecvQuit(SimConnect sender, SIMCONNECT_RECV data)
        {
            Disconnect();
        }

        /// <summary>
        /// Disconnect from FSX
        /// </summary>
        public void Disconnect()
        {
            if (simconnect != null)
            {
                simconnect.Dispose();
                simconnect = null;
                Logger.Log("Disconnected from FSX", SEVERITY.INFO);
            }
        }

        private void Simconnect_OnRecvEvent(SimConnect sender, SIMCONNECT_RECV_EVENT data)
        {
            throw new NotImplementedException();
        }

        private void Simconnect_OnRecvOpen(SimConnect sender, SIMCONNECT_RECV_OPEN data)
        {
            throw new NotImplementedException();
        }
    }
}
