using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TWAssetRenameGenerator
{
    class Bath
    {
        public void RenameBaths(string folderPath, string TempFolder)
        {
			string replaceBath = "R1001R2001_1762";
			List<string> addBath = new List<string>
			{
				"R1001R2001_1763",
				"R1001R2001_2630",
				"R1001R2001_2649",
				"R1001R2001_2662",
				"R1001R2001_2663"
			};


			//Move files to temp rename location on desktop 
			DirectoryInfo fldpath = new DirectoryInfo(folderPath);
            FileInfo[] files = fldpath.GetFiles("*" + replaceBath + "*.*", SearchOption.AllDirectories);

            DirectoryInfo TempFolderInfo = new DirectoryInfo(TempFolder);

            foreach (FileInfo f in files)
            {
                string s = f.FullName;

                string destFile = TempFolder + "\\" + f.Name;

                foreach (string newname in addBath)
                {
                    File.Copy(s, destFile.Replace(replaceBath, newname), true);
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
