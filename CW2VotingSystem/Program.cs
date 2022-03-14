using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CW2VotingSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Database.connection = Database.database.CreateDatabaseConnection($"{Directory.GetCurrentDirectory()}\\Database.db");
            Database.database.InitialiseDatabase();
            Application.Run(new frmLogin());
        }
    }
}
