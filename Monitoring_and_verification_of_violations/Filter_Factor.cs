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
        public Filter_Factor()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }
    }
}
