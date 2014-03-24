namespace WinServiceProject
{
    using System;
//    using System.IO;
    using System.Diagnostics;

    class WinService : System.ServiceProcess.ServiceBase
    {
        // The main entry point for the process
        static void Main()
        {
            System.ServiceProcess.ServiceBase[] ServicesToRun;
            ServicesToRun = new System.ServiceProcess.ServiceBase[] { new WinService() };
            System.ServiceProcess.ServiceBase.Run(ServicesToRun);
        }
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ServiceName = "WinService"; 
        }
        
        /// <summary>
        /// Set things in motion so your service can do its work.
        /// </summary>
        protected override void OnStart(string[] args)
        {
            RunServer server = new RunServer();
            server.start(); 
        }
        /// <summary>
        /// Stop this service.
        /// </summary>
        protected override void OnStop()
        {
        }
    }
}