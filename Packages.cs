using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TWAssetRenameGenerator
{
    public class Packages
    {

        public void RenameE100Package(string folderPath, string TempFolder)
        {
            string replaceE100 = "R1001R2000_1488";
            List<string> addE100 = new List<string>();

            addE100.Add("R1001R2000_1825");
            addE100.Add("R1001R2000_1828");
            addE100.Add("R1001R2000_1747");


            //Move files to temp rename location on desktop 
            DirectoryInfo fldpath = new DirectoryInfo(folderPath);
            FileInfo[] files = fldpath.GetFiles("*" + replaceE100 + "*.*");
            DirectoryInfo TempFolderInfo = new DirectoryInfo(TempFolder);

            foreach (FileInfo f in files)
            {
                string s = f.FullName;

                string destFile = TempFolder + "\\" + f.Name;

                foreach (string newname in addE100)
                {
                    File.Copy(s, destFile.Replace(replaceE100, newname), true);
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

        public void RenameE500Package(string folderPath, string TempFolder)
        {
            string replaceE500 = "R1001R2000_1490";
            List<string> addE500 = new List<string>();

            addE500.Add("R1001R2000_1820");
            addE500.Add("R1001R2000_1824");
            addE500.Add("R1001R2000_1768");
            addE500.Add("R1001R2000_1767");

            //Move files to temp rename location on desktop 
            DirectoryInfo fldpath = new DirectoryInfo(folderPath);
            FileInfo[] files = fldpath.GetFiles("*" + replaceE500 + "*.*");
            DirectoryInfo TempFolderInfo = new DirectoryInfo(TempFolder);

            foreach (FileInfo f in files)
            {
                string s = f.FullName;

                string destFile = TempFolder + "\\" + f.Name;

                foreach (string newname in addE500)
                {
                    File.Copy(s, destFile.Replace(replaceE500, newname), true);
                }
            }

            FileInfo[] tfiles = TempFolderInfo.GetFiles();



            foreach (FileInfo tfile in tfiles)
            {
                if(File.Exists(fldpath + "\\" + tfile.Name))
                {
                    File.Delete(fldpath + "\\" + tfile.Name);
                }
                File.Move(tfile.FullName, fldpath + "\\" + tfile.Name);
            }
        }

        public void RenameRocaPackage(string folderPath, string TempFolder)
        {
            string replaceRoca = "R1001R2000_1823";
            List<string> addRoca = new List<string>();

            addRoca.Add("R1001R2000_1821");
            addRoca.Add("R1001R2000_2632");
            addRoca.Add("R1001R2000_2633");
            addRoca.Add("R1001R2000_1546");
            addRoca.Add("R1001R2000_1489");

            //Move files to temp rename location on desktop 
            DirectoryInfo fldpath = new DirectoryInfo(folderPath);
            FileInfo[] files = fldpath.GetFiles("*" + replaceRoca + "*.*");
            DirectoryInfo TempFolderInfo = new DirectoryInfo(TempFolder);

            foreach (FileInfo f in files)
            {
                string s = f.FullName;

                string destFile = TempFolder + "\\" + f.Name;

                foreach (string newname in addRoca)
                {
                    File.Copy(s, destFile.Replace(replaceRoca, newname), true);
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

        public void RenameTheGapPackage(string folderPath, string TempFolder)
        {
            string replaceTheGap = "R1001R2000_1761";
            List<string> addTheGap = new List<string>();

            addTheGap.Add("R1001R2000_1764");
            addTheGap.Add("R1001R2000_1822");

            //Move files to temp rename location on desktop 
            DirectoryInfo fldpath = new DirectoryInfo(folderPath);
            FileInfo[] files = fldpath.GetFiles("*" + replaceTheGap + "*.*");
            DirectoryInfo TempFolderInfo = new DirectoryInfo(TempFolder);

            foreach (FileInfo f in files)
            {
                string s = f.FullName;

                string destFile = TempFolder + "\\" + f.Name;

                foreach (string newname in addTheGap)
                {
                    File.Copy(s, destFile.Replace(replaceTheGap, newname), true);
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
