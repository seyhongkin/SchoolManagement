using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using MySql.Data.MySqlClient;
using SchoolManagement.WebServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    internal static class Program
    {
        private static readonly string appPath = Application.StartupPath;

        public static string AppPath
        {
            get {
                string modifiedString = appPath.Replace("\\bin\\Debug", "");
                return modifiedString; 
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connectionString = "server=bdf900zujydtiz9sasvh-mysql.services.clever-cloud.com;user id=uifearpbnxfbfmaq;password=IhwFbdfLsly0LDaA65ec;database=bdf900zujydtiz9sasvh;";

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Connected to MySQL database!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
