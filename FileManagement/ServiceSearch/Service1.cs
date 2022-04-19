using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;

namespace ServiceSearch
{
    public partial class Service1 : ServiceBase
    {
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
            atm = new ATM();
            atm.ReceiveDataFromATM();

        }

        protected override void OnStop()
        {
        }
    }
}
