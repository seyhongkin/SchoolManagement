using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void mbtnDashboard_Click(object sender, EventArgs e)
        {
            mbtnDashboard.Checked  = mbtnDashboard.Checked ? false : true;
            if (mbtnDashboard.Checked)
            {
                mspDashboard.Visible = true;
                return;
            }
            mspDashboard.Visible = false;
        }
    }
}
