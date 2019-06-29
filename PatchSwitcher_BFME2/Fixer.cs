using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PatchSwitcher_BFME2
{
    class Fixer
    {
        private string destinationDirectory;
        private string destinationPath;

        public Fixer()
        {
            string leafPath = RegistryFunctions.searchLeafPath();
            if (leafPath == null) leafPath = @"My Battle for Middle-earth(tm) II Files";
            destinationDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\" + leafPath + @"\Options.ini";
            destinationPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\" + leafPath + @"\";
        }

        public void fixResolution()
        {
            if (!File.Exists(destinationDirectory))
            {
                MessageBox.Show("Not found 'Options.ini' at :\n" + destinationPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int width = SystemInformation.PrimaryMonitorSize.Width;
            int height = SystemInformation.PrimaryMonitorSize.Height;
            string newResolution = width + " " + height;

            string[] all = File.ReadAllLines(destinationDirectory);

            int i = 0;
            while (i < all.Length)
            {
                string[] lineParts = Regex.Split(all[i], " = ");
                if (lineParts[0] == "Resolution")
                {
                    if (lineParts[1] == newResolution)
                    {
                        MessageBox.Show("Your BFME resolution is already equal to your desktop resolution. Nothing's changed!"
                            , "Resolution Fixer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else all[i] = lineParts[0] + " = " + newResolution;
                    break;
                }
                i++;
            }

            writeNewOptionsIni(all);

            MessageBox.Show("Done! Your BFME resolution is " + width + "*" + height + " now!", "Resolution Fixer"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void writeNewOptionsIni(string[] all)
        {
            FileStream stream = File.Open(destinationDirectory, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            int j = 0;
            while (j < all.Length)
            {
                writer.WriteLine(all[j]);
                j++;
            }

            writer.Close();
        }

    }
}
