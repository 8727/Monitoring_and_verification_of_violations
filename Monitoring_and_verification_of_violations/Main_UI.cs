using System;
using System.IO;
using System.Xml;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Monitoring_and_verification_of_violations
{
    public partial class Main_UI : Form
    {
        public class Car_Metadata
        {
            public string time_check;
            public string camera;
            public string country_id;
            public string regno;
            public string violation;
            public string photo_grz;
            public bool recognition;
            public int video;
            public string path_car_XML;
        }

        Dictionary<string, string> DescriptionViolation = new Dictionary<string, string>
        {
            ["0"] = "  0 - Stream",
            ["2"] = "  2 - OverSpeed",
            ["4"] = "  4 - WrongDirection",
            ["5"] = "  5 - BusLane",
            ["10"] = " 10 - RedLightCross",
            ["30"] = " 30 - StopLine",
            ["31"] = " 31 - SeatBelt_Driver",
            ["32"] = " 32 - PhoneInHand",
            ["58"] = " 58 - NoYieldToPedestrian",
            ["81"] = " 81 - WrongCross",
            ["83"] = " 83 - StopLine",
            ["90"] = " 90 - WrongTurnTwoFrontier",
            ["112"] = "112 - WrongLineTurn",
            ["113"] = "113 - NoForwardZnak",
            ["114"] = "114 - NoUTurnOnlyForward",
            ["127"] = "127 - Lights",
            ["134"] = "134 - SeatBelt_Passanger"
        };

        public static string IPadress_Recognition = "192.168.4.133";
        public static bool Recognition = true;
        public static bool VehicleReg = true;
        public static bool Verification = false;

        CommonOpenFileDialog dialog = new CommonOpenFileDialog();
        Dictionary<string, Car_Metadata> ListFiles = new Dictionary<string, Car_Metadata>();
        XmlDocument xFile = new XmlDocument();
        XmlDocument xDoc = new XmlDocument();
        List<string> lastSelectedViolations = null;
        List<string> lastSelectedViolationsFactor = null;
        List<string> lastSelectedCameras = null;
        string lastSelectedRecognition = null;

        string NameCreation(string name)
        {
            Regex regex = new Regex(@"\d{4}_");
            if (regex.IsMatch(name))
            {
                int number = (int.Parse(name.Remove(name.IndexOf("_"))) + 1);
                name = number.ToString("0000") + name.Substring(4);
            }
            else
            {
                name = "0000_" + name;
            }

            if (ListFiles.ContainsKey(name))
            {
                name = NameCreation(name);
            }
            return name;
        }

        public Main_UI()
        {
            InitializeComponent();
        }

        void Ui_Lock()
        {
            Select_Folder_Source.Enabled = false;
            Select_Factor_Source.Enabled = false;
            Filter.Enabled = false;
            Clear.Enabled = false;
            Recognition_CheckBox.Enabled = false;
            Verification_CheckBox.Enabled = false;
            Video.Enabled = false;
            Save.Enabled = false;
        }

        void Ui_Unlock()
        {
            Select_Folder_Source.Enabled = true;
            Select_Factor_Source.Enabled = true;
            Filter.Enabled = true;
            Clear.Enabled = true;
            Recognition_CheckBox.Enabled = true;
            Verification_CheckBox.Enabled = true;
            Video.Enabled = true;
            Save.Enabled = true;

        }

        void Verification_CheckedChanged()
        {
            if (Verification)
            {
                Verification_Correct.BringToFront();
                Verification_Incorrect.BringToFront();
                Verification_CheckBox.Checked = true;
            }
            else
            {
                Verification_Correct.SendToBack();
                Verification_Incorrect.SendToBack();
                Verification_CheckBox.Checked = false;
            }
        }

        async void Main_UI_Load(object sender, EventArgs e)
        {
            Recognition = Recognition_CheckBox.Checked;
            Verification = Verification_CheckBox.Checked;

            Verification_CheckedChanged();

            if (Recognition)
            {
                VehicleReg = await RegistrationNumberComparer.CheckVehicleRegAsync();
            }
            Recognition_CheckBox.ForeColor = VehicleReg ? Color.Green : Color.Red;
        }
        void Clear_Full()
        {
            Count_Files.Text = "0";
            number_regno.Text = "*001аА%";
            number_regno.BackColor = SystemColors.ControlDark;
            img_photo_ts.Image = Properties.Resources.upload_files;
            img_photo_grz.Image = null;
            Clear.BackgroundImage = Properties.Resources.tash;
            lastSelectedViolations = null;
            lastSelectedCameras = null;
        }

        void ViewerIMG(Car_Metadata car)
        {
            try
            {
                xDoc.Load(car.path_car_XML);

                var tsNode = xDoc.SelectSingleNode("//v_photo_ts");
                if (tsNode != null)
                {
                    img_photo_ts.Image = Base64ToImage(tsNode.InnerText);
                }

                img_photo_grz.Image = Base64ToImage(car.photo_grz);
                number_regno.Text = car.regno;

                if (Recognition)
                {
                    if (car.recognition)
                    {
                        number_regno.BackColor = Color.Green;
                    }
                    else
                    {
                        number_regno.BackColor = Color.Red;
                    }
                }

                if (car.video > 0)
                {
                    Video.BackgroundImage = Properties.Resources.video;
                    Video.Enabled = true;
                }
                else
                {
                    Video.BackgroundImage = null;
                    Video.Enabled = false;
                }
            }
            catch
            {
                img_photo_ts.Image = null;
                img_photo_grz.Image = null;
                number_regno.Text = "ERROR";
            }
            finally
            {

            }
        }

        Image Base64ToImage(string base64String)
        {
            if (string.IsNullOrEmpty(base64String))
                return null;

            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
                {
                    return Image.FromStream(ms);
                }
            }
            catch
            {
                return null;
            }
        }

        void Cars_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cars_List.SelectedIndex == -1) return;

            if (ListFiles.TryGetValue(Cars_List.SelectedItem.ToString(), out Car_Metadata car))
            {
                ViewerIMG(car);
            }
            else
            {
                Clear_Full();
            }
        }

        static IEnumerable<string> GetXmlFilesExcludingFolders(string rootPath, HashSet<string> excludedFolderNames)
        {
            var queue = new Queue<string>();
            queue.Enqueue(rootPath);

            while (queue.Count > 0)
            {
                string currentDir = queue.Dequeue();
                string currentFolderName = Path.GetFileName(currentDir);

                if (excludedFolderNames.Contains(currentFolderName))
                    continue;

                string[] files = Array.Empty<string>();
                try
                {
                    files = Directory.GetFiles(currentDir, "*.xml");
                }
                catch (UnauthorizedAccessException) { }
                catch (DirectoryNotFoundException) { }

                foreach (string file in files)
                    yield return file;

                string[] subDirs = Array.Empty<string>();
                try
                {
                    subDirs = Directory.GetDirectories(currentDir);
                }
                catch (UnauthorizedAccessException) { }
                catch (DirectoryNotFoundException) { }

                foreach (string subDir in subDirs)
                    queue.Enqueue(subDir);
            }
        }

        async Task ReadFile(string filePath)
        {
            try
            {
                xFile.Load(filePath);
                if (xFile.SelectSingleNode("//v_photo_ts") == null)
                    return;

                Car_Metadata data = new Car_Metadata();
                string fileName = Path.GetFileName(filePath);

                data.time_check = xFile.SelectSingleNode("//v_time_check")?.InnerText ?? "";
                data.camera = xFile.SelectSingleNode("//v_camera")?.InnerText ?? "";
                data.country_id = xFile.SelectSingleNode("//v_regno_country_id")?.InnerText ?? "";
                data.regno = xFile.SelectSingleNode("//v_regno")?.InnerText ?? "";
                data.violation = xFile.SelectSingleNode("//v_pr_viol")?.InnerText ?? "";
                data.photo_grz = xFile.SelectSingleNode("//v_photo_grz")?.InnerText ?? "";
                XmlNodeList photoExtras = xFile.SelectNodes("//photo_extra[v_type_photo='3']");
                data.video = photoExtras?.Count ?? 0;
                data.path_car_XML = filePath;
                data.recognition = await RegistrationNumberComparer.Compare(data).ConfigureAwait(false);

                string uniqueName = fileName;
                this.Invoke((Action)(() =>
                {
                    if (ListFiles.ContainsKey(uniqueName))
                    {
                        uniqueName = NameCreation(uniqueName);
                    }
                    ListFiles.Add(uniqueName, data);
                    Cars_List.Items.Add(uniqueName);
                }));

                if (ListFiles.Count == 1)
                {
                    Cars_List.SelectedIndex = 0;
                    Clear.BackgroundImage = Properties.Resources.tash_full;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error processing file {filePath}: {ex.Message}");
            }
            finally
            {
                xFile.RemoveAll();
            }
        }

        async Task ReadFolder(string rootPath)
        {
            var excludedFolders = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "Correct",
                "Incorrect"
            };

            var xmlFiles = GetXmlFilesExcludingFolders(rootPath, excludedFolders);
            progressBar.Maximum = xmlFiles.Count();
            progressBar.Visible = true;
            progressBar.Value = 0;

            foreach (string file in xmlFiles)
            {
                await ReadFile(file).ConfigureAwait(false);
                Count_Files.Text = Cars_List.Items.Count.ToString();
                progressBar.Value = Cars_List.Items.Count;
            }

            progressBar.Visible = false;

            if (Cars_List.Items.Count == 0)
            {
                Clear.BackgroundImage = Properties.Resources.tash;
            }
        }

        async void Select_Folder_Source_Click(object sender, EventArgs e)
        {
            Ui_Lock();
            dialog.InitialDirectory = Application.StartupPath;
            dialog.IsFolderPicker = true;
            dialog.Multiselect = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                foreach (string folder in dialog.FileNames)
                {
                    await ReadFolder(folder).ConfigureAwait(false);
                }
            }
            Ui_Unlock();
        }

        void Select_Factor_Source_Click(object sender, EventArgs e)
        {
            Ui_Lock();

            var violations = new HashSet<string>(DescriptionViolation.Values);

            using (var filterDialog = new Filter_Factor(violations.ToList(), lastSelectedViolationsFactor, lastSelectedRecognition))
            {
                if (filterDialog.ShowDialog() == DialogResult.OK)
                {
                    lastSelectedViolationsFactor = filterDialog.SelectedViolations;
                    lastSelectedRecognition = filterDialog.SelectedRecognition;
                    ApplyFilterFactor(lastSelectedViolationsFactor, lastSelectedRecognition);

                }
            }
            Ui_Unlock();
        }

        void ApplyFilterFactor(List<string> selectedViolations, string selectedRecognition)
        {
        }

        void Filter_Click(object sender, EventArgs e)
        {
            var violations = new HashSet<string>();
            var cameras = new HashSet<string>();

            foreach (var car in ListFiles.Values)
            {
                if (!string.IsNullOrEmpty(car.violation))
                {
                    violations.Add(DescriptionViolation.TryGetValue(car.violation, out var description) ? description : car.violation);
                }

                if (!string.IsNullOrEmpty(car.camera))
                    cameras.Add(car.camera);
            }

            using (var filterDialog = new Filter_Violations_Camera(violations.ToList(), cameras.ToList(), lastSelectedViolations, lastSelectedCameras, lastSelectedRecognition))
            {
                if (filterDialog.ShowDialog() == DialogResult.OK)
                {
                    lastSelectedViolations = filterDialog.SelectedViolations;
                    lastSelectedCameras = filterDialog.SelectedCameras;
                    lastSelectedRecognition = filterDialog.SelectedRecognition;
                    ApplyFilter(lastSelectedViolations, lastSelectedCameras, lastSelectedRecognition);
                }
            }
        }

        void ApplyFilter(List<string> selectedViolations, List<string> selectedCameras, string selectedRecognition)
        {
            var selectedViolationsSet = new HashSet<string>(selectedViolations);
            var selectedCamerasSet = new HashSet<string>(selectedCameras);
            Cars_List.Items.Clear();

            foreach (var item in ListFiles)
            {
                var car = item.Value;
                bool shouldAdd = false;
                if (!selectedCamerasSet.Contains(car.camera))
                    continue;

                string violationKey = car.violation;
                bool hasViolation = !string.IsNullOrEmpty(violationKey);
                string violationToCheck = hasViolation && DescriptionViolation.TryGetValue(violationKey, out var description) ? description : violationKey;

                if (hasViolation && selectedViolationsSet.Contains(violationToCheck))
                {
                    switch (selectedRecognition)
                    {
                        case "Do not check":
                            shouldAdd = true;
                            break;
                        case "Recognized":
                            shouldAdd = item.Value.recognition;
                            break;
                        case "Unrecognized":
                            shouldAdd = !item.Value.recognition;
                            break;
                    }

                    if (shouldAdd)
                        Cars_List.Items.Add(item.Key);
                }
                Count_Files.Text = Cars_List.Items.Count.ToString();
            }

            if (Cars_List.Items.Count > 0)
            {
                Cars_List.SelectedIndex = 0;
                Clear.BackgroundImage = Properties.Resources.tash_full;
            }
            else
            {
                Clear_Full();
            }
        }

        void Clear_Click(object sender, EventArgs e)
        {
            Cars_List.Items.Clear();
            ListFiles.Clear();
            Clear_Full();
        }

        async void Recognition_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Recognition = Recognition_CheckBox.Checked;
            if (Recognition)
            {
                VehicleReg = await RegistrationNumberComparer.CheckVehicleRegAsync();
                Recognition_CheckBox.ForeColor = VehicleReg ? Color.Green : Color.Red;
            }
            else
            {
                Recognition_CheckBox.ForeColor = Color.Black;
            }
        }

        void Verification_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Verification = Verification_CheckBox.Checked;
            Verification_CheckedChanged();
        }

        private void Video_Click(object sender, EventArgs e)
        {

        }

        static void EnsureFolderExists(string folderName)
        {
            string appDir = AppDomain.CurrentDomain.BaseDirectory;
            string targetPath = Path.Combine(appDir, folderName);

            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }
        }

        static void CopyFileAndCleanSource(string sourceFilePath, string targetFolderName, string folderToCheckAndDelete)
        {
            if (!File.Exists(sourceFilePath))
            {
                throw new FileNotFoundException("Исходный файл не найден", sourceFilePath);
            }

            string appDir = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = Path.GetFileName(sourceFilePath);

            string destFolderPath = Path.Combine(appDir, targetFolderName);
            string destFilePath = Path.Combine(destFolderPath, fileName);
            string checkFolderPath = Path.Combine(appDir, folderToCheckAndDelete);
            string fileToDeletePath = Path.Combine(checkFolderPath, fileName);

            EnsureFolderExists(targetFolderName);

            File.Copy(sourceFilePath, destFilePath, overwrite: true);

            if (File.Exists(fileToDeletePath))
            {
                File.Delete(fileToDeletePath);
            }
        }

        private void Verification_Correct_Click(object sender, EventArgs e)
        {
            int index = Cars_List.SelectedIndex;

            if (ListFiles.TryGetValue(Cars_List.SelectedItem.ToString(), out Car_Metadata car))
            {
                CopyFileAndCleanSource(car.path_car_XML, "Correct", "Incorrect");
            }

            if (index < Cars_List.Items.Count - 1)
            {
                Cars_List.SelectedIndex = index + 1;
            }
            else
            {
                Verification = false;
                Verification_CheckedChanged();
            }
        }

        private void Verification_Incorrect_Click(object sender, EventArgs e)
        {
            int index = Cars_List.SelectedIndex;

            if (ListFiles.TryGetValue(Cars_List.SelectedItem.ToString(), out Car_Metadata car))
            {
                CopyFileAndCleanSource(car.path_car_XML, "Incorrect", "Correct");
            }

            if (index < Cars_List.Items.Count - 1)
            {
                Cars_List.SelectedIndex = index + 1;
            }
            else
            {
                Verification = false;
                Verification_CheckedChanged();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {

        }
    }
}