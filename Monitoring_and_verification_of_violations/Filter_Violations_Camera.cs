using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Monitoring_and_verification_of_violations
{
    public partial class Filter_Violations_Camera : Form
    {
        public List<string> SelectedViolations { get; private set; }
        public List<string> SelectedCameras { get; private set; }
        public string SelectedRecognition { get; private set; }

        public Filter_Violations_Camera(
            List<string> violations,
            List<string> cameras,
            List<string> initialSelectedViolations = null,
            List<string> initialSelectedCameras = null,
            string initialSelectedRecognition = null)
        {
            SelectedViolations = initialSelectedViolations ?? new List<string>();
            SelectedCameras = initialSelectedCameras ?? new List<string>();
            SelectedRecognition = initialSelectedRecognition ?? "Do not check";

            InitializeComponent();
            FillViolationsList(violations, initialSelectedViolations);
            FillCamerasList(cameras, initialSelectedCameras);
            Recognition_Selected.Text = SelectedRecognition;
        }

        void FillViolationsList(List<string> violations, List<string> initialSelected)
        {
            violationsList.Items.Clear();
            foreach (var item in violations)
            {
                bool isChecked = initialSelected == null || initialSelected.Contains(item);
                violationsList.Items.Add(item, isChecked);
            }
        }

        void FillCamerasList(List<string> cameras, List<string> initialSelected)
        {
            camerasList.Items.Clear();
            foreach (var item in cameras)
            {
                bool isChecked = initialSelected == null || initialSelected.Contains(item);
                camerasList.Items.Add(item, isChecked);
            }
        }

        List<string> GetCheckedItems(CheckedListBox listBox)
        {
            var checkedItems = new List<string>();
            foreach (var item in listBox.CheckedItems)
                checkedItems.Add(item.ToString());
            return checkedItems;
        }

        void btnApply_Click(object sender, System.EventArgs e)
        {
            SelectedViolations = GetCheckedItems(violationsList);
            SelectedCameras = GetCheckedItems(camerasList);
            SelectedRecognition = Recognition_Selected.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        void SetAllItemsChecked(CheckedListBox listBox, bool isChecked)
        {
            for (int i = 0; i < listBox.Items.Count; i++)
                listBox.SetItemChecked(i, isChecked);
        }

        private void btnSelectAll_V_Click(object sender, EventArgs e)
        {
            SetAllItemsChecked(violationsList, true);
        }

        private void btnClearAll_V_Click(object sender, EventArgs e)
        {
            SetAllItemsChecked(violationsList, false);
        }

        private void btnSelectAll_C_Click(object sender, EventArgs e)
        {
            SetAllItemsChecked(camerasList, true);
        }

        private void btnClearAll_C_Click(object sender, EventArgs e)
        {
            SetAllItemsChecked(camerasList, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (SelectedRecognition)
            {
                case "Do not check":
                    SelectedRecognition = "Recognized";
                    break;
                case "Recognized":
                    SelectedRecognition = "Unrecognized";
                    break;
                case "Unrecognized":
                    SelectedRecognition = "Do not check";
                    break;
                default:
                    SelectedRecognition = "Do not check";
                    break;
            }
            Recognition_Selected.Text = SelectedRecognition;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (SelectedRecognition)
            {
                case "Do not check":
                    SelectedRecognition = "Unrecognized";
                    break;
                case "Unrecognized":
                    SelectedRecognition = "Recognized";
                    break;
                case "Recognized":
                    SelectedRecognition = "Do not check";
                    break;
                default:
                    SelectedRecognition = "Do not check";
                    break;
            }
            Recognition_Selected.Text = SelectedRecognition;
        }
    }
}
