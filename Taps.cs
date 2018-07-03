using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TWAssetRenameGenerator
{
    public class Taps
    {

        

        public void RenameAltoTaps(string folderPath, string TempFolder)
        {
            string replaceAlto = "R1001R1030_1011";
            List<string> addAlto = new List<string>();

            addAlto.Add("R1001R1030_1030");
            addAlto.Add("R1001R1030_1032");


            //Move files to temp rename location on desktop 
            DirectoryInfo fldpath = new DirectoryInfo(folderPath);
            FileInfo[] files = fldpath.GetFiles("*" + replaceAlto + "*.*", SearchOption.AllDirectories);

            DirectoryInfo TempFolderInfo = new DirectoryInfo(TempFolder);

            foreach (FileInfo f in files)
            {
                string s = f.FullName;

                string destFile = TempFolder + "\\" + f.Name;

                foreach (string newname in addAlto)
                {
                    File.Copy(s, destFile.Replace(replaceAlto, newname), true);
                }
            }

            FileInfo[] tfiles = TempFolderInfo.GetFiles();

            

            foreach (FileInfo tfile in tfiles)
            {
                if (File.Exists(fldpath + "\\" + tfile.Name))
                {
                    File.Delete(fldpath + "\\" + tfile.Name);
                }
                File.Move(tfile.FullName, fldpath + "\\" + tfile.Name);
            }
        }

        public void RenameActiveTaps(string folderPath, string TempFolder)
        {
            string replaceActive = "R1001R1030_1012";
            List<string> addActive = new List<string>();

            addActive.Add("R1001R1030_1031");


            //Move files to temp rename location on desktop 
            DirectoryInfo fldpath = new DirectoryInfo(folderPath);
            FileInfo[] files = fldpath.GetFiles("*" + replaceActive + "*.*", SearchOption.AllDirectories);

            DirectoryInfo TempFolderInfo = new DirectoryInfo(TempFolder);

            foreach (FileInfo f in files)
            {
                string s = f.FullName;

                string destFile = TempFolder + "\\" + f.Name;

                foreach (string newname in addActive)
                {
                    File.Copy(s, destFile.Replace(replaceActive, newname), true);
                }
            }

            FileInfo[] tfiles = TempFolderInfo.GetFiles();



            foreach (FileInfo tfile in tfiles)
            {
                if (File.Exists(fldpath + "\\" + tfile.Name))
                {
                    File.Delete(fldpath + "\\" + tfile.Name);
                }
                File.Move(tfile.FullName, fldpath + "\\" + tfile.Name);
            }
        }

        public void RenameTempoTaps(string folderPath, string TempFolder)
        {
            string replaceTempo = "R1001R1030_1027";
            List<string> addTempo = new List<string>();

            addTempo.Add("R1001R1030_1028");


            //Move files to temp rename location on desktop 
            DirectoryInfo fldpath = new DirectoryInfo(folderPath);
            FileInfo[] files = fldpath.GetFiles("*" + replaceTempo + "*.*", SearchOption.AllDirectories);

            DirectoryInfo TempFolderInfo = new DirectoryInfo(TempFolder);

            foreach (FileInfo f in files)
            {
                string s = f.FullName;

                string destFile = TempFolder + "\\" + f.Name;

                foreach (string newname in addTempo)
                {
                    File.Copy(s, destFile.Replace(replaceTempo, newname), true);
                }
            }

            FileInfo[] tfiles = TempFolderInfo.GetFiles();



            foreach (FileInfo tfile in tfiles)
            {
                if (File.Exists(fldpath + "\\" + tfile.Name))
                {
                    File.Delete(fldpath + "\\" + tfile.Name);
                }
                File.Move(tfile.FullName, fldpath + "\\" + tfile.Name);
            }
        }
    }
}
