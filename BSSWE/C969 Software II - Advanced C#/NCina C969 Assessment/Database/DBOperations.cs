using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace NCina_C969_Assessment.Database
{
    public static class DBOperations
    {
        private static Func<string, int> nonQuery = str => //Lambda to cut down a lot of lines wasted on repetitive actions
        {
            MySqlCommand cmd = new MySqlCommand(str, DBConnection.DBConn);
            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;
        };

        #region Helper Functions
        //Get data adapter
        public static DataTable GetSqlTable (string sqlCommand)
        {
            MySqlCommand cmd = new MySqlCommand(sqlCommand, DBConnection.DBConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        #endregion

        #region Customer Records Functions
        //Add, Update, Delete Customer Records
        public static void AddCustomer(string name, string phone, string address1, string address2, string zipcode, string city, string country, string createdBy)
        {
            //insert into country, get new ID
            string sqlCommand = "INSERT INTO country " +
                $"VALUES (NULL, \"{country}\", CURRENT_TIME, \"{createdBy}\", CURRENT_TIME, \"{createdBy}\");";
            int countryId = nonQuery(sqlCommand);

            //insert into city, get new ID
            sqlCommand = "INSERT INTO city " +
                $"VALUES (NULL, \"{city}\", {countryId}, CURRENT_TIME, \"{createdBy}\", CURRENT_TIME, \"{createdBy}\");";
            int cityId = nonQuery(sqlCommand);

            //insert into address, get new ID
            sqlCommand = "INSERT INTO address " +
                $"VALUES (NULL, \"{address1}\", \"{address2}\", {cityId}, \"{zipcode}\", \"{phone}\", CURRENT_TIME, \"{createdBy}\", CURRENT_TIME, \"{createdBy}\");";
            int addressId = nonQuery(sqlCommand);

            //insert into customer
            sqlCommand = "INSERT INTO customer " +
                $"VALUES (NULL, \"{name}\", {addressId}, 1, CURRENT_TIME, \"{createdBy}\", CURRENT_TIME, \"{createdBy}\");";
            nonQuery(sqlCommand);
        }

        public static void UpdateCustomer(int customerId, string name, string phone, string address1, string address2, string zipcode, string city, string country, string updatedBy)
        {
            //Get table with relevant information
            string sqlCommand = "SELECT c.addressId, a.cityId, ci.countryId " +
                "FROM customer AS c " +
                "INNER JOIN address AS a ON c.addressId = a.addressId " +
                "INNER JOIN city AS ci ON a.cityId = ci.cityId " +
                $"WHERE customerId = \"{customerId}\";";
            DataTable dt = GetSqlTable(sqlCommand);

            int addressId = (int)dt.Rows[0]["addressId"];
            int cityId = (int)dt.Rows[0]["cityId"];
            int countryId = (int)dt.Rows[0]["countryId"];

            //update country
            sqlCommand = "UPDATE country " +
                $"SET country = \"{country}\", lastUpdate = CURRENT_TIME, lastUpdateBy = \"{updatedBy}\" " +
                $"WHERE countryId = \"{countryId}\";";
            nonQuery(sqlCommand);

            //update City
            sqlCommand = "UPDATE city " +
                $"SET city = \"{city}\", lastUpdate = CURRENT_TIME, lastUpdateBy = \"{updatedBy}\" " +
                $"WHERE cityId = \"{cityId}\";";
            nonQuery(sqlCommand);

            //update Address
            sqlCommand = "UPDATE address " +
                $"SET address = \"{address1}\", address2 = \"{address2}\", postalCode = \"{zipcode}\", phone = \"{phone}\", lastUpdate = CURRENT_TIME, lastUpdateBy = \"{updatedBy}\" " +
                $"WHERE addressId = \"{addressId}\";";
            nonQuery(sqlCommand);

            //update Customer
            sqlCommand = "UPDATE customer " +
                $"SET customerName = \"{name}\", lastUpdate = CURRENT_TIME, lastUpdateBy = \"{updatedBy}\" " +
                $"WHERE customerId = \"{customerId}\";";
            nonQuery(sqlCommand);
        }

        public static void DeleteCustomer(int customerId)
        {
            //check all appointments with the customer id and delete first.
            string sqlCommand = $"DELETE FROM appointment WHERE customerId = {customerId}";
            nonQuery(sqlCommand);
            //delete customer
            sqlCommand = $"DELETE FROM customer WHERE customerId = {customerId};";
            nonQuery(sqlCommand);
        }
        #endregion

        #region Appointment Records Functions
        //Add, Update, Delete Appointments
        public static void AddAppointment(int customerId, int userId, string apptType, DateTime startDate, DateTime endDate, string createdBy)
        {
            //UTC conversion
            startDate = startDate.ToUniversalTime();
            endDate = endDate.ToUniversalTime();
            //Add appointment
            string sqlCommand = $"INSERT INTO appointment " +
                $"VALUES (NULL, {customerId}, {userId}, \"title\", \"description\", \"location\", \"contact\", \"{apptType}\", \"url\", " +
                $"\"{startDate.ToString("yyyy-MM-dd HH:mm:ss")}\", \"{endDate.ToString("yyyy-MM-dd HH:mm:ss")}\", CURRENT_TIME, \"{createdBy}\", CURRENT_TIME, \"{createdBy}\");";
            nonQuery(sqlCommand);
        }

        public static void UpdateAppointment(int apptId, int customerId, int userId, string apptType, DateTime startDate, DateTime endDate, string updatedBy)
        {
            //UTC conversion
            startDate = startDate.ToUniversalTime();
            endDate = endDate.ToUniversalTime();
            //update
            string sqlCommand = "UPDATE appointment " +
                $"SET customerId = \"{customerId}\", userId = \"{userId}\", type = \"{apptType}\", start = \"{startDate.ToString("yyyy-MM-dd HH:mm:ss")}\", " +
                $"end = \"{endDate.ToString("yyyy-MM-dd HH:mm:ss")}\", lastUpdate = CURRENT_TIME, lastUpdateBy = \"{updatedBy}\" " +
                $"WHERE appointmentId = \"{apptId}\";";
            nonQuery(sqlCommand);
        }

        public static void DeleteAppointment(int appointmentId)
        {
            string sqlCommand = $"DELETE FROM appointment WHERE appointmentId = {appointmentId};";
            nonQuery(sqlCommand);
        }
        #endregion
    }
}
