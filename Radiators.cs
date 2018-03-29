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
            string replaceRadiators = "R1001R1002_1518";


            //Move files to temp rename location on desktop 
            DirectoryInfo fldpath = new DirectoryInfo(folderPath);
            FileInfo[] files = fldpath.GetFiles("*" + replaceRadiators + "*.*");

            DirectoryInfo TempFolderInfo = new DirectoryInfo(TempFolder);

            foreach (FileInfo f in files)
            {
                string s = f.FullName;

                string destFile = TempFolder + "\\" + f.Name;

                foreach (string newname in RadCodes)
                {
                    File.Copy(s, destFile.Replace(replaceRadiators, newname), true);
                }
            }

            FileInfo[] tfiles = TempFolderInfo.GetFiles();



            foreach (FileInfo tfile in tfiles)
            {
                File.Move(tfile.FullName, fldpath + "\\" + tfile.Name);
            }
        }
    }
}
