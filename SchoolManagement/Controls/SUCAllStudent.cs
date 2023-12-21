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
    public partial class SUCAllStudent : UserControl
    {
        private SiticoneButton btn;
        public long sid = -1;
        public SUCAllStudent()
        {
            InitializeComponent();
        }

        public SUCAllStudent(SiticoneButton btn)
        {
            this.btn = btn;
            InitializeComponent();
        }

        private void sdgvDis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            sid = long.Parse(sdgvDis.SelectedRows[0].Cells[0].Value.ToString());
            if (btn != null) btn.Checked = true;
        }
    }
}
