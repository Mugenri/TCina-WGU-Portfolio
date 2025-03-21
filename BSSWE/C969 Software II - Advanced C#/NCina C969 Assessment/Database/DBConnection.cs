using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NCina_C969_Assessment.Database
{
    public class DBConnection
    {
        public static MySqlConnection DBConn { get; set; }

        public static void OpenConnection()
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
                DBConn = new MySqlConnection(constr);

                DBConn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static void CloseConnection()
        {
            try
            {
                if (DBConn != null)
                {
                    DBConn.Close();
                }
                DBConn = null;
            }
            catch (MySqlException ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
