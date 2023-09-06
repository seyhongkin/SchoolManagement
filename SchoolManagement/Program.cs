using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using MySql.Data.MySqlClient;
using SchoolManagement.WebServices;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    internal static class Program
    {
        private static string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=schoolmanagementdb.mdb;Jet OLEDB:Database Password=我爱你";
        public static OleDbConnection connection = new OleDbConnection(connectionString);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*  CONNECTING HOSTING MYSQL
            string connectionString = "server=bdf900zujydtiz9sasvh-mysql.services.clever-cloud.com;user id=uifearpbnxfbfmaq;password=IhwFbdfLsly0LDaA65ec;database=bdf900zujydtiz9sasvh;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            */
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("[ERROR:DATABASE] " + ex);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
