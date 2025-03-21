using System;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Globalization;
using System.Threading;
using NCina_C969_Assessment.Database;

namespace NCina_C969_Assessment
{
    public partial class Login : Form
    {
        public static StreamWriter writer;

        public Login()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Thread.CurrentThread.CurrentCulture.ToString());
            InitializeComponent();
            FileStream stream = new FileStream(Environment.CurrentDirectory + "\\..\\..\\login_log.txt", FileMode.Append, FileAccess.Write);
            writer = new StreamWriter(stream); //in solution root folder
            writer.AutoFlush = true;
        }

        #region Events
        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = nameBox.Text;
            string password = passwordBox.Text;

            //write login time to txt
            writer.Write($"Attempted Login: {DateTime.Now.ToUniversalTime()} ");

            //DB query for username/password matches
            string sqlCommand = "SELECT userId, userName, password FROM user";
            DataTable table = DBOperations.GetSqlTable(sqlCommand);

            foreach (DataRow row in table.Rows)
            {
                if (row["username"].ToString() == username && row["password"].ToString() == password) //valid username/password combination
                {
                    writer.WriteLine($"to account {username} was successful.");

                    //log in, pass userID to homepage
                    int userId = int.Parse(row["userID"].ToString());
                    string userName = row["userName"].ToString();
                    new Home(userId, userName).Show();
                    Hide();
                    return;
                }
            }
            writer.WriteLine($"failed.");
            MessageBox.Show(Properties.Resources.errorCaption, Properties.Resources.errorHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

    }
}
