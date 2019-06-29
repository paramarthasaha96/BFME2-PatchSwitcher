using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace PatchSwitcher_BFME2
{
    class Finder
    {
        private string gamePath;
        private string currentDirectory;
        private string[] patch108_filenames = {@"_BT2DC-v1.08w.big", 
                                               @"lang\englishpatch105BT3.3Final.big",
                                               @"EnglishSplash.jpg"};

        private string[] patch106_filenames = {@"apt\CahAppearance.big",
                                               @"apt\CahManager.big",
                                               @"apt\GuiFX.big",
                                               @"apt\InGamePlanningMode.big",
                                               @"apt\LoadScreen.big",
                                               @"apt\OnlineOpenPlay.big",
                                               @"apt\OnlineQuickMatch.big",
                                               @"apt\OnlineStrategic.big",
                                               @"apt\Options.big",
                                               @"apt\SaveLoad.big",
                                               @"apt\Skirmish.big",
                                               @"apt\Timeline.big",
                                               @"lang\chinese_spatch105.big",
                                               @"lang\chinese_tpatch105.big",
                                               @"lang\dutchpatch105.big",
                                               @"lang\englishpatch105.big",
                                               @"lang\frenchpatch105.big",
                                               @"lang\germanpatch105.big",
                                               @"lang\italianpatch105.big",
                                               @"lang\norwegianpatch105.big",
                                               @"lang\polishpatch105.big",
                                               @"lang\russianpatch105.big",
                                               @"lang\spanishpatch105.big",
                                               @"lang\swedishpatch105.big",
                                               @"lang\thaipatch105.big",
                                               @"asset.dat",
                                               @"Data1.big",
                                               @"extra_uninst.exe",
                                               @"game.dat",
                                               @"ini.big",
                                               @"launcher.txt",
                                               @"Libraries.big",
                                               @"Maps.big",
                                               @"patch.doc",
                                               @"_patch101.big",
                                               @"_patch103.big",
                                               @"EnglishSplash.jpg"};

        private string[] patch100_filenames = {@"apt\CahAppearance.big",
                                               @"apt\CahManager.big",
                                               @"apt\GuiFX.big",
                                               @"apt\InGamePlanningMode.big",
                                               @"apt\LoadScreen.big",
                                               @"apt\OnlineOpenPlay.big",
                                               @"apt\OnlineQuickMatch.big",
                                               @"apt\OnlineStrategic.big",
                                               @"apt\Options.big",
                                               @"apt\SaveLoad.big",
                                               @"apt\Skirmish.big",
                                               @"apt\Timeline.big",
                                               @"asset.dat",
                                               @"Data1.big",
                                               @"extra_uninst.exe",
                                               @"game.dat",
                                               @"INI.big",
                                               @"Libraries.big",
                                               @"Maps.big",
                                               @"EnglishSplash.jpg"};

        public Finder(string gamePath)
        {
            this.gamePath = gamePath;
            currentDirectory = Directory.GetCurrentDirectory();
        }

        public void switchPatch(int activePatch, int newPatch)
        {
            if (activePatch == PatchSwitcher.PATCH_100)
            {
                deleteOldPatchFiles(patch100_filenames);

                if (newPatch == PatchSwitcher.PATCH_106)
                {
                    copyNewPatchFiles(patch106_filenames, newPatch);
                }
                else if(newPatch == PatchSwitcher.PATCH_108)
                {
                    copyNewPatchFiles(patch106_filenames, PatchSwitcher.PATCH_106);
                    copyNewPatchFiles(patch108_filenames, newPatch);
                }
            }
            else if (activePatch == PatchSwitcher.PATCH_106)
            {
                if (newPatch == PatchSwitcher.PATCH_108)
                {
                    copyNewPatchFiles(patch108_filenames, newPatch);
                }
                else if (newPatch == PatchSwitcher.PATCH_100)
                {
                    deleteOldPatchFiles(patch106_filenames);

                    copyNewPatchFiles(patch100_filenames, newPatch);
                }
            }
            else if (activePatch == PatchSwitcher.PATCH_108)
            {
                if (newPatch == PatchSwitcher.PATCH_100)
                {
                    deleteOldPatchFiles(patch108_filenames);
                    deleteOldPatchFiles(patch106_filenames);

                    copyNewPatchFiles(patch100_filenames, newPatch);
                }
                else if (newPatch == PatchSwitcher.PATCH_106)
                {
                    deleteOldPatchFiles(patch108_filenames);

                    File.Copy(currentDirectory + @"\106\EnglishSplash.jpg", gamePath + @"\EnglishSplash.jpg");
                }
            }
        }

        public void deleteOldPatchFiles(string[] patchfiles)
        {
            int i = 0;
            while (i < patchfiles.Length)
            {
                if (File.Exists(gamePath + @"\" + patchfiles[i]))
                {
                    File.SetAttributes(gamePath + @"\" + patchfiles[i], FileAttributes.Normal);
                    File.Delete(gamePath + @"\" + patchfiles[i]);
                }
                i++;
            }
        }

        public void copyNewPatchFiles(string[] patchfiles, int newPatch)
        {
            int i = 0;
            while (i < patchfiles.Length)
            {
                File.Copy(currentDirectory + @"\" + newPatch + @"\" + patchfiles[i], gamePath + @"\" + patchfiles[i], true);
                File.SetAttributes(gamePath + @"\" + patchfiles[i], FileAttributes.Normal);
                i++;
            }
        }

        public int getActiveVersion()
        {
            if (File.Exists(gamePath + @"\" + "_patch101.big"))
            {
                if (File.Exists(gamePath + @"\" + patch108_filenames[0]))
                    return PatchSwitcher.PATCH_108;
                else
                    return PatchSwitcher.PATCH_106;
            }
            else return PatchSwitcher.PATCH_100;
        }

        public Bitmap getActiveVersionImage(int activeVersion)
        {
            switch (activeVersion)
            {
                case PatchSwitcher.PATCH_100:
                    return Properties.Resources.cv100;
                case PatchSwitcher.PATCH_106:
                    return Properties.Resources.cv106;
                case PatchSwitcher.PATCH_108:
                    return Properties.Resources.cv108;
            }

            return null;
        }

        public string getActiveVersionText(int activeVersion)
        {
            string result = "";
            switch (activeVersion)
            {
                case PatchSwitcher.PATCH_100:
                    result = "Patch 1.00";
                    break;
                case PatchSwitcher.PATCH_106:
                    result = "Patch 1.06";
                    break;
                case PatchSwitcher.PATCH_108:
                    result = "Patch 1.08";
                    break;
            }

            return result;
        }


        public void copy106LangFiles()
        {
            int i = 0;
            while(i < patch106_filenames.Length)
            {
                if (patch106_filenames[i].StartsWith("lang"))
                {
                    File.Copy(currentDirectory + @"\106\" + patch106_filenames[i], gamePath + @"\" + patch106_filenames[i], true);
                    File.SetAttributes(gamePath + @"\" + patch106_filenames[i], FileAttributes.Normal);
                }
                i++;
            }
        }
    }
}
