namespace NCina_C969_Assessment
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customerList = new System.Windows.Forms.DataGridView();
            this.appointmentList = new System.Windows.Forms.DataGridView();
            this.customerLabel = new System.Windows.Forms.Label();
            this.appointmentLabel = new System.Windows.Forms.Label();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.updateCustomerButton = new System.Windows.Forms.Button();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.deleteAppointmentButton = new System.Windows.Forms.Button();
            this.updateAppointmentButton = new System.Windows.Forms.Button();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerPhoneLabel = new System.Windows.Forms.Label();
            this.customerAddressLabel = new System.Windows.Forms.Label();
            this.customerCityLabel = new System.Windows.Forms.Label();
            this.customerCountryLabel = new System.Windows.Forms.Label();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.customerPhoneBox = new System.Windows.Forms.TextBox();
            this.customerAddressBox = new System.Windows.Forms.TextBox();
            this.customerCityBox = new System.Windows.Forms.TextBox();
            this.customerCountryBox = new System.Windows.Forms.TextBox();
            this.customerAddress2Box = new System.Windows.Forms.TextBox();
            this.customerAddress2Label = new System.Windows.Forms.Label();
            this.customerZipBox = new System.Windows.Forms.TextBox();
            this.customerZipLabel = new System.Windows.Forms.Label();
            this.appointmentDateBox = new System.Windows.Forms.DateTimePicker();
            this.appointmentStartTimeBox = new System.Windows.Forms.DateTimePicker();
            this.appointmentEndTimeBox = new System.Windows.Forms.DateTimePicker();
            this.appointmentCustomerBox = new System.Windows.Forms.TextBox();
            this.appointmentUserBox = new System.Windows.Forms.TextBox();
            this.appointmentTypeBox = new System.Windows.Forms.TextBox();
            this.appointmentCustomerLabel = new System.Windows.Forms.Label();
            this.appointmentUserLabel = new System.Windows.Forms.Label();
            this.appointmentTypeLabel = new System.Windows.Forms.Label();
            this.appointmentDateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.allRadio = new System.Windows.Forms.RadioButton();
            this.monthlyRadio = new System.Windows.Forms.RadioButton();
            this.weeklyRadio = new System.Windows.Forms.RadioButton();
            this.consultantRadio = new System.Windows.Forms.RadioButton();
            this.consultantPicker = new System.Windows.Forms.ComboBox();
            this.appointmentFilterDate = new System.Windows.Forms.DateTimePicker();
            this.reportsBox = new System.Windows.Forms.GroupBox();
            this.reportTypeInfoLabel = new System.Windows.Forms.Label();
            this.reportTypeBox = new System.Windows.Forms.TextBox();
            this.reportTypeLabel = new System.Windows.Forms.Label();
            this.reportTotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentList)).BeginInit();
            this.reportsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerList
            // 
            this.customerList.AllowUserToAddRows = false;
            this.customerList.AllowUserToDeleteRows = false;
            this.customerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerList.Location = new System.Drawing.Point(12, 32);
            this.customerList.MultiSelect = false;
            this.customerList.Name = "customerList";
            this.customerList.ReadOnly = true;
            this.customerList.RowHeadersVisible = false;
            this.customerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerList.ShowEditingIcon = false;
            this.customerList.Size = new System.Drawing.Size(750, 220);
            this.customerList.TabIndex = 0;
            this.customerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerList_CellClick);
            // 
            // appointmentList
            // 
            this.appointmentList.AllowUserToAddRows = false;
            this.appointmentList.AllowUserToDeleteRows = false;
            this.appointmentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentList.Location = new System.Drawing.Point(12, 304);
            this.appointmentList.MultiSelect = false;
            this.appointmentList.Name = "appointmentList";
            this.appointmentList.ReadOnly = true;
            this.appointmentList.RowHeadersVisible = false;
            this.appointmentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentList.ShowEditingIcon = false;
            this.appointmentList.Size = new System.Drawing.Size(750, 220);
            this.appointmentList.TabIndex = 1;
            this.appointmentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentList_CellClick);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(12, 9);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(86, 20);
            this.customerLabel.TabIndex = 2;
            this.customerLabel.Text = "Customers";
            // 
            // appointmentLabel
            // 
            this.appointmentLabel.AutoSize = true;
            this.appointmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentLabel.Location = new System.Drawing.Point(12, 281);
            this.appointmentLabel.Name = "appointmentLabel";
            this.appointmentLabel.Size = new System.Drawing.Size(108, 20);
            this.appointmentLabel.TabIndex = 3;
            this.appointmentLabel.Text = "Appointments";
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(1097, 32);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.addCustomerButton.TabIndex = 4;
            this.addCustomerButton.Text = "Add";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // updateCustomerButton
            // 
            this.updateCustomerButton.Location = new System.Drawing.Point(1097, 61);
            this.updateCustomerButton.Name = "updateCustomerButton";
            this.updateCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.updateCustomerButton.TabIndex = 5;
            this.updateCustomerButton.Text = "Update";
            this.updateCustomerButton.UseVisualStyleBackColor = true;
            this.updateCustomerButton.Click += new System.EventHandler(this.updateCustomerButton_Click);
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.Location = new System.Drawing.Point(1097, 90);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.deleteCustomerButton.TabIndex = 6;
            this.deleteCustomerButton.Text = "Delete";
            this.deleteCustomerButton.UseVisualStyleBackColor = true;
            this.deleteCustomerButton.Click += new System.EventHandler(this.deleteCustomerButton_Click);
            // 
            // deleteAppointmentButton
            // 
            this.deleteAppointmentButton.Location = new System.Drawing.Point(1097, 362);
            this.deleteAppointmentButton.Name = "deleteAppointmentButton";
            this.deleteAppointmentButton.Size = new System.Drawing.Size(75, 23);
            this.deleteAppointmentButton.TabIndex = 9;
            this.deleteAppointmentButton.Text = "Delete";
            this.deleteAppointmentButton.UseVisualStyleBackColor = true;
            this.deleteAppointmentButton.Click += new System.EventHandler(this.deleteAppointmentButton_Click);
            // 
            // updateAppointmentButton
            // 
            this.updateAppointmentButton.Location = new System.Drawing.Point(1097, 333);
            this.updateAppointmentButton.Name = "updateAppointmentButton";
            this.updateAppointmentButton.Size = new System.Drawing.Size(75, 23);
            this.updateAppointmentButton.TabIndex = 8;
            this.updateAppointmentButton.Text = "Update";
            this.updateAppointmentButton.UseVisualStyleBackColor = true;
            this.updateAppointmentButton.Click += new System.EventHandler(this.updateAppointmentButton_Click);
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.Location = new System.Drawing.Point(1097, 304);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(75, 23);
            this.addAppointmentButton.TabIndex = 7;
            this.addAppointmentButton.Text = "Add";
            this.addAppointmentButton.UseVisualStyleBackColor = true;
            this.addAppointmentButton.Click += new System.EventHandler(this.addAppointmentButton_Click);
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(839, 37);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(35, 13);
            this.customerNameLabel.TabIndex = 10;
            this.customerNameLabel.Text = "Name";
            // 
            // customerPhoneLabel
            // 
            this.customerPhoneLabel.AutoSize = true;
            this.customerPhoneLabel.Location = new System.Drawing.Point(826, 66);
            this.customerPhoneLabel.Name = "customerPhoneLabel";
            this.customerPhoneLabel.Size = new System.Drawing.Size(48, 13);
            this.customerPhoneLabel.TabIndex = 11;
            this.customerPhoneLabel.Text = "Phone #";
            // 
            // customerAddressLabel
            // 
            this.customerAddressLabel.AutoSize = true;
            this.customerAddressLabel.Location = new System.Drawing.Point(829, 95);
            this.customerAddressLabel.Name = "customerAddressLabel";
            this.customerAddressLabel.Size = new System.Drawing.Size(45, 13);
            this.customerAddressLabel.TabIndex = 12;
            this.customerAddressLabel.Text = "Address";
            // 
            // customerCityLabel
            // 
            this.customerCityLabel.AutoSize = true;
            this.customerCityLabel.Location = new System.Drawing.Point(850, 182);
            this.customerCityLabel.Name = "customerCityLabel";
            this.customerCityLabel.Size = new System.Drawing.Size(24, 13);
            this.customerCityLabel.TabIndex = 13;
            this.customerCityLabel.Text = "City";
            // 
            // customerCountryLabel
            // 
            this.customerCountryLabel.AutoSize = true;
            this.customerCountryLabel.Location = new System.Drawing.Point(831, 211);
            this.customerCountryLabel.Name = "customerCountryLabel";
            this.customerCountryLabel.Size = new System.Drawing.Size(43, 13);
            this.customerCountryLabel.TabIndex = 14;
            this.customerCountryLabel.Text = "Country";
            // 
            // customerNameBox
            // 
            this.customerNameBox.Location = new System.Drawing.Point(880, 34);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(184, 20);
            this.customerNameBox.TabIndex = 15;
            // 
            // customerPhoneBox
            // 
            this.customerPhoneBox.Location = new System.Drawing.Point(880, 63);
            this.customerPhoneBox.Name = "customerPhoneBox";
            this.customerPhoneBox.Size = new System.Drawing.Size(184, 20);
            this.customerPhoneBox.TabIndex = 16;
            // 
            // customerAddressBox
            // 
            this.customerAddressBox.Location = new System.Drawing.Point(880, 92);
            this.customerAddressBox.Name = "customerAddressBox";
            this.customerAddressBox.Size = new System.Drawing.Size(184, 20);
            this.customerAddressBox.TabIndex = 17;
            // 
            // customerCityBox
            // 
            this.customerCityBox.Location = new System.Drawing.Point(880, 179);
            this.customerCityBox.Name = "customerCityBox";
            this.customerCityBox.Size = new System.Drawing.Size(184, 20);
            this.customerCityBox.TabIndex = 18;
            // 
            // customerCountryBox
            // 
            this.customerCountryBox.Location = new System.Drawing.Point(880, 208);
            this.customerCountryBox.Name = "customerCountryBox";
            this.customerCountryBox.Size = new System.Drawing.Size(184, 20);
            this.customerCountryBox.TabIndex = 19;
            // 
            // customerAddress2Box
            // 
            this.customerAddress2Box.Location = new System.Drawing.Point(880, 121);
            this.customerAddress2Box.Name = "customerAddress2Box";
            this.customerAddress2Box.Size = new System.Drawing.Size(184, 20);
            this.customerAddress2Box.TabIndex = 21;
            // 
            // customerAddress2Label
            // 
            this.customerAddress2Label.AutoSize = true;
            this.customerAddress2Label.Location = new System.Drawing.Point(820, 124);
            this.customerAddress2Label.Name = "customerAddress2Label";
            this.customerAddress2Label.Size = new System.Drawing.Size(54, 13);
            this.customerAddress2Label.TabIndex = 20;
            this.customerAddress2Label.Text = "Address 2";
            // 
            // customerZipBox
            // 
            this.customerZipBox.Location = new System.Drawing.Point(880, 150);
            this.customerZipBox.Name = "customerZipBox";
            this.customerZipBox.Size = new System.Drawing.Size(184, 20);
            this.customerZipBox.TabIndex = 23;
            // 
            // customerZipLabel
            // 
            this.customerZipLabel.AutoSize = true;
            this.customerZipLabel.Location = new System.Drawing.Point(790, 153);
            this.customerZipLabel.Name = "customerZipLabel";
            this.customerZipLabel.Size = new System.Drawing.Size(84, 13);
            this.customerZipLabel.TabIndex = 22;
            this.customerZipLabel.Text = "Zip/Postal Code";
            // 
            // appointmentDateBox
            // 
            this.appointmentDateBox.Location = new System.Drawing.Point(880, 393);
            this.appointmentDateBox.Name = "appointmentDateBox";
            this.appointmentDateBox.Size = new System.Drawing.Size(184, 20);
            this.appointmentDateBox.TabIndex = 0;
            this.appointmentDateBox.Value = new System.DateTime(2023, 11, 20, 0, 0, 0, 0);
            // 
            // appointmentStartTimeBox
            // 
            this.appointmentStartTimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.appointmentStartTimeBox.Location = new System.Drawing.Point(880, 422);
            this.appointmentStartTimeBox.Name = "appointmentStartTimeBox";
            this.appointmentStartTimeBox.ShowUpDown = true;
            this.appointmentStartTimeBox.Size = new System.Drawing.Size(184, 20);
            this.appointmentStartTimeBox.TabIndex = 24;
            this.appointmentStartTimeBox.Value = new System.DateTime(2023, 11, 20, 0, 0, 0, 0);
            // 
            // appointmentEndTimeBox
            // 
            this.appointmentEndTimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.appointmentEndTimeBox.Location = new System.Drawing.Point(880, 451);
            this.appointmentEndTimeBox.Name = "appointmentEndTimeBox";
            this.appointmentEndTimeBox.ShowUpDown = true;
            this.appointmentEndTimeBox.Size = new System.Drawing.Size(184, 20);
            this.appointmentEndTimeBox.TabIndex = 25;
            this.appointmentEndTimeBox.Value = new System.DateTime(2023, 11, 20, 0, 0, 0, 0);
            // 
            // appointmentCustomerBox
            // 
            this.appointmentCustomerBox.Location = new System.Drawing.Point(880, 306);
            this.appointmentCustomerBox.Name = "appointmentCustomerBox";
            this.appointmentCustomerBox.Size = new System.Drawing.Size(184, 20);
            this.appointmentCustomerBox.TabIndex = 26;
            // 
            // appointmentUserBox
            // 
            this.appointmentUserBox.Location = new System.Drawing.Point(880, 335);
            this.appointmentUserBox.Name = "appointmentUserBox";
            this.appointmentUserBox.Size = new System.Drawing.Size(184, 20);
            this.appointmentUserBox.TabIndex = 27;
            // 
            // appointmentTypeBox
            // 
            this.appointmentTypeBox.Location = new System.Drawing.Point(880, 364);
            this.appointmentTypeBox.Name = "appointmentTypeBox";
            this.appointmentTypeBox.Size = new System.Drawing.Size(184, 20);
            this.appointmentTypeBox.TabIndex = 28;
            // 
            // appointmentCustomerLabel
            // 
            this.appointmentCustomerLabel.AutoSize = true;
            this.appointmentCustomerLabel.Location = new System.Drawing.Point(809, 309);
            this.appointmentCustomerLabel.Name = "appointmentCustomerLabel";
            this.appointmentCustomerLabel.Size = new System.Drawing.Size(65, 13);
            this.appointmentCustomerLabel.TabIndex = 29;
            this.appointmentCustomerLabel.Text = "Customer ID";
            // 
            // appointmentUserLabel
            // 
            this.appointmentUserLabel.AutoSize = true;
            this.appointmentUserLabel.Location = new System.Drawing.Point(803, 338);
            this.appointmentUserLabel.Name = "appointmentUserLabel";
            this.appointmentUserLabel.Size = new System.Drawing.Size(71, 13);
            this.appointmentUserLabel.TabIndex = 30;
            this.appointmentUserLabel.Text = "Consultant ID";
            // 
            // appointmentTypeLabel
            // 
            this.appointmentTypeLabel.AutoSize = true;
            this.appointmentTypeLabel.Location = new System.Drawing.Point(781, 367);
            this.appointmentTypeLabel.Name = "appointmentTypeLabel";
            this.appointmentTypeLabel.Size = new System.Drawing.Size(93, 13);
            this.appointmentTypeLabel.TabIndex = 31;
            this.appointmentTypeLabel.Text = "Appointment Type";
            // 
            // appointmentDateLabel
            // 
            this.appointmentDateLabel.AutoSize = true;
            this.appointmentDateLabel.Location = new System.Drawing.Point(782, 396);
            this.appointmentDateLabel.Name = "appointmentDateLabel";
            this.appointmentDateLabel.Size = new System.Drawing.Size(92, 13);
            this.appointmentDateLabel.TabIndex = 32;
            this.appointmentDateLabel.Text = "Appointment Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(819, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(822, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "End Time";
            // 
            // allRadio
            // 
            this.allRadio.AutoSize = true;
            this.allRadio.Checked = true;
            this.allRadio.Location = new System.Drawing.Point(16, 558);
            this.allRadio.Name = "allRadio";
            this.allRadio.Size = new System.Drawing.Size(103, 17);
            this.allRadio.TabIndex = 35;
            this.allRadio.TabStop = true;
            this.allRadio.Text = "All Appointments";
            this.allRadio.UseVisualStyleBackColor = true;
            this.allRadio.CheckedChanged += new System.EventHandler(this.appointmentFilters_CheckedChanged);
            // 
            // monthlyRadio
            // 
            this.monthlyRadio.AutoSize = true;
            this.monthlyRadio.Location = new System.Drawing.Point(16, 581);
            this.monthlyRadio.Name = "monthlyRadio";
            this.monthlyRadio.Size = new System.Drawing.Size(62, 17);
            this.monthlyRadio.TabIndex = 36;
            this.monthlyRadio.Text = "Monthly";
            this.monthlyRadio.UseVisualStyleBackColor = true;
            this.monthlyRadio.CheckedChanged += new System.EventHandler(this.appointmentFilters_CheckedChanged);
            // 
            // weeklyRadio
            // 
            this.weeklyRadio.AutoSize = true;
            this.weeklyRadio.Location = new System.Drawing.Point(16, 604);
            this.weeklyRadio.Name = "weeklyRadio";
            this.weeklyRadio.Size = new System.Drawing.Size(61, 17);
            this.weeklyRadio.TabIndex = 37;
            this.weeklyRadio.Text = "Weekly";
            this.weeklyRadio.UseVisualStyleBackColor = true;
            this.weeklyRadio.CheckedChanged += new System.EventHandler(this.appointmentFilters_CheckedChanged);
            // 
            // consultantRadio
            // 
            this.consultantRadio.AutoSize = true;
            this.consultantRadio.Location = new System.Drawing.Point(16, 627);
            this.consultantRadio.Name = "consultantRadio";
            this.consultantRadio.Size = new System.Drawing.Size(123, 17);
            this.consultantRadio.TabIndex = 39;
            this.consultantRadio.Text = "Consultant Schedule";
            this.consultantRadio.UseVisualStyleBackColor = true;
            this.consultantRadio.CheckedChanged += new System.EventHandler(this.appointmentFilters_CheckedChanged);
            // 
            // consultantPicker
            // 
            this.consultantPicker.FormattingEnabled = true;
            this.consultantPicker.Location = new System.Drawing.Point(145, 626);
            this.consultantPicker.Name = "consultantPicker";
            this.consultantPicker.Size = new System.Drawing.Size(114, 21);
            this.consultantPicker.TabIndex = 40;
            this.consultantPicker.SelectedIndexChanged += new System.EventHandler(this.appointmentFilters_CheckedChanged);
            // 
            // appointmentFilterDate
            // 
            this.appointmentFilterDate.Location = new System.Drawing.Point(16, 532);
            this.appointmentFilterDate.Name = "appointmentFilterDate";
            this.appointmentFilterDate.Size = new System.Drawing.Size(201, 20);
            this.appointmentFilterDate.TabIndex = 41;
            this.appointmentFilterDate.Value = new System.DateTime(2023, 11, 23, 12, 0, 0, 0);
            this.appointmentFilterDate.ValueChanged += new System.EventHandler(this.appointmentFilters_CheckedChanged);
            // 
            // reportsBox
            // 
            this.reportsBox.Controls.Add(this.reportTotalLabel);
            this.reportsBox.Controls.Add(this.reportTypeLabel);
            this.reportsBox.Controls.Add(this.reportTypeBox);
            this.reportsBox.Controls.Add(this.reportTypeInfoLabel);
            this.reportsBox.Location = new System.Drawing.Point(265, 532);
            this.reportsBox.Name = "reportsBox";
            this.reportsBox.Size = new System.Drawing.Size(497, 115);
            this.reportsBox.TabIndex = 42;
            this.reportsBox.TabStop = false;
            this.reportsBox.Text = "Reporting";
            // 
            // reportTypeInfoLabel
            // 
            this.reportTypeInfoLabel.AutoSize = true;
            this.reportTypeInfoLabel.Location = new System.Drawing.Point(258, 51);
            this.reportTypeInfoLabel.Name = "reportTypeInfoLabel";
            this.reportTypeInfoLabel.Size = new System.Drawing.Size(133, 13);
            this.reportTypeInfoLabel.TabIndex = 41;
            this.reportTypeInfoLabel.Text = "appointments this month: 0";
            // 
            // reportTypeBox
            // 
            this.reportTypeBox.Location = new System.Drawing.Point(68, 48);
            this.reportTypeBox.Name = "reportTypeBox";
            this.reportTypeBox.Size = new System.Drawing.Size(184, 20);
            this.reportTypeBox.TabIndex = 42;
            this.reportTypeBox.TextChanged += new System.EventHandler(this.reportTypeBox_TextChanged);
            // 
            // reportTypeLabel
            // 
            this.reportTypeLabel.AutoSize = true;
            this.reportTypeLabel.Location = new System.Drawing.Point(6, 51);
            this.reportTypeLabel.Name = "reportTypeLabel";
            this.reportTypeLabel.Size = new System.Drawing.Size(56, 13);
            this.reportTypeLabel.TabIndex = 43;
            this.reportTypeLabel.Text = "Number of";
            // 
            // reportTotalLabel
            // 
            this.reportTotalLabel.AutoSize = true;
            this.reportTotalLabel.Location = new System.Drawing.Point(6, 28);
            this.reportTotalLabel.Name = "reportTotalLabel";
            this.reportTotalLabel.Size = new System.Drawing.Size(101, 13);
            this.reportTotalLabel.TabIndex = 44;
            this.reportTotalLabel.Text = "Total Appointments:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 679);
            this.Controls.Add(this.reportsBox);
            this.Controls.Add(this.appointmentFilterDate);
            this.Controls.Add(this.weeklyRadio);
            this.Controls.Add(this.monthlyRadio);
            this.Controls.Add(this.consultantRadio);
            this.Controls.Add(this.consultantPicker);
            this.Controls.Add(this.allRadio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.appointmentDateLabel);
            this.Controls.Add(this.appointmentTypeLabel);
            this.Controls.Add(this.appointmentUserLabel);
            this.Controls.Add(this.appointmentCustomerLabel);
            this.Controls.Add(this.appointmentTypeBox);
            this.Controls.Add(this.appointmentUserBox);
            this.Controls.Add(this.appointmentCustomerBox);
            this.Controls.Add(this.appointmentEndTimeBox);
            this.Controls.Add(this.appointmentStartTimeBox);
            this.Controls.Add(this.appointmentDateBox);
            this.Controls.Add(this.customerZipBox);
            this.Controls.Add(this.customerZipLabel);
            this.Controls.Add(this.customerAddress2Box);
            this.Controls.Add(this.customerAddress2Label);
            this.Controls.Add(this.customerCountryBox);
            this.Controls.Add(this.customerCityBox);
            this.Controls.Add(this.customerAddressBox);
            this.Controls.Add(this.customerPhoneBox);
            this.Controls.Add(this.customerNameBox);
            this.Controls.Add(this.customerCountryLabel);
            this.Controls.Add(this.customerCityLabel);
            this.Controls.Add(this.customerAddressLabel);
            this.Controls.Add(this.customerPhoneLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.deleteAppointmentButton);
            this.Controls.Add(this.updateAppointmentButton);
            this.Controls.Add(this.addAppointmentButton);
            this.Controls.Add(this.deleteCustomerButton);
            this.Controls.Add(this.updateCustomerButton);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.appointmentLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.appointmentList);
            this.Controls.Add(this.customerList);
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentList)).EndInit();
            this.reportsBox.ResumeLayout(false);
            this.reportsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerList;
        private System.Windows.Forms.DataGridView appointmentList;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label appointmentLabel;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Button updateCustomerButton;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.Button deleteAppointmentButton;
        private System.Windows.Forms.Button updateAppointmentButton;
        private System.Windows.Forms.Button addAppointmentButton;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label customerPhoneLabel;
        private System.Windows.Forms.Label customerAddressLabel;
        private System.Windows.Forms.Label customerCityLabel;
        private System.Windows.Forms.Label customerCountryLabel;
        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.TextBox customerPhoneBox;
        private System.Windows.Forms.TextBox customerAddressBox;
        private System.Windows.Forms.TextBox customerCityBox;
        private System.Windows.Forms.TextBox customerCountryBox;
        private System.Windows.Forms.TextBox customerAddress2Box;
        private System.Windows.Forms.Label customerAddress2Label;
        private System.Windows.Forms.TextBox customerZipBox;
        private System.Windows.Forms.Label customerZipLabel;
        private System.Windows.Forms.DateTimePicker appointmentDateBox;
        private System.Windows.Forms.DateTimePicker appointmentStartTimeBox;
        private System.Windows.Forms.DateTimePicker appointmentEndTimeBox;
        private System.Windows.Forms.TextBox appointmentCustomerBox;
        private System.Windows.Forms.TextBox appointmentUserBox;
        private System.Windows.Forms.TextBox appointmentTypeBox;
        private System.Windows.Forms.Label appointmentCustomerLabel;
        private System.Windows.Forms.Label appointmentUserLabel;
        private System.Windows.Forms.Label appointmentTypeLabel;
        private System.Windows.Forms.Label appointmentDateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton allRadio;
        private System.Windows.Forms.RadioButton monthlyRadio;
        private System.Windows.Forms.RadioButton weeklyRadio;
        private System.Windows.Forms.RadioButton consultantRadio;
        private System.Windows.Forms.ComboBox consultantPicker;
        private System.Windows.Forms.DateTimePicker appointmentFilterDate;
        private System.Windows.Forms.GroupBox reportsBox;
        private System.Windows.Forms.TextBox reportTypeBox;
        private System.Windows.Forms.Label reportTypeInfoLabel;
        private System.Windows.Forms.Label reportTypeLabel;
        private System.Windows.Forms.Label reportTotalLabel;
    }
}