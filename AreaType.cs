using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TWAssetRenameGenerator
{
    public class AreaType
    {


        public void RenameFullMirror(string folderPath, string TempFolder)
        {
            string replaceFullMirror = "_full";

            string newname = "_fullmirror";

            DirectoryInfo TempFolderInfo = new DirectoryInfo(TempFolder);

            //Move files to temp rename location on desktop 
            DirectoryInfo fldpath = new DirectoryInfo(folderPath);
            FileInfo[] files = fldpath.GetFiles("*" + replaceFullMirror + "*.*");

            foreach (FileInfo f in files)
            {
                string s = f.FullName;

                string destFile = TempFolder + "\\" + f.Name;

                    File.Copy(s, destFile.Replace(replaceFullMirror, newname), true);
            }

            FileInfo[] tfiles = TempFolderInfo.GetFiles();



            foreach (FileInfo tfile in tfiles)
            {
                File.Move(tfile.FullName, fldpath + "\\" + tfile.Name);
            }
        }

        public void RenameHalfShower(string folderPath, string TempFolder)
        {
            string replaceHalfShower = "_half";

            string newname = "_halfshower";

            DirectoryInfo TempFolderInfo = new DirectoryInfo(TempFolder);

            //Move files to temp rename location on desktop 
            DirectoryInfo fldpath = new DirectoryInfo(folderPath);
            FileInfo[] files = fldpath.GetFiles("*" + replaceHalfShower + "*.*");

            foreach (FileInfo f in files)
            {
                string s = f.FullName;

                string destFile = TempFolder + "\\" + f.Name;

                    File.Copy(s, destFile.Replace(replaceHalfShower, newname), true);
            }

            FileInfo[] tfiles = TempFolderInfo.GetFiles();



            foreach (FileInfo tfile in tfiles)
            {
                File.Move(tfile.FullName, fldpath + "\\" + tfile.Name);
            }
        }

    }
}
