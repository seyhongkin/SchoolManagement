using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Utils
{
    internal class FileUtil
    {
        public static string GetImagePath()
        {
            string imageDir = Application.StartupPath + "\\Images\\";
            if (!System.IO.Directory.Exists(imageDir))
            {
                System.IO.Directory.CreateDirectory(imageDir);
            }
            return imageDir;
        }
    }
}
