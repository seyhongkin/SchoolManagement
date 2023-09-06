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
    public partial class SUCCRoomCreate : UserControl
    {
        public SUCCRoomCreate()
        {
            InitializeComponent();
        }

        private void SUCCRoomCreate_Load(object sender, EventArgs e)
        {
            scbType.SelectedIndex = 0;
        }
    }
}
