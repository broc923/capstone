namespace IDPrinter {
    partial class FrmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support
        /// </summary>
        private void InitializeComponent() {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.lbUserLog = new System.Windows.Forms.ListBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tabAddUser = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUserPicture = new System.Windows.Forms.Button();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.userImageBox = new System.Windows.Forms.PictureBox();
            this.lblPrinter = new System.Windows.Forms.Label();
            this.cbPrinters = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnPrintID = new System.Windows.Forms.Button();
            this.tabDeleteUser = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDeleteUser = new System.Windows.Forms.Label();
            this.txtDeleteUser = new System.Windows.Forms.TextBox();
            this.btnLookup = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.pbUserPic = new System.Windows.Forms.PictureBox();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.lblPrinterVersion = new System.Windows.Forms.Label();
            this.lblGraphicsVersion = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.openUserImage = new System.Windows.Forms.OpenFileDialog();
            this.btnClearLogs = new System.Windows.Forms.Button();
            this.btnClearDelete = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabAddUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImageBox)).BeginInit();
            this.tabDeleteUser.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPic)).BeginInit();
            this.tabReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabAddUser);
            this.tabControl1.Controls.Add(this.tabDeleteUser);
            this.tabControl1.Controls.Add(this.tabReport);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(836, 305);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.lbUserLog);
            this.tabLogin.Controls.Add(this.btnLogout);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(828, 279);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // lbUserLog
            // 
            this.lbUserLog.FormattingEnabled = true;
            this.lbUserLog.Location = new System.Drawing.Point(23, 64);
            this.lbUserLog.Name = "lbUserLog";
            this.lbUserLog.Size = new System.Drawing.Size(783, 199);
            this.lbUserLog.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(213, 19);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(197, 39);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(23, 19);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(184, 39);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tabAddUser
            // 
            this.tabAddUser.Controls.Add(this.btnClear);
            this.tabAddUser.Controls.Add(this.groupBox1);
            this.tabAddUser.Controls.Add(this.userImageBox);
            this.tabAddUser.Controls.Add(this.lblPrinter);
            this.tabAddUser.Controls.Add(this.cbPrinters);
            this.tabAddUser.Controls.Add(this.lblStatus);
            this.tabAddUser.Controls.Add(this.btnPrintID);
            this.tabAddUser.Location = new System.Drawing.Point(4, 22);
            this.tabAddUser.Name = "tabAddUser";
            this.tabAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddUser.Size = new System.Drawing.Size(828, 279);
            this.tabAddUser.TabIndex = 1;
            this.tabAddUser.Text = "Add User";
            this.tabAddUser.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(745, 35);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.txtZip);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnUserPicture);
            this.groupBox1.Controls.Add(this.cbState);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtStreet);
            this.groupBox1.Controls.Add(this.lblStreet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbAdmin);
            this.groupBox1.Location = new System.Drawing.Point(9, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 259);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New User Information";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(83, 158);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(141, 20);
            this.txtPhone.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Phone:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(308, 47);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(141, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(83, 48);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(141, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(334, 121);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(115, 20);
            this.txtZip.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Zip:";
            // 
            // btnUserPicture
            // 
            this.btnUserPicture.Location = new System.Drawing.Point(388, 230);
            this.btnUserPicture.Name = "btnUserPicture";
            this.btnUserPicture.Size = new System.Drawing.Size(87, 23);
            this.btnUserPicture.TabIndex = 9;
            this.btnUserPicture.Text = "&Insert Photo";
            this.btnUserPicture.UseVisualStyleBackColor = true;
            this.btnUserPicture.Click += new System.EventHandler(this.btnUserPicture_Click);
            // 
            // cbState
            // 
            this.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbState.FormattingEnabled = true;
            this.cbState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AS",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "DC",
            "FL",
            "GA",
            "GU",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MH",
            "MA",
            "ME",
            "FM",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "MP",
            "OH",
            "OK",
            "OR",
            "PW",
            "PA",
            "PR",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "VI",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cbState.Location = new System.Drawing.Point(230, 120);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(56, 21);
            this.cbState.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "State:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(83, 121);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "City:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(83, 84);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(366, 20);
            this.txtStreet.TabIndex = 2;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(39, 87);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 32;
            this.lblStreet.Text = "Street:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "First Name:";
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(6, 236);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(103, 17);
            this.cbAdmin.TabIndex = 7;
            this.cbAdmin.Text = "Admin Privileges";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // userImageBox
            // 
            this.userImageBox.Location = new System.Drawing.Point(508, 68);
            this.userImageBox.Name = "userImageBox";
            this.userImageBox.Size = new System.Drawing.Size(303, 192);
            this.userImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImageBox.TabIndex = 45;
            this.userImageBox.TabStop = false;
            // 
            // lblPrinter
            // 
            this.lblPrinter.AutoSize = true;
            this.lblPrinter.Location = new System.Drawing.Point(505, 13);
            this.lblPrinter.Name = "lblPrinter";
            this.lblPrinter.Size = new System.Drawing.Size(40, 13);
            this.lblPrinter.TabIndex = 5;
            this.lblPrinter.Text = "Printer:";
            // 
            // cbPrinters
            // 
            this.cbPrinters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrinters.FormattingEnabled = true;
            this.cbPrinters.Location = new System.Drawing.Point(508, 35);
            this.cbPrinters.Name = "cbPrinters";
            this.cbPrinters.Size = new System.Drawing.Size(121, 21);
            this.cbPrinters.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(661, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(69, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status: None";
            // 
            // btnPrintID
            // 
            this.btnPrintID.Location = new System.Drawing.Point(664, 35);
            this.btnPrintID.Name = "btnPrintID";
            this.btnPrintID.Size = new System.Drawing.Size(75, 23);
            this.btnPrintID.TabIndex = 2;
            this.btnPrintID.Text = "&Print ID";
            this.btnPrintID.UseVisualStyleBackColor = true;
            this.btnPrintID.Click += new System.EventHandler(this.btnPrintID_Click);
            // 
            // tabDeleteUser
            // 
            this.tabDeleteUser.Controls.Add(this.btnClearLogs);
            this.tabDeleteUser.Controls.Add(this.groupBox3);
            this.tabDeleteUser.Controls.Add(this.groupBox2);
            this.tabDeleteUser.Controls.Add(this.pbUserPic);
            this.tabDeleteUser.Location = new System.Drawing.Point(4, 22);
            this.tabDeleteUser.Name = "tabDeleteUser";
            this.tabDeleteUser.Size = new System.Drawing.Size(828, 279);
            this.tabDeleteUser.TabIndex = 4;
            this.tabDeleteUser.Text = "Delete User";
            this.tabDeleteUser.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDeleteUser);
            this.groupBox3.Controls.Add(this.txtDeleteUser);
            this.groupBox3.Controls.Add(this.btnLookup);
            this.groupBox3.Location = new System.Drawing.Point(8, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 62);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lookup User";
            // 
            // lblDeleteUser
            // 
            this.lblDeleteUser.AutoSize = true;
            this.lblDeleteUser.Location = new System.Drawing.Point(6, 16);
            this.lblDeleteUser.Name = "lblDeleteUser";
            this.lblDeleteUser.Size = new System.Drawing.Size(325, 13);
            this.lblDeleteUser.TabIndex = 20;
            this.lblDeleteUser.Text = "Enter the User ID of the User you want to delete from the database.";
            // 
            // txtDeleteUser
            // 
            this.txtDeleteUser.Location = new System.Drawing.Point(9, 32);
            this.txtDeleteUser.Name = "txtDeleteUser";
            this.txtDeleteUser.Size = new System.Drawing.Size(130, 20);
            this.txtDeleteUser.TabIndex = 19;
            // 
            // btnLookup
            // 
            this.btnLookup.Location = new System.Drawing.Point(145, 32);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(100, 23);
            this.btnLookup.TabIndex = 25;
            this.btnLookup.Text = "Lookup User";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearDelete);
            this.groupBox2.Controls.Add(this.btnDeleteUser);
            this.groupBox2.Controls.Add(this.lblID);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtNumber);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Location = new System.Drawing.Point(171, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 144);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete User";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(236, 107);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 21;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(134, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(73, 13);
            this.lblID.TabIndex = 26;
            this.lblID.Text = "User ID: 0000";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 29);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(244, 20);
            this.txtName.TabIndex = 22;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(67, 81);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(244, 20);
            this.txtNumber.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Phone #:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Name: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Address: ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(67, 55);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(244, 20);
            this.txtAddress.TabIndex = 23;
            // 
            // pbUserPic
            // 
            this.pbUserPic.Location = new System.Drawing.Point(520, 19);
            this.pbUserPic.Name = "pbUserPic";
            this.pbUserPic.Size = new System.Drawing.Size(300, 241);
            this.pbUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserPic.TabIndex = 30;
            this.pbUserPic.TabStop = false;
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.lblPrinterVersion);
            this.tabReport.Controls.Add(this.lblGraphicsVersion);
            this.tabReport.Controls.Add(this.btnReport);
            this.tabReport.Location = new System.Drawing.Point(4, 22);
            this.tabReport.Name = "tabReport";
            this.tabReport.Size = new System.Drawing.Size(828, 279);
            this.tabReport.TabIndex = 5;
            this.tabReport.Text = "Report";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // lblPrinterVersion
            // 
            this.lblPrinterVersion.AutoSize = true;
            this.lblPrinterVersion.Location = new System.Drawing.Point(668, 260);
            this.lblPrinterVersion.Name = "lblPrinterVersion";
            this.lblPrinterVersion.Size = new System.Drawing.Size(152, 13);
            this.lblPrinterVersion.TabIndex = 51;
            this.lblPrinterVersion.Text = "Magnetic Printer Version: 0.0.0";
            // 
            // lblGraphicsVersion
            // 
            this.lblGraphicsVersion.AutoSize = true;
            this.lblGraphicsVersion.Location = new System.Drawing.Point(703, 247);
            this.lblGraphicsVersion.Name = "lblGraphicsVersion";
            this.lblGraphicsVersion.Size = new System.Drawing.Size(117, 13);
            this.lblGraphicsVersion.TabIndex = 50;
            this.lblGraphicsVersion.Text = "Graphics Version: 0.0.0";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(8, 239);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(100, 28);
            this.btnReport.TabIndex = 49;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // openUserImage
            // 
            this.openUserImage.FileName = "openUserImage";
            // 
            // btnClearLogs
            // 
            this.btnClearLogs.Location = new System.Drawing.Point(8, 248);
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new System.Drawing.Size(107, 23);
            this.btnClearLogs.TabIndex = 33;
            this.btnClearLogs.Text = "Clear Time Logs";
            this.btnClearLogs.UseVisualStyleBackColor = true;
            this.btnClearLogs.Click += new System.EventHandler(this.btnClearLogs_Click);
            // 
            // btnClearDelete
            // 
            this.btnClearDelete.Location = new System.Drawing.Point(155, 107);
            this.btnClearDelete.Name = "btnClearDelete";
            this.btnClearDelete.Size = new System.Drawing.Size(75, 23);
            this.btnClearDelete.TabIndex = 30;
            this.btnClearDelete.Text = "Clear";
            this.btnClearDelete.UseVisualStyleBackColor = true;
            this.btnClearDelete.Click += new System.EventHandler(this.btnClearDelete_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 305);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmMain";
            this.Text = "iDENTIFY Me";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabAddUser.ResumeLayout(false);
            this.tabAddUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImageBox)).EndInit();
            this.tabDeleteUser.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPic)).EndInit();
            this.tabReport.ResumeLayout(false);
            this.tabReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabAddUser;
        private System.Windows.Forms.Button btnPrintID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPrinter;
        private System.Windows.Forms.ComboBox cbPrinters;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Button btnUserPicture;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox userImageBox;
        private System.Windows.Forms.OpenFileDialog openUserImage;
        private System.Windows.Forms.TabPage tabDeleteUser;
        private System.Windows.Forms.Label lblDeleteUser;
        private System.Windows.Forms.TextBox txtDeleteUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.ListBox lbUserLog;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbUserPic;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.Label lblPrinterVersion;
        private System.Windows.Forms.Label lblGraphicsVersion;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClearLogs;
        private System.Windows.Forms.Button btnClearDelete;
    }
}