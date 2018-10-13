using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Forms;

namespace TWAssetRenameGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          
        }
        //Set Classes for reference
        Taps renameTaps = new Taps();
        Packages renamePackages = new Packages();
        Radiators renameRadiators = new Radiators();
        AreaType renameAreaType = new AreaType();
        Bath renameBaths = new Bath();

        //Create empty string for the asset folder
        string folderPath;
        //Set string for a temporary folder
        string TempFolder = @"D:\Folder" + "\\Temp";

        //Folder Browser to select the asset folder
        private void btnFolderBrowse_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();

            folderDlg.ShowNewFolderButton = true;

            // Show the FolderBrowserDialog.

            DialogResult result = folderDlg.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)

            {

                folderPath = folderDlg.SelectedPath;

                tbFolderPath.Text = folderPath;

            }


        }


        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            //Runs through each sections selections and runs the functions
            CreateTempFolder();
            CheckPackageSettings();
            CheckRadiatorSettings();
            CheckAreaTypeSettings();
            CheckTapSettings();
            CheckBath();
            Finish();


            
        }

        public void CreateTempFolder()
        {
            
            //Creates and temporary folder and if that exists cahnages the name and tries to create again
            if (!Directory.Exists(TempFolder))
            {
                Directory.CreateDirectory(TempFolder);
            }
            else if (Directory.Exists(TempFolder))
            {
                TempFolder = TempFolder + "Temp";
                Directory.CreateDirectory(TempFolder);
            }
        }

        public void CheckTapSettings()
        {
            //Checks through the checkbox selections and runs the appropriate functions
            if (cbxAlto.IsChecked == true)
            {
                renameTaps.RenameAltoTaps(folderPath, TempFolder);
            }
            if (cbxActive.IsChecked == true)
            {
                renameTaps.RenameActiveTaps(folderPath, TempFolder);
            }
            if (cbxTempo.IsChecked == true)
            {
                renameTaps.RenameTempoTaps(folderPath, TempFolder);
            }

            //If all checkboxes are unticked asks if thats correct and provides a continue or cancel option
            if (cbxAlto.IsChecked == false && cbxActive.IsChecked == false && cbxTempo.IsChecked == false)
            {
                DialogResult result = System.Windows.Forms.MessageBox.Show("No Taps Selected. Continue anyway?", "No Taps Selected", MessageBoxButtons.OKCancel);
                if (result == System.Windows.Forms.DialogResult.OK)
                { }
                else if (result == System.Windows.Forms.DialogResult.Cancel)
                { Finish(); } 
            }
        }

        public void CheckPackageSettings()
        {
            //Checks through the checkbox selections and runs the appropriate functions
            if (cbxE100.IsChecked == true)
            {
                renamePackages.RenameE100Package(folderPath, TempFolder);
            }
            if (cbxE500.IsChecked == true)
            {
                renamePackages.RenameE500Package(folderPath, TempFolder);
            }
            if (cbxRoca.IsChecked == true)
            {
                renamePackages.RenameRocaPackage(folderPath, TempFolder);
            }
            if (cbxTheGap.IsChecked == true)
            {
                renamePackages.RenameTheGapPackage(folderPath, TempFolder);
            }

            //If all checkboxes are unticked asks if thats correct and provides a continue or cancel option
            if (cbxE100.IsChecked == false && cbxE500.IsChecked == false && cbxRoca.IsChecked == false && cbxTheGap.IsChecked == false)
            {
                DialogResult result = System.Windows.Forms.MessageBox.Show("No Packages selected. Continue Anyway?", "No Package Selected", MessageBoxButtons.OKCancel);
                if (result == System.Windows.Forms.DialogResult.OK)
                { }
                else if (result == System.Windows.Forms.DialogResult.Cancel)
                { Finish(); }
            }

        }

        public void CheckRadiatorSettings()
        {
            //Creates an empty list for radiator codes
            List<string> RadCodes = new List<string>();

            //If all checkboxes are unticked asks if thats correct and provides a continue or cancel option
            if (cbx1519.IsChecked == false && cbx1625.IsChecked == false && cbx1626.IsChecked == false && cbx1627.IsChecked == false && cbx1628.IsChecked == false && cbx1629.IsChecked == false && cbx1630.IsChecked == false && cbx1631.IsChecked == false && cbx1642.IsChecked == false && cbx1643.IsChecked == false && cbx1644.IsChecked == false)
                {
                    DialogResult result = System.Windows.Forms.MessageBox.Show("No Radiators selected. Continue Anyway?", "No Radiator Selected", MessageBoxButtons.OKCancel);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {  }
                    else if (result == System.Windows.Forms.DialogResult.Cancel)
                    { Finish(); }
                }

            //Check checkboxes and if any are ticked add the relevant code to the list
            if (cbx1519.IsChecked == true)
            {
                RadCodes.Add("R1001R1002_1519");
            }
            if (cbx1625.IsChecked == true)
            {
                RadCodes.Add("R1001R1002_1625");
            }
            if (cbx1626.IsChecked == true)
            {
                RadCodes.Add("R1001R1002_1626");
            }
            if (cbx1627.IsChecked == true)
            {
                RadCodes.Add("R1001R1002_1627");
            }
            if (cbx1628.IsChecked == true)
            {
                RadCodes.Add("R1001R1002_1628");
            }
            if (cbx1629.IsChecked == true)
            {
                RadCodes.Add("R1001R1002_1629");
            }
            if (cbx1630.IsChecked == true)
            {
                RadCodes.Add("R1001R1002_1630");
            }
            if (cbx1631.IsChecked == true)
            {
                RadCodes.Add("R1001R1002_1631");
            }
            if (cbx1642.IsChecked == true)
            {
                RadCodes.Add("R1001R1002_1642");
            }
            if (cbx1643.IsChecked == true)
            {
                RadCodes.Add("R1001R1002_1643");
            }
            if (cbx1644.IsChecked == true)
            {
                RadCodes.Add("R1001R1002_1644");
            }
            //Run Function
            renameRadiators.RenameRadiators(folderPath, RadCodes, TempFolder);
        }

        public void CheckAreaTypeSettings()
        {
            //If all checkboxes are unticked asks if thats correct and provides a continue or cancel option
            if (cbxFullMirror.IsChecked == false && cbxHalfShower.IsChecked == false)
            {
                DialogResult result = System.Windows.Forms.MessageBox.Show("No Area Types selected. Continue Anyway?", "No Area Type Selected", MessageBoxButtons.OKCancel);
                if (result == System.Windows.Forms.DialogResult.OK)
                {  }
                else if (result == System.Windows.Forms.DialogResult.Cancel)
                { Finish(); }
            }
            //Checks through the checkbox selections and runs the appropriate functions
            else if (cbxFullMirror.IsChecked == true)
            {
                renameAreaType.RenameFullMirror(folderPath, TempFolder);
            }
            else if(cbxHalfShower.IsChecked == true)
            {
                renameAreaType.RenameHalfShower(folderPath, TempFolder);
            }

        }

        public void CheckBath()
        {
            //If checkbox is ticked run fuction
            if (cbxBath.IsChecked == true)
            {
                renameBaths.RenameBaths(folderPath, TempFolder);
            }
        }

        public void Finish()
        {
            //If the temp folder is empty it deletes it
            if (Directory.GetFiles(TempFolder).Length == 0 && Directory.GetDirectories(TempFolder).Length == 0)
            {
                Directory.Delete(TempFolder, false);
            }
            //Display Done message
            System.Windows.Forms.MessageBox.Show("Copy Over Complete","All Done!", MessageBoxButtons.OK);


        }
    }
}
