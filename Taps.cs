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
            //Add the original code to find
            string replaceAlto = "R1001R1030_1011";
			//Create list of replacement codes and add codes

			List<string> addAlto = new List<string>
			{
				"R1001R1030_1030",
				"R1001R1030_1032"
			};


			//Tell tool the asset folder location
			DirectoryInfo fldpath = new DirectoryInfo(folderPath);
            //Collect files that have the original code
            FileInfo[] files = fldpath.GetFiles("*" + replaceAlto + "*.*", SearchOption.AllDirectories);
            //Tell tool the temp folder location
            DirectoryInfo TempFolderInfo = new DirectoryInfo(TempFolder);

            //For each file with the original code copy and rename
            foreach (FileInfo f in files)
            {
                string s = f.FullName;

                string destFile = TempFolder + "\\" + f.Name;

                foreach (string newname in addAlto)
                {
                    File.Copy(s, destFile.Replace(replaceAlto, newname), true);
                }
            }

            //Collect files in Temp folder
            FileInfo[] tfiles = TempFolderInfo.GetFiles();

            
            //Move files to the asset folder and overwrite if needed
            foreach (FileInfo tfile in tfiles)
            {
                if (File.Exists(fldpath + "\\" + tfile.Name))
                {
                    File.Delete(fldpath + "\\" + tfile.Name);
                }
                File.Move(tfile.FullName, fldpath + "\\" + tfile.Name);
            }
        }

        //Same structure as above comments
        public void RenameActiveTaps(string folderPath, string TempFolder)
        {
            string replaceActive = "R1001R1030_1012";
			List<string> addActive = new List<string>
			{
				"R1001R1030_1031"
			};


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
        //Same structure as above comments
        public void RenameTempoTaps(string folderPath, string TempFolder)
        {
            string replaceTempo = "R1001R1030_1027";
			List<string> addTempo = new List<string>
			{
				"R1001R1030_1028"
			};


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
