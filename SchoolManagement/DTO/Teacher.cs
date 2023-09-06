using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DTO
{
    internal class Teacher
    {
        public long Tid { get; set; }
        public string NameEng { get; set; }
        public string NameKh { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string imgPath { get; set; }
    }
}
