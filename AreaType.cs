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
            //Add string to find
            string replaceFullMirror = "_full.";

            //Add string to replace with
            string newname = "_fullmirror.";

            //Tell tool the temp folder location
            DirectoryInfo TempFolderInfo = new DirectoryInfo(TempFolder);

            //Tell tool the asset folder location
            DirectoryInfo fldpath = new DirectoryInfo(folderPath);
            //Collect files that have the original code
            FileInfo[] files = fldpath.GetFiles("*" + replaceFullMirror + "*.*", SearchOption.AllDirectories);

            //Foreach file found in the asset folder copy to tempfolder and rename
            foreach (FileInfo f in files)
            {
                string s = f.FullName;

                string destFile = TempFolder + "\\" + f.Name;

                    File.Copy(s, destFile.Replace(replaceFullMirror, newname), true);
            }

            //Collect files in the temp folder
            FileInfo[] tfiles = TempFolderInfo.GetFiles();

            //Copy temp folder files to the asset folder and overwrite if needed
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
