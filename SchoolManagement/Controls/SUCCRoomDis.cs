using Siticone.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Controls
{
    public partial class SUCCRoomDis : UserControl
    {
        private SiticoneButton btn;
        public string clrid = "";
        public SUCCRoomDis()
        {
            InitializeComponent();
        }

        public SUCCRoomDis(SiticoneButton btn)
        {
            this.btn = btn;
            InitializeComponent();
        }

        private void sdgvDis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sdgvDis.SelectedRows.Count < 1) return;
            clrid = sdgvDis.SelectedRows[0].Cells[0].Value.ToString();
            this.btn.Checked = true;
        }
    }
}
