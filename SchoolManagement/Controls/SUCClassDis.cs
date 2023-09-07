﻿using Siticone.UI.WinForms;
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
    public partial class SUCClassDis : UserControl
    {
        private SiticoneButton btn;
        public SUCClassDis()
        {
            InitializeComponent();
        }

        public SUCClassDis(SiticoneButton btn)
        {
            this.btn = btn;
            InitializeComponent();
        }

        private void sdgvDis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn.Checked = true;
        }
    }
}
