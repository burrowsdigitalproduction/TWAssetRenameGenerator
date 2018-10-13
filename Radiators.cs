using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TWAssetRenameGenerator
{
    public class Radiators
    {


        public void RenameRadiators(string folderPath, List<string> RadCodes, string TempFolder)
        {
            //Set original code for the radiator
            string replaceRadiators = "R1001R1002_1518";


            //Tell the tool the asset folder location
            DirectoryInfo fldpath = new DirectoryInfo(folderPath);
            //Collect the files that have the original code in them 
            FileInfo[] files = fldpath.GetFiles("*" + replaceRadiators + "*.*", SearchOption.AllDirectories);

            //Create Temp Folder
            DirectoryInfo TempFolderInfo = new DirectoryInfo(TempFolder);

            //For each file found with the original code
            foreach (FileInfo f in files)
            {
                string s = f.FullName;

                string destFile = TempFolder + "\\" + f.Name;
                //For each code in the RadCodes list gathered from the checkboxes on the main page
                foreach (string newname in RadCodes)
                {
                    File.Copy(s, destFile.Replace(replaceRadiators, newname), true);
                }
            }

            //Collect the files from the Temp Folder
            FileInfo[] tfiles = TempFolderInfo.GetFiles();


            //CMove each file back into the original folder and overwrite if needed
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
