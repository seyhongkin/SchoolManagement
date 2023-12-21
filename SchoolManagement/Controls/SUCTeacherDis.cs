using SchoolManagement.DTO;
using SchoolManagement.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace SchoolManagement.Controls
{
    public partial class SUCTeacherDis : UserControl
    {
        private SiticoneButton regist;
        public DataGridViewRow row;

        public SUCTeacherDis()
        {
            InitializeComponent();
        }

        public SUCTeacherDis(SiticoneButton registBtn)
        {
            this.regist = registBtn;
            InitializeComponent();
        }

        private void SUCTeacherDis_Load(object sender, EventArgs e)
        {
            

        }

        private void sdgvDis_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sdgvDis.SelectedRows.Count < 1) return;
            this.row = sdgvDis.SelectedRows[0];
            regist.Checked = true;
        }
    }
}
