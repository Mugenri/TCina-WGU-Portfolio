using NCina_C969_Assessment.Database;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace NCina_C969_Assessment
{
    public partial class Home : Form
    {
        private static int UserID;
        private static string UserName;
        private static DataTable custTable; //customer table (name, phone, address, city, country)
        private static DataTable apptTable; //appointment table (appt id, customer name, user name, appt type, start time, end time)
        private static DataTable userTable; //user ID table
        public Home(int userId, string userName)
        {
            UserID = userId;
            UserName = userName;
            InitializeComponent();

            UpdateCustomerTable();
            UpdateAppointmentTable();

            //populate consultant schedule combobox
            userTable = DBOperations.GetSqlTable("SELECT userId FROM user");
            foreach (DataRow row in userTable.Rows)
            {
                consultantPicker.Items.Add((int)row["userId"]);
            }
            consultantPicker.Text = UserID.ToString();

            //hide unused columns
            customerList.Columns["address2"].Visible = false;
            customerList.Columns["postalCode"].Visible = false;
            appointmentList.Columns["customerId"].Visible = false;
            appointmentList.Columns["userId"].Visible = false;
            appointmentList.Columns["month"].Visible = false;
            appointmentList.Columns["week"].Visible = false;

            //format appointment date/time pickers
            appointmentStartTimeBox.CustomFormat = "'Start:' hh:mm tt";
            appointmentEndTimeBox.CustomFormat = "'End:' hh:mm tt";
        }

        #region Helper Functions
        //TODO function for checking for appointments in the next 15 minutes since login time (get time, convert to UTC, check against db)

        private void UpdateCustomerTable()
        {
            string sqlstr = "SELECT customerId AS ID, customerName AS Name, phone AS Phone, address AS Address, address2, postalCode, city AS City, country AS Country " +
                "FROM customer AS c " +
                "INNER JOIN address AS a ON c.addressId = a.addressId " +
                "INNER JOIN city AS ci ON a.cityId = ci.cityId " +
                "INNER JOIN country AS co ON ci.countryId = co.countryId;";
            custTable = DBOperations.GetSqlTable(sqlstr);
            customerList.DataSource = custTable;
        }

        private void UpdateAppointmentTable()
        {
            string sqlstr = "SELECT appointmentId AS ID, a.customerId, a.userId, customerName AS Customer, userName AS Consultant, type AS Type, start as Start, end AS End, MONTH(Start) AS month, WEEK(Start, 4) AS week " +
                "FROM appointment AS a " +
                "INNER JOIN customer AS c ON a.customerId = c.customerId " +
                "INNER JOIN user AS u ON a.userId = u.userId " +
                "ORDER BY Start;";
            apptTable = DBOperations.GetSqlTable(sqlstr);

            foreach (DataRow row in apptTable.Rows) //adjust to local time
            {
                DateTime start = (DateTime)row["Start"];
                row["start"] = start.ToLocalTime();
                DateTime end = (DateTime)row["End"];
                row["end"] = end.ToLocalTime();
            }
            
            appointmentList.DataSource = apptTable;
            UpdateReports();
        }

        private void AppointmentAlert(int id) //15 Minute alert
        {
            DateTime currentTime = DateTime.Now;
            foreach (DataRow row in apptTable.Rows)
            {
                if ((int)row["userId"] != id)
                {
                    continue;
                }
                DateTime startTime = (DateTime)row["Start"];
                TimeSpan timeToAppointment = startTime - currentTime;
                if (timeToAppointment.TotalSeconds > 0 && timeToAppointment.TotalSeconds < 900)
                {
                    MessageBox.Show($"Upcoming appointment \"{row["Type"]}\" at {startTime.TimeOfDay}", "Upcoming Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void ValidateCustomerFields()
        {
            //Box Colors
            _ = customerNameBox.Text == "" ? customerNameBox.BackColor = Color.LightSalmon : customerNameBox.BackColor = Color.White;
            _ = customerPhoneBox.Text == "" ? customerPhoneBox.BackColor = Color.LightSalmon : customerPhoneBox.BackColor = Color.White;
            _ = customerAddressBox.Text == "" ? customerAddressBox.BackColor = Color.LightSalmon : customerAddressBox.BackColor = Color.White;
            _ = customerAddressBox.Text == "" ? customerAddress2Box.BackColor = Color.LightSalmon : customerAddress2Box.BackColor = Color.White;
            _ = customerZipBox.Text == "" ? customerZipBox.BackColor = Color.LightSalmon : customerZipBox.BackColor = Color.White;
            _ = customerCityBox.Text == "" ? customerCityBox.BackColor = Color.LightSalmon : customerCityBox.BackColor = Color.White;
            _ = customerCountryBox.Text == "" ? customerCountryBox.BackColor = Color.LightSalmon : customerCountryBox.BackColor = Color.White;

            //Exceptions
            if (customerNameBox.Text == "")
            {
                throw new Exception("Customer name required.");
            }

            if (customerPhoneBox.Text == "")
            {
                throw new Exception("Customer phone number required.");
            }

            if (customerAddressBox.Text == "")
            {
                throw new Exception("Customer address required.");
            }

            if (customerZipBox.Text == "")
            {
                throw new Exception("Customer zipcode required.");
            }

            if (customerCityBox.Text == "")
            {
                throw new Exception("Customer city required.");
            }

            if (customerCountryBox.Text == "")
            {
                throw new Exception("Customer country required.");
            }
        }

        private void ValidateAppointmentFields(int excludeId = -1)
        {
            //Box Colors
            _ = appointmentCustomerBox.Text == "" || !appointmentCustomerBox.Text.All(char.IsDigit) ? appointmentCustomerBox.BackColor = Color.LightSalmon : appointmentCustomerBox.BackColor = Color.White;
            _ = appointmentUserBox.Text == "" || !appointmentUserBox.Text.All(char.IsDigit) ? appointmentUserBox.BackColor = Color.LightSalmon : appointmentUserBox.BackColor = Color.White;
            _ = appointmentTypeBox.Text == "" ? appointmentTypeBox.BackColor = Color.LightSalmon : appointmentTypeBox.BackColor = Color.White;

            //Exceptions
            if (appointmentCustomerBox.Text == "")
            {
                throw new Exception("Customer ID required.");
            }

            if (!appointmentCustomerBox.Text.All(char.IsDigit))
            {
                throw new Exception("Customer ID must be an integer.");
            }

            //validate customer ID exists
            bool idExists = false;
            foreach (DataRow row in custTable.Rows)
            {
                if (row["ID"].ToString() == appointmentCustomerBox.Text)
                {
                    idExists = true;
                    break;
                }
            }
            if (!idExists)
            {
                throw new Exception("Customer ID not found");
            }

            if (appointmentUserBox.Text == "")
            {
                throw new Exception("Consultant ID required.");
            }

            //validate user ID exists
            idExists = false;
            foreach (DataRow row in userTable.Rows)
            {
                if (row["userId"].ToString() == appointmentUserBox.Text)
                {
                    idExists = true;
                    break;
                }
            }
            if(!idExists)
            {
                throw new Exception("Consultant ID not found");
            }

            if (!appointmentUserBox.Text.All(char.IsDigit))
            {
                throw new Exception("Consultant ID must be an integer.");
            }

            if (appointmentTypeBox.Text == "")
            {
                throw new Exception("Appointment Type required.");
            }

            //Date Exceptions
            DateTime date = appointmentDateBox.Value.Date;
            TimeSpan start = appointmentStartTimeBox.Value.TimeOfDay;
            TimeSpan end = appointmentEndTimeBox.Value.TimeOfDay;

            if (start < TimeSpan.Parse("9:00") || start > TimeSpan.Parse("17:00") || end < TimeSpan.Parse("9:00") || end > TimeSpan.Parse("17:00"))
            {
                throw new Exception("Appointment times must be scheduled between 9:00 AM and 5:00 PM");
            }
            if (date + start >= date + end)
            {
                throw new Exception("Appointment start time must be before appointment end time.");
            }
            
            //check overlapping appointment times per user and customer (times in apptTable are in local time)
            foreach (DataRow row in apptTable.Rows)
            {
                int apptId = (int)row["ID"]; //Don't compare against appointment being updated
                if (apptId == excludeId)
                {
                    continue;
                }

                int customerId = (int)row["customerId"];
                int userId = (int)row["userId"];
                DateTime startDate = (DateTime)row["Start"];
                DateTime endDate = (DateTime)row["End"];

                //overlapping start/end dates on same user/customer id
                //start date is between range, or end date is between range, or start and end are on opposite ends of the range per user/customer id
                if ((date + start >= startDate && date + start <= endDate
                    || date + end >= startDate && date + end <= endDate
                    || date + start <= startDate && date + end >= endDate)
                    && ((userId == int.Parse(appointmentUserBox.Text) || customerId == int.Parse(appointmentCustomerBox.Text))))
                {
                    throw new Exception("Appointment times for individual customers/consultants cannot overlap.");
                }
            }
        }
        #endregion

        #region Customer Button Events
        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateCustomerFields();
                DBOperations.AddCustomer(customerNameBox.Text, customerPhoneBox.Text, customerAddressBox.Text, customerAddress2Box.Text,
                    customerZipBox.Text, customerCityBox.Text, customerCountryBox.Text, UserName);
                UpdateCustomerTable();
                customerList.ClearSelection();
                MessageBox.Show($"Registered new customer {customerNameBox.Text}.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateCustomerFields();
                int customerId;
                if (customerList.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = customerList.SelectedRows[0];
                    customerId = (int)row.Cells["ID"].Value;
                    DBOperations.UpdateCustomer(customerId, customerNameBox.Text, customerPhoneBox.Text, customerAddressBox.Text, customerAddress2Box.Text,
                    customerZipBox.Text, customerCityBox.Text, customerCountryBox.Text, UserName);
                    UpdateCustomerTable();
                    customerList.ClearSelection();
                    MessageBox.Show($"Updated customer ID {customerId}.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No customer selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            //delete selected row
            try
            {
                if (customerList.SelectedRows.Count > 0)
                {
                    DataRowView row = (DataRowView)customerList.CurrentRow.DataBoundItem;
                    int id = (int)row.Row[0];
                    //confirm delete
                    DialogResult res = MessageBox.Show($"Delete Customer ID {id} and all associated appointments?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        DBOperations.DeleteCustomer(id);
                        UpdateCustomerTable();
                        UpdateAppointmentTable();
                        customerList.ClearSelection();
                        appointmentList.ClearSelection();
                    }
                }
                else
                {
                    MessageBox.Show("No customer selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void customerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataRowView row = (DataRowView)customerList.Rows[e.RowIndex].DataBoundItem;
            customerNameBox.Text = (string)row.Row["Name"];
            customerPhoneBox.Text = (string)row.Row["Phone"];
            customerAddressBox.Text = (string)row.Row["Address"];
            customerAddress2Box.Text = (string)row.Row["address2"];
            customerZipBox.Text = (string)row.Row["postalCode"];
            customerCityBox.Text = (string)row.Row["City"];
            customerCountryBox.Text = (string)row.Row["Country"];
        }
        #endregion

        #region Appointment Button Events
        private void addAppointmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateAppointmentFields();
                DBOperations.AddAppointment(int.Parse(appointmentCustomerBox.Text), int.Parse(appointmentUserBox.Text), appointmentTypeBox.Text,
                    appointmentDateBox.Value.Date + appointmentStartTimeBox.Value.TimeOfDay,
                    appointmentDateBox.Value.Date + appointmentEndTimeBox.Value.TimeOfDay, UserName);
                UpdateAppointmentTable();
                appointmentList.ClearSelection();
                MessageBox.Show($"Registered new {appointmentTypeBox.Text} appointment.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateAppointmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (appointmentList.SelectedRows.Count > 0)
                {
                    DataRowView row = (DataRowView)appointmentList.CurrentRow.DataBoundItem;
                    int apptId = (int)row.Row[0];
                    ValidateAppointmentFields(apptId);
                    DBOperations.UpdateAppointment(apptId, int.Parse(appointmentCustomerBox.Text), int.Parse(appointmentUserBox.Text), appointmentTypeBox.Text,
                    appointmentDateBox.Value.Date + appointmentStartTimeBox.Value.TimeOfDay,
                    appointmentDateBox.Value.Date + appointmentEndTimeBox.Value.TimeOfDay, UserName);
                    UpdateAppointmentTable();
                    appointmentList.ClearSelection();
                    MessageBox.Show($"Updated appointment ID {apptId}.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No appointment selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteAppointmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (customerList.SelectedRows.Count > 0)
                {
                    DataRowView row = (DataRowView)appointmentList.CurrentRow.DataBoundItem;
                    int id = (int)row.Row[0];
                    //confirm delete
                    DialogResult res = MessageBox.Show($"Delete Appointment ID {id}?", "Delete Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        DBOperations.DeleteAppointment(id);
                        UpdateAppointmentTable();
                        appointmentList.ClearSelection();
                    }
                }
                else
                {
                    MessageBox.Show("No appointment selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void appointmentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataRowView row = (DataRowView)appointmentList.Rows[e.RowIndex].DataBoundItem;
            appointmentCustomerBox.Text = row.Row["customerId"].ToString();
            appointmentUserBox.Text = row.Row["userId"].ToString();
            appointmentTypeBox.Text = (string)row.Row["Type"];
            appointmentDateBox.Value = ((DateTime)row.Row["Start"]).Date;
            appointmentStartTimeBox.Value = (DateTime)row.Row["Start"];
            appointmentEndTimeBox.Value = (DateTime)row.Row["End"];
        }
        #endregion

        #region Reports
        private void UpdateReports()
        {
            //Total appointments
            reportTotalLabel.Text = $"Total Appointments: {apptTable.Rows.Count}";

            //Appointments of given type
            int apptCount = 0;
            DateTime date = DateTime.Now;
            foreach (DataRow row in apptTable.Rows)
            {
                if (row["Type"].ToString().ToLower() == reportTypeBox.Text.ToLower() && date.Month == (int)row["month"])
                {
                    apptCount++;
                }
            }
            reportTypeInfoLabel.Text = $"appointments this month: {apptCount}";
        }

        private void reportTypeBox_TextChanged(object sender, EventArgs e)
        {
            UpdateReports();
        }

        private void appointmentFilters_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //get selected button
                Func<RadioButton, bool> isChecked = radio => radio.Checked; //FirstOrDefault function requires a lambda as a parameter
                string radioName = Controls.OfType<RadioButton>().FirstOrDefault(isChecked).Name;

                DateTime date = appointmentFilterDate.Value.Date;

                switch (radioName)
                {
                    case "allRadio":
                        apptTable.DefaultView.RowFilter = ""; //no filter
                        break;

                    case "monthlyRadio":
                        int month = date.Month;
                        apptTable.DefaultView.RowFilter = $"month = '{month}'";
                        break;

                    case "weeklyRadio":
                        int week = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Sunday);
                        apptTable.DefaultView.RowFilter = $"week = '{week}'";
                        break;

                    case "consultantRadio":
                        string user = consultantPicker.Text;
                        apptTable.DefaultView.RowFilter = $"userId = '{user}'";
                        break;
                
                }

                appointmentList.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region General Events
        private void Home_Load(object sender, EventArgs e)
        {
            //Check for alerts
            AppointmentAlert(UserID);
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
