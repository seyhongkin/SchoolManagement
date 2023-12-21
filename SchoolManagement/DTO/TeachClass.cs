using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DTO
{
    internal class TeachClass
    {
        public long Id { get; set; }
        public long Cid { get; set; }
        public string CTitle { get; set; }
        public string Clrid { get; set; }
        public string ClrType { get; set; }
        public long Tid { get; set; }
        public string TNameEng { get; set; }
        public string TNameKh { get; set; }
        public string Section { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
