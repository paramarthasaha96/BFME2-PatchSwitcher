using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PatchSwitcher_BFME2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string gamePath = RegistryFunctions.searchGamePath();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PatchSwitcher(gamePath));
        }
    }
}

