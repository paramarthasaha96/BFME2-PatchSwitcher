using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Permissions;
using Microsoft.Win32;

namespace PatchSwitcher_BFME2
{
    class RegistryFunctions
    {
        public static string searchGamePath()
        {
            RegistryKey rk = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\lotrbfme2.exe");
            if (rk == null) return null;
            string gamePath = rk.GetValue("Path").ToString();
            return gamePath;
        }

        public static string searchLeafPath()
        {
            string result = null;
            //64 bit
            RegistryKey rk64 = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Electronic Arts\Electronic Arts\The Battle for Middle-earth II");

            //32 bit
            RegistryKey rk32 = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Electronic Arts\Electronic Arts\The Battle for Middle-earth II");

            if (rk64 != null)
            {
                result = rk64.GetValue("UserDataLeafName").ToString();
            }
            else if (rk32 != null)
            {
                result = rk32.GetValue("UserDataLeafName").ToString();
            }
            
            return result;
        }
    }
}

