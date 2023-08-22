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

        private void HideAllSubMenu()
        {
            spSubAdministrator.Visible = false;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            siticoneShadowForm.SetShadowForm(this);
            ImageService imageService = new ImageService();
            imageService.UploadImage($"{Application.StartupPath}\\photo1.jpg");
            Image img = imageService.LoadImageDrive("1UxFKyHSjwXoJ4l7TGpgZ645JKc0Tv9OK");
            pictureBox1.Image = img;
        }

        private void spbSlide_Click(object sender, EventArgs e)
        {
            spMenu.Width = spMenu.Width == 200 ? 55 : 200;
            spbSlide.Image = spMenu.Width == 200 ? Properties.Resources.logo_frm : Properties.Resources.s_logo;
        }

        private void sbmAdministrator_Click(object sender, EventArgs e)
        {
            spSubAdministrator.Visible = spSubAdministrator.Visible ? false : true;
        }

        private void sbmDashboard_CheckedChanged(object sender, EventArgs e)
        {
            HideAllSubMenu();
        }

        private void spSubAdministrator_VisibleChanged(object sender, EventArgs e)
        {
            if (spSubAdministrator.Visible) smAdminUser.Checked = true;
        }
    }
}
