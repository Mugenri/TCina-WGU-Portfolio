namespace NCina_C968_Assessment
{
    partial class ModifyProduct
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
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.associatedPartsList = new System.Windows.Forms.DataGridView();
            this.associatedPartsLabel = new System.Windows.Forms.Label();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.searchPartBox = new System.Windows.Forms.TextBox();
            this.candidateList = new System.Windows.Forms.DataGridView();
            this.candidatePartsLabel = new System.Windows.Forms.Label();
            this.searchPartButton = new System.Windows.Forms.Button();
            this.addPartButton = new System.Windows.Forms.Button();
            this.modifyProductLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.minBox = new System.Windows.Forms.TextBox();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.inventoryBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateList)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(673, 626);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(56, 32);
            this.saveButton.TabIndex = 63;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(750, 626);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(56, 32);
            this.cancelButton.TabIndex = 62;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // associatedPartsList
            // 
            this.associatedPartsList.AllowUserToAddRows = false;
            this.associatedPartsList.AllowUserToDeleteRows = false;
            this.associatedPartsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.associatedPartsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsList.Location = new System.Drawing.Point(380, 363);
            this.associatedPartsList.Name = "associatedPartsList";
            this.associatedPartsList.ReadOnly = true;
            this.associatedPartsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.associatedPartsList.RowHeadersVisible = false;
            this.associatedPartsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsList.Size = new System.Drawing.Size(448, 200);
            this.associatedPartsList.TabIndex = 61;
            // 
            // associatedPartsLabel
            // 
            this.associatedPartsLabel.AutoSize = true;
            this.associatedPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.associatedPartsLabel.Location = new System.Drawing.Point(380, 334);
            this.associatedPartsLabel.Name = "associatedPartsLabel";
            this.associatedPartsLabel.Size = new System.Drawing.Size(249, 20);
            this.associatedPartsLabel.TabIndex = 60;
            this.associatedPartsLabel.Text = "Parts Associated with this Product";
            // 
            // deletePartButton
            // 
            this.deletePartButton.Location = new System.Drawing.Point(750, 576);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(56, 32);
            this.deletePartButton.TabIndex = 59;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = true;
            this.deletePartButton.Click += new System.EventHandler(this.deletePartButton_Click);
            // 
            // searchPartBox
            // 
            this.searchPartBox.Location = new System.Drawing.Point(673, 40);
            this.searchPartBox.Name = "searchPartBox";
            this.searchPartBox.Size = new System.Drawing.Size(155, 20);
            this.searchPartBox.TabIndex = 58;
            // 
            // candidateList
            // 
            this.candidateList.AllowUserToAddRows = false;
            this.candidateList.AllowUserToDeleteRows = false;
            this.candidateList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.candidateList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidateList.Location = new System.Drawing.Point(380, 76);
            this.candidateList.Name = "candidateList";
            this.candidateList.ReadOnly = true;
            this.candidateList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.candidateList.RowHeadersVisible = false;
            this.candidateList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.candidateList.Size = new System.Drawing.Size(448, 200);
            this.candidateList.TabIndex = 57;
            // 
            // candidatePartsLabel
            // 
            this.candidatePartsLabel.AutoSize = true;
            this.candidatePartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidatePartsLabel.Location = new System.Drawing.Point(380, 47);
            this.candidatePartsLabel.Name = "candidatePartsLabel";
            this.candidatePartsLabel.Size = new System.Drawing.Size(141, 20);
            this.candidatePartsLabel.TabIndex = 56;
            this.candidatePartsLabel.Text = "All candidate Parts";
            // 
            // searchPartButton
            // 
            this.searchPartButton.Location = new System.Drawing.Point(600, 40);
            this.searchPartButton.Name = "searchPartButton";
            this.searchPartButton.Size = new System.Drawing.Size(56, 20);
            this.searchPartButton.TabIndex = 55;
            this.searchPartButton.Text = "Search";
            this.searchPartButton.UseVisualStyleBackColor = true;
            this.searchPartButton.Click += new System.EventHandler(this.searchPartButton_Click);
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(750, 289);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(56, 32);
            this.addPartButton.TabIndex = 54;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // modifyProductLabel
            // 
            this.modifyProductLabel.AutoSize = true;
            this.modifyProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductLabel.Location = new System.Drawing.Point(12, 11);
            this.modifyProductLabel.Name = "modifyProductLabel";
            this.modifyProductLabel.Size = new System.Drawing.Size(114, 20);
            this.modifyProductLabel.TabIndex = 53;
            this.modifyProductLabel.Text = "Modify Product";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.Location = new System.Drawing.Point(171, 369);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(28, 16);
            this.minLabel.TabIndex = 52;
            this.minLabel.Text = "Min";
            this.minLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.Location = new System.Drawing.Point(12, 369);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(32, 16);
            this.maxLabel.TabIndex = 51;
            this.maxLabel.Text = "Max";
            this.maxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(12, 337);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(75, 16);
            this.priceLabel.TabIndex = 50;
            this.priceLabel.Text = "Price / Cost";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(26, 305);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(61, 16);
            this.inventoryLabel.TabIndex = 49;
            this.inventoryLabel.Text = "Inventory";
            this.inventoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(43, 273);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 16);
            this.nameLabel.TabIndex = 48;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(67, 241);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(20, 16);
            this.idLabel.TabIndex = 47;
            this.idLabel.Text = "ID";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(233, 368);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(71, 20);
            this.minBox.TabIndex = 46;
            // 
            // maxBox
            // 
            this.maxBox.Location = new System.Drawing.Point(74, 368);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(71, 20);
            this.maxBox.TabIndex = 45;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(117, 336);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(135, 20);
            this.priceBox.TabIndex = 44;
            // 
            // inventoryBox
            // 
            this.inventoryBox.Location = new System.Drawing.Point(117, 304);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(135, 20);
            this.inventoryBox.TabIndex = 43;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(117, 272);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(135, 20);
            this.nameBox.TabIndex = 42;
            // 
            // idBox
            // 
            this.idBox.Enabled = false;
            this.idBox.Location = new System.Drawing.Point(117, 240);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(135, 20);
            this.idBox.TabIndex = 41;
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 668);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.associatedPartsList);
            this.Controls.Add(this.associatedPartsLabel);
            this.Controls.Add(this.deletePartButton);
            this.Controls.Add(this.searchPartBox);
            this.Controls.Add(this.candidateList);
            this.Controls.Add(this.candidatePartsLabel);
            this.Controls.Add(this.searchPartButton);
            this.Controls.Add(this.addPartButton);
            this.Controls.Add(this.modifyProductLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.maxBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.inventoryBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.idBox);
            this.Name = "ModifyProduct";
            this.Text = "ModifyProduct";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModifyProduct_FormClosing);
            this.Load += new System.EventHandler(this.ModifyProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView associatedPartsList;
        private System.Windows.Forms.Label associatedPartsLabel;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.TextBox searchPartBox;
        private System.Windows.Forms.DataGridView candidateList;
        private System.Windows.Forms.Label candidatePartsLabel;
        private System.Windows.Forms.Button searchPartButton;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Label modifyProductLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox inventoryBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox idBox;
    }
}