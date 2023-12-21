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

namespace SchoolManagement.Controls
{
    public partial class UCClassroom : UserControl
    {
        private ClassroomService classroomService = new ClassroomService();
        private Dictionary<string, Classroom> classrooms;
        public UCClassroom()
        {
            InitializeComponent();
        }

        private void sbAllCRoom_Click(object sender, EventArgs e)
        {
            succRoomDis1.BringToFront();
        }

        private void succRoomCreate1_Load(object sender, EventArgs e)
        {
            sbAllCRoom_Click(null, null);
        }

        private void sbRegister_Click(object sender, EventArgs e)
        {
            succRoomCreate1.BringToFront();
        }

        private void UCClassroom_Load(object sender, EventArgs e)
        {
            classrooms = classroomService.GetAll();
            succRoomDis1.sdgvDis.Rows.Clear();
            foreach (var c in classrooms.Values)
            {
                succRoomDis1.sdgvDis.Rows.Add(c.Number, c.Type);
            }
        }

        private void sbAllCRoom_DoubleClick(object sender, EventArgs e)
        {
            UCClassroom_Load(null, null);
        }

        private void sbRegister_CheckedChanged(object sender, EventArgs e)
        {
            string clrid = succRoomDis1.clrid;
            succRoomCreate1.BringToFront();
            if (clrid == "") return;

            succRoomCreate1.sbDelete.Visible = true;
            succRoomCreate1.lbMsg.Text = "";
            succRoomCreate1.updated = true;
            succRoomCreate1.prevNum = classrooms[clrid].Number;
            succRoomCreate1.stxtNumber.Text = classrooms[clrid].Number;
            succRoomCreate1.scbType.SelectedIndex = classrooms[clrid].Type.ToLower() == "computer room" ? 0 : 1;

        }
    }
}
