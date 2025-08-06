using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoring_and_verification_of_violations
{
    public partial class Filter_Factor : Form
    {
        public List<string> SelectedViolations { get; private set; }
        public string SelectedRecognition { get; private set; }

        public Filter_Factor(
            List<string> violations,
            List<string> initialSelectedViolations = null,
            string initialSelectedRecognition = null)
        {
            SelectedViolations = initialSelectedViolations ?? new List<string>();
            SelectedRecognition = initialSelectedRecognition ?? "Do not check";

            InitializeComponent();
            FillViolationsList(violations, initialSelectedViolations);
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

        private void btnApply_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void Recognition_Selected_P_Click(object sender, EventArgs e)
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

        private void Recognition_Selected_M_Click(object sender, EventArgs e)
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
    }
}
