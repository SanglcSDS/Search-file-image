using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;
using System.Threading;

namespace ServiceSearch
{
    public partial class Service1 : ServiceBase
    {
        static Thread mainThread = null;
        static ATM atm = null;
        public Service1()
        {
            InitializeComponent();
        }
        public void OnDebug()
        {
            OnStart(null);

        }

        protected override void OnStart(string[] args)
        {

            mainThread = new Thread(new ThreadStart(main));
            mainThread.Start();


        }
        public void main()
        {
            atm = new ATM();
            atm.ReceiveDataFromATM();
        }

        protected override void OnStop()
        {
            atm.Close();
            mainThread.Abort();
        }
    }
}
