using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TonaireDigital_Report
{
    internal static partial class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //
            if (OpenConnection() == true)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                Application.Exit();
               
            }
        }
        public static bool OpenConnection()
        {
            try
            {
                Connection.Open();
                Connection.Close();
                return true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error > {ex.Message}");
                Logger.LogError($"SQL Error: {ex.Message}\nStackTrace: {ex.StackTrace}");
                return false;
            }
        }
        public static class Logger
        {
            public static void LogError(string message)
            {
                    
                string logDirectory = "logs";
                string logFile = Path.Combine(logDirectory, "errors.txt");

                // Create the directory if it doesn't exist
                if (!Directory.Exists(logDirectory))
                {
                    Directory.CreateDirectory(logDirectory);
                }
                string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}{Environment.NewLine}";

                // Write to the file (append mode)
                File.AppendAllText(logFile, logMessage);
                Console.WriteLine($"Logged to: {Path.GetFullPath(logFile)}");
            }
        }

            public static SqlConnection Connection = new SqlConnection(@"server=DESKTOP-KPD5D9S\MSSQLSEVER2022;database=dbC#;
            user id=immora; password=mora123; encrypt=false");
    }
}
