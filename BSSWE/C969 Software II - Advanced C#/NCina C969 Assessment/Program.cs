using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCina_C969_Assessment.Database;

namespace NCina_C969_Assessment
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DBConnection.OpenConnection();
            Application.Run(new Login());
            DBConnection.CloseConnection();
        }
    }
}
