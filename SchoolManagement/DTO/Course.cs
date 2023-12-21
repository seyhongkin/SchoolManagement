using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DTO
{
    internal class Course
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public double PriceMonth { get; set; }
        public double FullPrice { get; set; }
        public int Discount { get; set; }
        public double Duration { get; set; }
        public string Description { get; set; }
    }
}
