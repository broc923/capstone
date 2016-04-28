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
            this.lblImageLocation = new System.Windows.Forms.Label();
            this.userImageBox = new System.Windows.Forms.PictureBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.btnUserPicture = new System.Windows.Forms.Button();
            this.lblStreet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.lblPrinter = new System.Windows.Forms.Label();
            this.cbPrinters = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnPrintID = new System.Windows.Forms.Button();
            this.tabDeleteUser = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnLookup = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.lblDeleteUser = new System.Windows.Forms.Label();
            this.txtDeleteUser = new System.Windows.Forms.TextBox();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrinterVersion = new System.Windows.Forms.Label();
            this.lblGraphicsVersion = new System.Windows.Forms.Label();
            this.tabTesting = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openUserImage = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabAddUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImageBox)).BeginInit();
            this.tabDeleteUser.SuspendLayout();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabTesting.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabAddUser);
            this.tabControl1.Controls.Add(this.tabDeleteUser);
            this.tabControl1.Controls.Add(this.tabAbout);
            this.tabControl1.Controls.Add(this.tabTesting);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(506, 336);
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
            this.tabLogin.Size = new System.Drawing.Size(498, 310);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // lbUserLog
            // 
            this.lbUserLog.FormattingEnabled = true;
            this.lbUserLog.Location = new System.Drawing.Point(6, 142);
            this.lbUserLog.Name = "lbUserLog";
            this.lbUserLog.Size = new System.Drawing.Size(481, 160);
            this.lbUserLog.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(268, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(222, 131);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(6, 6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(231, 131);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tabAddUser
            // 
            this.tabAddUser.Controls.Add(this.btnClear);
            this.tabAddUser.Controls.Add(this.groupBox1);
            this.tabAddUser.Controls.Add(this.lblPrinter);
            this.tabAddUser.Controls.Add(this.cbPrinters);
            this.tabAddUser.Controls.Add(this.lblStatus);
            this.tabAddUser.Controls.Add(this.btnPrintID);
            this.tabAddUser.Location = new System.Drawing.Point(4, 22);
            this.tabAddUser.Name = "tabAddUser";
            this.tabAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddUser.Size = new System.Drawing.Size(498, 310);
            this.tabAddUser.TabIndex = 1;
            this.tabAddUser.Text = "Add User";
            this.tabAddUser.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(343, 281);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblImageLocation);
            this.groupBox1.Controls.Add(this.userImageBox);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.txtZip);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbState);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtStreet);
            this.groupBox1.Controls.Add(this.btnUserPicture);
            this.groupBox1.Controls.Add(this.lblStreet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbAdmin);
            this.groupBox1.Location = new System.Drawing.Point(9, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 249);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New User Information";
            // 
            // lblImageLocation
            // 
            this.lblImageLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImageLocation.AutoSize = true;
            this.lblImageLocation.Location = new System.Drawing.Point(99, 221);
            this.lblImageLocation.Name = "lblImageLocation";
            this.lblImageLocation.Size = new System.Drawing.Size(165, 13);
            this.lblImageLocation.TabIndex = 46;
            this.lblImageLocation.Text = "C://path/to/students/picture.png";
            // 
            // userImageBox
            // 
            this.userImageBox.Location = new System.Drawing.Point(6, 114);
            this.userImageBox.Name = "userImageBox";
            this.userImageBox.Size = new System.Drawing.Size(128, 96);
            this.userImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImageBox.TabIndex = 45;
            this.userImageBox.TabStop = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(182, 122);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(141, 20);
            this.txtPhone.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Phone:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(308, 20);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(141, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(83, 21);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(141, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(334, 88);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(115, 20);
            this.txtZip.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Zip:";
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
            this.cbState.Location = new System.Drawing.Point(230, 87);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(56, 21);
            this.cbState.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "State:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(83, 88);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "City:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(83, 54);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(366, 20);
            this.txtStreet.TabIndex = 2;
            // 
            // btnUserPicture
            // 
            this.btnUserPicture.Location = new System.Drawing.Point(6, 216);
            this.btnUserPicture.Name = "btnUserPicture";
            this.btnUserPicture.Size = new System.Drawing.Size(87, 23);
            this.btnUserPicture.TabIndex = 9;
            this.btnUserPicture.Text = "&Insert Photo";
            this.btnUserPicture.UseVisualStyleBackColor = true;
            this.btnUserPicture.Click += new System.EventHandler(this.btnUserPicture_Click);
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(39, 57);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 32;
            this.lblStreet.Text = "Street:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "First Name:";
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(346, 124);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(103, 17);
            this.cbAdmin.TabIndex = 7;
            this.cbAdmin.Text = "Admin Privileges";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // lblPrinter
            // 
            this.lblPrinter.AutoSize = true;
            this.lblPrinter.Location = new System.Drawing.Point(79, 265);
            this.lblPrinter.Name = "lblPrinter";
            this.lblPrinter.Size = new System.Drawing.Size(40, 13);
            this.lblPrinter.TabIndex = 5;
            this.lblPrinter.Text = "Printer:";
            // 
            // cbPrinters
            // 
            this.cbPrinters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrinters.FormattingEnabled = true;
            this.cbPrinters.Location = new System.Drawing.Point(82, 281);
            this.cbPrinters.Name = "cbPrinters";
            this.cbPrinters.Size = new System.Drawing.Size(121, 21);
            this.cbPrinters.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(263, 263);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(69, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status: None";
            // 
            // btnPrintID
            // 
            this.btnPrintID.Location = new System.Drawing.Point(262, 281);
            this.btnPrintID.Name = "btnPrintID";
            this.btnPrintID.Size = new System.Drawing.Size(75, 23);
            this.btnPrintID.TabIndex = 2;
            this.btnPrintID.Text = "&Print ID";
            this.btnPrintID.UseVisualStyleBackColor = true;
            this.btnPrintID.Click += new System.EventHandler(this.btnPrintID_Click);
            // 
            // tabDeleteUser
            // 
            this.tabDeleteUser.Controls.Add(this.label15);
            this.tabDeleteUser.Controls.Add(this.label14);
            this.tabDeleteUser.Controls.Add(this.label8);
            this.tabDeleteUser.Controls.Add(this.lblID);
            this.tabDeleteUser.Controls.Add(this.btnLookup);
            this.tabDeleteUser.Controls.Add(this.txtNumber);
            this.tabDeleteUser.Controls.Add(this.txtAddress);
            this.tabDeleteUser.Controls.Add(this.txtName);
            this.tabDeleteUser.Controls.Add(this.btnDeleteUser);
            this.tabDeleteUser.Controls.Add(this.lblDeleteUser);
            this.tabDeleteUser.Controls.Add(this.txtDeleteUser);
            this.tabDeleteUser.Location = new System.Drawing.Point(4, 22);
            this.tabDeleteUser.Name = "tabDeleteUser";
            this.tabDeleteUser.Size = new System.Drawing.Size(498, 310);
            this.tabDeleteUser.TabIndex = 4;
            this.tabDeleteUser.Text = "Delete User";
            this.tabDeleteUser.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(45, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Phone #:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(45, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Address: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Name: ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(169, 72);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(103, 13);
            this.lblID.TabIndex = 26;
            this.lblID.Text = "User ID: 000000000";
            // 
            // btnLookup
            // 
            this.btnLookup.Location = new System.Drawing.Point(147, 29);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(100, 23);
            this.btnLookup.TabIndex = 25;
            this.btnLookup.Text = "Lookup User";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(102, 140);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(244, 20);
            this.txtNumber.TabIndex = 24;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(102, 114);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(244, 20);
            this.txtAddress.TabIndex = 23;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 20);
            this.txtName.TabIndex = 22;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(415, 279);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 21;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_click);
            // 
            // lblDeleteUser
            // 
            this.lblDeleteUser.AutoSize = true;
            this.lblDeleteUser.Location = new System.Drawing.Point(8, 13);
            this.lblDeleteUser.Name = "lblDeleteUser";
            this.lblDeleteUser.Size = new System.Drawing.Size(325, 13);
            this.lblDeleteUser.TabIndex = 20;
            this.lblDeleteUser.Text = "Enter the User ID of the User you want to delete from the database.";
            // 
            // txtDeleteUser
            // 
            this.txtDeleteUser.Location = new System.Drawing.Point(11, 29);
            this.txtDeleteUser.Name = "txtDeleteUser";
            this.txtDeleteUser.Size = new System.Drawing.Size(130, 20);
            this.txtDeleteUser.TabIndex = 19;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.pictureBox1);
            this.tabAbout.Controls.Add(this.label13);
            this.tabAbout.Controls.Add(this.label12);
            this.tabAbout.Controls.Add(this.label11);
            this.tabAbout.Controls.Add(this.label10);
            this.tabAbout.Controls.Add(this.label9);
            this.tabAbout.Controls.Add(this.label3);
            this.tabAbout.Controls.Add(this.lblPrinterVersion);
            this.tabAbout.Controls.Add(this.lblGraphicsVersion);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(498, 310);
            this.tabAbout.TabIndex = 2;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(196, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 157);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Developers";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Nicole Johnson";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Caleb Mann";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "George Shelton";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Broc White";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 7;
            // 
            // lblPrinterVersion
            // 
            this.lblPrinterVersion.AutoSize = true;
            this.lblPrinterVersion.Location = new System.Drawing.Point(338, 255);
            this.lblPrinterVersion.Name = "lblPrinterVersion";
            this.lblPrinterVersion.Size = new System.Drawing.Size(152, 13);
            this.lblPrinterVersion.TabIndex = 2;
            this.lblPrinterVersion.Text = "Magnetic Printer Version: 0.0.0";
            // 
            // lblGraphicsVersion
            // 
            this.lblGraphicsVersion.AutoSize = true;
            this.lblGraphicsVersion.Location = new System.Drawing.Point(373, 242);
            this.lblGraphicsVersion.Name = "lblGraphicsVersion";
            this.lblGraphicsVersion.Size = new System.Drawing.Size(117, 13);
            this.lblGraphicsVersion.TabIndex = 1;
            this.lblGraphicsVersion.Text = "Graphics Version: 0.0.0";
            // 
            // tabTesting
            // 
            this.tabTesting.Controls.Add(this.button4);
            this.tabTesting.Controls.Add(this.button3);
            this.tabTesting.Location = new System.Drawing.Point(4, 22);
            this.tabTesting.Name = "tabTesting";
            this.tabTesting.Size = new System.Drawing.Size(498, 310);
            this.tabTesting.TabIndex = 5;
            this.tabTesting.Text = "Testing";
            this.tabTesting.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 28);
            this.button4.TabIndex = 17;
            this.button4.Text = "Write";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(272, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 28);
            this.button3.TabIndex = 16;
            this.button3.Text = "Read";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openUserImage
            // 
            this.openUserImage.FileName = "openUserImage";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 336);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmMain";
            this.Text = "ID Printer";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabAddUser.ResumeLayout(false);
            this.tabAddUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImageBox)).EndInit();
            this.tabDeleteUser.ResumeLayout(false);
            this.tabDeleteUser.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabTesting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabAddUser;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Label lblGraphicsVersion;
        private System.Windows.Forms.Label lblPrinterVersion;
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
        private System.Windows.Forms.Label lblImageLocation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabDeleteUser;
        private System.Windows.Forms.Label lblDeleteUser;
        private System.Windows.Forms.TextBox txtDeleteUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TabPage tabTesting;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
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
    }
}