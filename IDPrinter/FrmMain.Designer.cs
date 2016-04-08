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
            this.tbCheckForUser = new System.Windows.Forms.TextBox();
            this.btnCheckForUser = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
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
            this.btnPreviewID = new System.Windows.Forms.Button();
            this.tabEditUser = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl14 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTableColPhone = new System.Windows.Forms.Label();
            this.lblTableColZip = new System.Windows.Forms.Label();
            this.lblTableColState = new System.Windows.Forms.Label();
            this.lblTableColCity = new System.Windows.Forms.Label();
            this.lblTableColStreet = new System.Windows.Forms.Label();
            this.lblTableColID = new System.Windows.Forms.Label();
            this.lblTableColFirstName = new System.Windows.Forms.Label();
            this.lblTableColLastName = new System.Windows.Forms.Label();
            this.tabDisclaimer = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDiscClear = new System.Windows.Forms.Button();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.rtbDisclaimer = new System.Windows.Forms.RichTextBox();
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
            this.openUserImage = new System.Windows.Forms.OpenFileDialog();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTableColAdmin = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabAddUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImageBox)).BeginInit();
            this.tabEditUser.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabDisclaimer.SuspendLayout();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabAddUser);
            this.tabControl1.Controls.Add(this.tabEditUser);
            this.tabControl1.Controls.Add(this.tabDisclaimer);
            this.tabControl1.Controls.Add(this.tabAbout);
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
            this.tabLogin.Controls.Add(this.tbCheckForUser);
            this.tabLogin.Controls.Add(this.btnCheckForUser);
            this.tabLogin.Controls.Add(this.button4);
            this.tabLogin.Controls.Add(this.button3);
            this.tabLogin.Controls.Add(this.button1);
            this.tabLogin.Controls.Add(this.label8);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(498, 310);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // tbCheckForUser
            // 
            this.tbCheckForUser.Location = new System.Drawing.Point(153, 22);
            this.tbCheckForUser.Name = "tbCheckForUser";
            this.tbCheckForUser.Size = new System.Drawing.Size(100, 20);
            this.tbCheckForUser.TabIndex = 13;
            // 
            // btnCheckForUser
            // 
            this.btnCheckForUser.Location = new System.Drawing.Point(9, 22);
            this.btnCheckForUser.Name = "btnCheckForUser";
            this.btnCheckForUser.Size = new System.Drawing.Size(137, 23);
            this.btnCheckForUser.TabIndex = 12;
            this.btnCheckForUser.Text = "Check For User";
            this.btnCheckForUser.UseVisualStyleBackColor = true;
            this.btnCheckForUser.Click += new System.EventHandler(this.btnCheckForUser_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(252, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 28);
            this.button4.TabIndex = 11;
            this.button4.Text = "Write";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(131, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 28);
            this.button3.TabIndex = 10;
            this.button3.Text = "Read";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "label8";
            // 
            // tabAddUser
            // 
            this.tabAddUser.Controls.Add(this.btnClear);
            this.tabAddUser.Controls.Add(this.groupBox1);
            this.tabAddUser.Controls.Add(this.lblPrinter);
            this.tabAddUser.Controls.Add(this.cbPrinters);
            this.tabAddUser.Controls.Add(this.lblStatus);
            this.tabAddUser.Controls.Add(this.btnPrintID);
            this.tabAddUser.Controls.Add(this.btnPreviewID);
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
            this.btnClear.Location = new System.Drawing.Point(371, 279);
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
            this.btnPrintID.Location = new System.Drawing.Point(290, 279);
            this.btnPrintID.Name = "btnPrintID";
            this.btnPrintID.Size = new System.Drawing.Size(75, 23);
            this.btnPrintID.TabIndex = 2;
            this.btnPrintID.Text = "&Print ID";
            this.btnPrintID.UseVisualStyleBackColor = true;
            this.btnPrintID.Click += new System.EventHandler(this.btnPrintID_Click);
            // 
            // btnPreviewID
            // 
            this.btnPreviewID.Location = new System.Drawing.Point(209, 279);
            this.btnPreviewID.Name = "btnPreviewID";
            this.btnPreviewID.Size = new System.Drawing.Size(75, 23);
            this.btnPreviewID.TabIndex = 1;
            this.btnPreviewID.Text = "Pre&view ID";
            this.btnPreviewID.UseVisualStyleBackColor = true;
            this.btnPreviewID.Click += new System.EventHandler(this.btnPreviewID_Click);
            // 
            // tabEditUser
            // 
            this.tabEditUser.Controls.Add(this.btnSearch);
            this.tabEditUser.Controls.Add(this.comboBox1);
            this.tabEditUser.Controls.Add(this.lbl14);
            this.tabEditUser.Controls.Add(this.tableLayoutPanel1);
            this.tabEditUser.Location = new System.Drawing.Point(4, 22);
            this.tabEditUser.Name = "tabEditUser";
            this.tabEditUser.Size = new System.Drawing.Size(498, 310);
            this.tabEditUser.TabIndex = 4;
            this.tabEditUser.Text = "Edit User";
            this.tabEditUser.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "First Name",
            "Last Name",
            "Street",
            "Phone Number"});
            this.comboBox1.Location = new System.Drawing.Point(20, 281);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // lbl14
            // 
            this.lbl14.AutoSize = true;
            this.lbl14.Location = new System.Drawing.Point(17, 265);
            this.lbl14.Name = "lbl14";
            this.lbl14.Size = new System.Drawing.Size(62, 13);
            this.lbl14.TabIndex = 16;
            this.lbl14.Text = "Search For:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblTableColAdmin, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTableColPhone, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTableColZip, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTableColState, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTableColCity, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTableColStreet, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTableColID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTableColFirstName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTableColLastName, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(482, 259);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // lblTableColPhone
            // 
            this.lblTableColPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableColPhone.Location = new System.Drawing.Point(376, 2);
            this.lblTableColPhone.Name = "lblTableColPhone";
            this.lblTableColPhone.Size = new System.Drawing.Size(45, 46);
            this.lblTableColPhone.TabIndex = 14;
            this.lblTableColPhone.Text = "Phone";
            this.lblTableColPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTableColZip
            // 
            this.lblTableColZip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableColZip.Location = new System.Drawing.Point(323, 2);
            this.lblTableColZip.Name = "lblTableColZip";
            this.lblTableColZip.Size = new System.Drawing.Size(45, 46);
            this.lblTableColZip.TabIndex = 13;
            this.lblTableColZip.Text = "Zip";
            this.lblTableColZip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTableColState
            // 
            this.lblTableColState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableColState.Location = new System.Drawing.Point(270, 2);
            this.lblTableColState.Name = "lblTableColState";
            this.lblTableColState.Size = new System.Drawing.Size(45, 46);
            this.lblTableColState.TabIndex = 12;
            this.lblTableColState.Text = "State";
            this.lblTableColState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTableColCity
            // 
            this.lblTableColCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableColCity.Location = new System.Drawing.Point(217, 2);
            this.lblTableColCity.Name = "lblTableColCity";
            this.lblTableColCity.Size = new System.Drawing.Size(45, 46);
            this.lblTableColCity.TabIndex = 11;
            this.lblTableColCity.Text = "City";
            this.lblTableColCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTableColStreet
            // 
            this.lblTableColStreet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableColStreet.Location = new System.Drawing.Point(164, 2);
            this.lblTableColStreet.Name = "lblTableColStreet";
            this.lblTableColStreet.Size = new System.Drawing.Size(45, 46);
            this.lblTableColStreet.TabIndex = 10;
            this.lblTableColStreet.Text = "Street";
            this.lblTableColStreet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTableColID
            // 
            this.lblTableColID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableColID.Location = new System.Drawing.Point(5, 2);
            this.lblTableColID.Name = "lblTableColID";
            this.lblTableColID.Size = new System.Drawing.Size(45, 46);
            this.lblTableColID.TabIndex = 0;
            this.lblTableColID.Text = "ID";
            this.lblTableColID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTableColFirstName
            // 
            this.lblTableColFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableColFirstName.Location = new System.Drawing.Point(58, 2);
            this.lblTableColFirstName.Name = "lblTableColFirstName";
            this.lblTableColFirstName.Size = new System.Drawing.Size(45, 46);
            this.lblTableColFirstName.TabIndex = 1;
            this.lblTableColFirstName.Text = "First Name";
            this.lblTableColFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTableColLastName
            // 
            this.lblTableColLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableColLastName.Location = new System.Drawing.Point(111, 2);
            this.lblTableColLastName.Name = "lblTableColLastName";
            this.lblTableColLastName.Size = new System.Drawing.Size(45, 46);
            this.lblTableColLastName.TabIndex = 2;
            this.lblTableColLastName.Text = "Last Name";
            this.lblTableColLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabDisclaimer
            // 
            this.tabDisclaimer.Controls.Add(this.button5);
            this.tabDisclaimer.Controls.Add(this.label15);
            this.tabDisclaimer.Controls.Add(this.button2);
            this.tabDisclaimer.Controls.Add(this.btnDiscClear);
            this.tabDisclaimer.Controls.Add(this.lblCharCount);
            this.tabDisclaimer.Controls.Add(this.rtbDisclaimer);
            this.tabDisclaimer.Location = new System.Drawing.Point(4, 22);
            this.tabDisclaimer.Name = "tabDisclaimer";
            this.tabDisclaimer.Size = new System.Drawing.Size(498, 310);
            this.tabDisclaimer.TabIndex = 3;
            this.tabDisclaimer.Text = "Disclaimer";
            this.tabDisclaimer.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(46, 238);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(108, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(279, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "*The following text will be printed on the back of the card*";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnDiscClear
            // 
            this.btnDiscClear.Location = new System.Drawing.Point(266, 238);
            this.btnDiscClear.Name = "btnDiscClear";
            this.btnDiscClear.Size = new System.Drawing.Size(75, 23);
            this.btnDiscClear.TabIndex = 2;
            this.btnDiscClear.Text = "&Clear";
            this.btnDiscClear.UseVisualStyleBackColor = true;
            this.btnDiscClear.Click += new System.EventHandler(this.btnDiscClear_Click);
            // 
            // lblCharCount
            // 
            this.lblCharCount.AutoSize = true;
            this.lblCharCount.Location = new System.Drawing.Point(288, 212);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(135, 13);
            this.lblCharCount.TabIndex = 2;
            this.lblCharCount.Text = "Characters Remaining: 500";
            // 
            // rtbDisclaimer
            // 
            this.rtbDisclaimer.Location = new System.Drawing.Point(70, 69);
            this.rtbDisclaimer.Name = "rtbDisclaimer";
            this.rtbDisclaimer.Size = new System.Drawing.Size(353, 140);
            this.rtbDisclaimer.TabIndex = 0;
            this.rtbDisclaimer.Text = "";
            this.rtbDisclaimer.TextChanged += new System.EventHandler(this.disclaimerTextChanged);
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
            // openUserImage
            // 
            this.openUserImage.FileName = "openUserImage";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(148, 281);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblTableColAdmin
            // 
            this.lblTableColAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableColAdmin.Location = new System.Drawing.Point(429, 2);
            this.lblTableColAdmin.Name = "lblTableColAdmin";
            this.lblTableColAdmin.Size = new System.Drawing.Size(61, 46);
            this.lblTableColAdmin.TabIndex = 15;
            this.lblTableColAdmin.Text = "Admin";
            this.lblTableColAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tabLogin.PerformLayout();
            this.tabAddUser.ResumeLayout(false);
            this.tabAddUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImageBox)).EndInit();
            this.tabEditUser.ResumeLayout(false);
            this.tabEditUser.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabDisclaimer.ResumeLayout(false);
            this.tabDisclaimer.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabAddUser;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Label lblGraphicsVersion;
        private System.Windows.Forms.Label lblPrinterVersion;
        private System.Windows.Forms.Button btnPreviewID;
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
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.TabPage tabDisclaimer;
        private System.Windows.Forms.RichTextBox rtbDisclaimer;
        private System.Windows.Forms.Label lblCharCount;
        private System.Windows.Forms.Button btnDiscClear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbCheckForUser;
        private System.Windows.Forms.Button btnCheckForUser;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabPage tabEditUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTableColPhone;
        private System.Windows.Forms.Label lblTableColZip;
        private System.Windows.Forms.Label lblTableColState;
        private System.Windows.Forms.Label lblTableColCity;
        private System.Windows.Forms.Label lblTableColStreet;
        private System.Windows.Forms.Label lblTableColID;
        private System.Windows.Forms.Label lblTableColFirstName;
        private System.Windows.Forms.Label lblTableColLastName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl14;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTableColAdmin;
    }
}