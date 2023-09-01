using SchoolManagement.WebServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class FrmMain : Form
    {
        private ImageService imageService = new ImageService();
        public FrmMain()
        {
            InitializeComponent();
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        #region Resizable Form
        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        #endregion

        #region Menu

        private void HideAllSubMenu()
        {
            spSubAdministrator.Visible = false;
            spSubInformations.Visible = false;
            spSubExaminations.Visible = false;
        }

        private void CloseSettings()
        {
            sbmSettings.Checked = false;
        }

        private void sbmAdministrator_Click(object sender, EventArgs e)
        {
            CloseSettings();
            spSubAdministrator.Visible = spSubAdministrator.Visible ? false : true;
        }

        private void sbmDashboard_CheckedChanged(object sender, EventArgs e)
        {
            HideAllSubMenu();
        }

        private void spSubAdministrator_VisibleChanged(object sender, EventArgs e)
        {
            smUser.Checked = true;
        }

        private void sbmTransactions_Click(object sender, EventArgs e)
        {
            CloseSettings();
            lbHeader.Text = "Transactions";
            ucTransaction1.BringToFront();
        }

        private void sbmDashboard_Click(object sender, EventArgs e)
        {
            CloseSettings();
            lbHeader.Text = "Dashboard";
            ucDashboard1.BringToFront();
        }

        private void sbmInformations_Click(object sender, EventArgs e)
        {
            CloseSettings();
            spSubInformations.Visible = spSubInformations.Visible ? false : true;
        }

        private void spSubInformations_VisibleChanged(object sender, EventArgs e)
        {
            smStudents.Checked = true;
        }

        private void sbmInformations_CheckedChanged(object sender, EventArgs e)
        {
            HideAllSubMenu();
        }

        private void sbmExam_CheckedChanged(object sender, EventArgs e)
        {
            HideAllSubMenu();
        }

        private void sbmExam_Click(object sender, EventArgs e)
        {
            CloseSettings();
            spSubExaminations.Visible = spSubExaminations.Visible ? false : true;
        }

        private void spSubExaminations_VisibleChanged(object sender, EventArgs e)
        {
            smTimeTables.Checked = true;
        }

        private void sbmSettings_CheckedChanged(object sender, EventArgs e)
        {
            HideAllSubMenu();
        }

        private void sbmTransactions_CheckedChanged(object sender, EventArgs e)
        {
            HideAllSubMenu();
        }

        private void sbmSettings_Click(object sender, EventArgs e)
        {
            sbmAdministrator.Checked = false;
            sbmDashboard.Checked = false;
            sbmExam.Checked = false;
            sbmInformations.Checked = false;
            sbmTransactions.Checked = false;
        }

        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {
            siticoneShadowForm.SetShadowForm(this);
            sbmDashboard_Click(null, null);
        }
    }
}
