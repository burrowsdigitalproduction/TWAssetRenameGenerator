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

        Taps renameTaps = new Taps();
        Packages renamePackages = new Packages();
        Radiators renameRadiators = new Radiators();
        AreaType renameAreaType = new AreaType();
        Bath renameBaths = new Bath();

        string folderPath;
        string TempFolder = @"D:\Folder" + "\\Temp";

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
            CreateTempFolder();
            CheckTapSettings();
            CheckPackageSettings();
            CheckRadiatorSettings();
            CheckAreaTypeSettings();
            CheckBath();
            Finish();


            
        }

        public void CreateTempFolder()
        {
            

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
            List<string> RadCodes = new List<string>();

            if (cbx1519.IsChecked == false && cbx1625.IsChecked == false && cbx1626.IsChecked == false && cbx1627.IsChecked == false && cbx1628.IsChecked == false && cbx1629.IsChecked == false && cbx1630.IsChecked == false && cbx1631.IsChecked == false && cbx1642.IsChecked == false && cbx1643.IsChecked == false && cbx1644.IsChecked == false)
                {
                    DialogResult result = System.Windows.Forms.MessageBox.Show("No Radiators selected. Continue Anyway?", "No Radiator Selected", MessageBoxButtons.OKCancel);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {  }
                    else if (result == System.Windows.Forms.DialogResult.Cancel)
                    { Finish(); }
                }

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
            renameRadiators.RenameRadiators(folderPath, RadCodes, TempFolder);
        }

        public void CheckAreaTypeSettings()
        {
            if (cbxFullMirror.IsChecked == false && cbxHalfShower.IsChecked == false)
            {
                DialogResult result = System.Windows.Forms.MessageBox.Show("No Area Types selected. Continue Anyway?", "No Area Type Selected", MessageBoxButtons.OKCancel);
                if (result == System.Windows.Forms.DialogResult.OK)
                {  }
                else if (result == System.Windows.Forms.DialogResult.Cancel)
                { Finish(); }
            }
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
            if (cbxBath.IsChecked == true)
            {
                renameBaths.RenameBaths(folderPath, TempFolder);
            }
        }

        public void Finish()
        {
            if (Directory.GetFiles(TempFolder).Length == 0 && Directory.GetDirectories(TempFolder).Length == 0)
            {
                Directory.Delete(TempFolder, false);
            }

            System.Windows.Forms.MessageBox.Show("Copy Over Complete","All Done!", MessageBoxButtons.OK);


        }
    }
}
