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
        private string[] factionfloor_filenames = { @"__109floors.big" };
        public string[] patch108_filenames ={@"_BT2DC-v1.08w.big", 
                                              @"lang\englishpatch105BT3.3Final.big",
                                              @"EnglishSplash.jpg"};
        private string[] patch109_filenames = {@"asset.dat",
                                               @"lang\dutchpatch105BTP1.09.big",
                                               @"lang\englishpatch105BTP1.09.big",
                                               @"lang\frenchpatch105BTP1.09.big",
                                               @"lang\germanpatch105BTP1.09.big",
                                               @"lang\italianpatch105BTP1.09.big",
                                               @"lang\norwegianpatch105BTP1.09.big",
                                               @"lang\polishpatch105BTP1.09.big",
                                               @"lang\swedishpatch105BTP1.09.big",
                                               @"lang\russianpatch105BTP1.09.big",
                                               @"lang\spanishpatch105BTP1.09.big",
                                               @"EnglishSplash.jpg",
                                               @"Patch 1.09 Changelogs and Credits\_1.09 Colors.bmp",
                                              // @"Patch 1.09 Changelogs and Credits\_Changelog. Match Ups.ini",
                                               @"Patch 1.09 Changelogs and Credits\Main_Changelog.txt",
                                               @"Patch 1.09 Changelogs and Credits\Patch 1.09 Credits.txt"};

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
        public void delete108(int activePatch)
        {
            if (activePatch != PatchSwitcher.PATCH_109)
            {
                deleteOldPatchFiles(patch108_filenames);
            }
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
                else if(newPatch == PatchSwitcher.PATCH_109)
                {
                    copyNewPatchFiles(patch106_filenames, PatchSwitcher.PATCH_106);
                    File.Move(gamePath + @"\__BT2DC-v1.09w.inv", gamePath + @"\__BT2DC-v1.09w.big");
                    copyNewPatchFiles(patch109_filenames, newPatch);
                }
            }
            else if (activePatch == PatchSwitcher.PATCH_106)
            {
                if (newPatch == PatchSwitcher.PATCH_109)
                {
                    File.Move(gamePath + @"\__BT2DC-v1.09w.inv", gamePath + @"\__BT2DC-v1.09w.big");
                    copyNewPatchFiles(patch109_filenames, newPatch);
                }
                else if (newPatch == PatchSwitcher.PATCH_100)
                {
                    deleteOldPatchFiles(patch106_filenames);
                    //File.Move(gamePath + @"\__BT2DC-v1.09w.big", gamePath + @"\__BT2DC-v1.09w.inv");
                    copyNewPatchFiles(patch100_filenames, newPatch);
                }
            }
            else if (activePatch == PatchSwitcher.PATCH_109)
            {
                if (newPatch == PatchSwitcher.PATCH_100)
                {
                    deleteOldPatchFiles(patch109_filenames);
                    File.Move(gamePath + @"\__BT2DC-v1.09w.big", gamePath + @"\__BT2DC-v1.09w.inv");
                    deleteOldPatchFiles(patch106_filenames);

                    copyNewPatchFiles(patch100_filenames, newPatch);
                }
                else if (newPatch == PatchSwitcher.PATCH_106)
                {
                    deleteOldPatchFiles(patch109_filenames);
                    File.Move(gamePath + @"\__BT2DC-v1.09w.big", gamePath + @"\__BT2DC-v1.09w.inv");
                    //copyNewPatchFiles(patch106_filenames, newPatch);
                    File.Copy(currentDirectory + @"\106\EnglishSplash.jpg", gamePath + @"\EnglishSplash.jpg");
                    File.Copy(currentDirectory + @"\106\asset.dat", gamePath + @"\asset.dat");
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
                File.Copy(currentDirectory + @"\" + newPatch + @"\" + patchfiles[i], gamePath + @"\" + patchfiles[i],true);
                File.SetAttributes(gamePath + @"\" + patchfiles[i], FileAttributes.Normal);
                i++;
            }
        }

        public int getActiveVersion()
        {
            if (File.Exists(gamePath + @"\" + "_patch101.big"))
            {
                if (File.Exists(gamePath + @"\" + "__BT2DC-v1.09w.big"))
                    return PatchSwitcher.PATCH_109;
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
                    return Properties.Resources.currentversion100;
                case PatchSwitcher.PATCH_106:
                    return Properties.Resources.currentversion106;
                case PatchSwitcher.PATCH_109:
                    return Properties.Resources.currentversion109;
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
                case PatchSwitcher.PATCH_109:
                    result = "Patch 1.09";
                    break;
            }

            return result;
        }


       
    }
}
