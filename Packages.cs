﻿using System;
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
            //Set the original package code to find
            string replaceE100 = "R1001R2000_1488";
            //Create a list of codes that need to be created and renamed
            List<string> addE100 = new List<string>();

            //Add codes to the above list
            addE100.Add("R1001R2000_1825");
            addE100.Add("R1001R2000_1828");
            addE100.Add("R1001R2000_1747");
            addE100.Add("R1001R2000_2644");


            //Tell the tool where the folder with original assets is 
            DirectoryInfo fldpath = new DirectoryInfo(folderPath);
            //Collect files that have the original code
            FileInfo[] files = fldpath.GetFiles("*" + replaceE100 + "*.*", SearchOption.AllDirectories);
            //Create Temp Folder
            DirectoryInfo TempFolderInfo = new DirectoryInfo(TempFolder);

            //For each file copy it to the temp folder 
            foreach (FileInfo f in files)
            {
                string s = f.FullName;

                string destFile = TempFolder + "\\" + f.Name;
                //foreach extra code in the list of package codes copy and rename the file
                foreach (string newname in addE100)
                {
                    File.Copy(s, destFile.Replace(replaceE100, newname), true);
                }
            }
            //Collect files in the Temp Folder
            FileInfo[] tfiles = TempFolderInfo.GetFiles();

            //Move each file into the original asset folder and overwrite if needed
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
            //Comments follow same patern as the E100 comments
            string replaceE500 = "R1001R2000_1490";
            List<string> addE500 = new List<string>();

            addE500.Add("R1001R2000_1820");
            addE500.Add("R1001R2000_1824");
            addE500.Add("R1001R2000_1768");
            addE500.Add("R1001R2000_1767");

            DirectoryInfo fldpath = new DirectoryInfo(folderPath);
            FileInfo[] files = fldpath.GetFiles("*" + replaceE500 + "*.*", SearchOption.AllDirectories);
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
            //Comments follow same patern as the E100 comments
            string replaceRoca = "R1001R2000_1823";
            List<string> addRoca = new List<string>();

            addRoca.Add("R1001R2000_1821");
            addRoca.Add("R1001R2000_2632");
            addRoca.Add("R1001R2000_2633");
            addRoca.Add("R1001R2000_1546");
            addRoca.Add("R1001R2000_1489");

            DirectoryInfo fldpath = new DirectoryInfo(folderPath);
            FileInfo[] files = fldpath.GetFiles("*" + replaceRoca + "*.*", SearchOption.AllDirectories);
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
            //Comments follow same patern as the E100 comments
            string replaceTheGap = "R1001R2000_1761";
            List<string> addTheGap = new List<string>();

            addTheGap.Add("R1001R2000_1764");
            addTheGap.Add("R1001R2000_1822");

            DirectoryInfo fldpath = new DirectoryInfo(folderPath);
            FileInfo[] files = fldpath.GetFiles("*" + replaceTheGap + "*.*", SearchOption.AllDirectories);
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
