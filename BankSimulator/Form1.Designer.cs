namespace BankSimulator {
    partial class Form1 {
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.loginPwdTxt = new System.Windows.Forms.TextBox();
            this.loginIdTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clientIdLbl = new System.Windows.Forms.Label();
            this.pwdChangeBtn = new System.Windows.Forms.Button();
            this.pwdTxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.creditLimitLbl3 = new System.Windows.Forms.Label();
            this.balanceLbl3 = new System.Windows.Forms.Label();
            this.branchNumLbl3 = new System.Windows.Forms.Label();
            this.accountNameLbl3 = new System.Windows.Forms.Label();
            this.accountNumLbl3 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.creditLimitLbl2 = new System.Windows.Forms.Label();
            this.balanceLbl2 = new System.Windows.Forms.Label();
            this.branchNumLbl2 = new System.Windows.Forms.Label();
            this.accountNameLbl2 = new System.Windows.Forms.Label();
            this.accountNumLbl2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.creditLimitLbl1 = new System.Windows.Forms.Label();
            this.balanceLbl1 = new System.Windows.Forms.Label();
            this.branchNumLbl1 = new System.Windows.Forms.Label();
            this.accountNameLbl1 = new System.Windows.Forms.Label();
            this.accountNumLbl1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.transResultLbl = new System.Windows.Forms.Label();
            this.transAmountTxt = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.transConfirmBtn = new System.Windows.Forms.Button();
            this.transToBalanceLbl = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.transToCombo = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.transFromBalanceLbl = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.transFromCombo = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.depResultLbl = new System.Windows.Forms.Label();
            this.depConfirmBtn = new System.Windows.Forms.Button();
            this.depAmountTxt = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.depBalanceLbl = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.depCombo = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.withResultLbl = new System.Windows.Forms.Label();
            this.withComfirmBtn = new System.Windows.Forms.Button();
            this.withAmountTxt = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.withBalanceLbl = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.withCombo = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaction_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transcriptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new BankSimulator.Database1DataSet();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.transcriptTableAdapter = new BankSimulator.Database1DataSetTableAdapters.TranscriptTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transcriptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(27, 136);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1475, 1469);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.loginPwdTxt);
            this.tabPage1.Controls.Add(this.loginIdTxt);
            this.tabPage1.Controls.Add(this.loginBtn);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(10, 47);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1455, 1412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Welcome";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // loginPwdTxt
            // 
            this.loginPwdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.loginPwdTxt.Location = new System.Drawing.Point(603, 646);
            this.loginPwdTxt.Name = "loginPwdTxt";
            this.loginPwdTxt.PasswordChar = '*';
            this.loginPwdTxt.Size = new System.Drawing.Size(494, 58);
            this.loginPwdTxt.TabIndex = 2;
            // 
            // loginIdTxt
            // 
            this.loginIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.loginIdTxt.Location = new System.Drawing.Point(603, 548);
            this.loginIdTxt.Name = "loginIdTxt";
            this.loginIdTxt.Size = new System.Drawing.Size(494, 58);
            this.loginIdTxt.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(685, 748);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(412, 69);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(292, 652);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 52);
            this.label5.TabIndex = 3;
            this.label5.Text = "Passwrod: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(292, 554);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 52);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(58, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(441, 52);
            this.label3.TabIndex = 1;
            this.label3.Text = "Please Log In below.";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(22, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1406, 190);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome to \r\n            the CAPO OnlineBank Page!!";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.clientIdLbl);
            this.tabPage2.Controls.Add(this.pwdChangeBtn);
            this.tabPage2.Controls.Add(this.pwdTxt);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(10, 47);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1455, 1412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Your Information";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clientIdLbl
            // 
            this.clientIdLbl.AutoSize = true;
            this.clientIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clientIdLbl.Location = new System.Drawing.Point(878, 38);
            this.clientIdLbl.Name = "clientIdLbl";
            this.clientIdLbl.Size = new System.Drawing.Size(57, 40);
            this.clientIdLbl.TabIndex = 11;
            this.clientIdLbl.Text = "10";
            // 
            // pwdChangeBtn
            // 
            this.pwdChangeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pwdChangeBtn.Location = new System.Drawing.Point(1211, 108);
            this.pwdChangeBtn.Name = "pwdChangeBtn";
            this.pwdChangeBtn.Size = new System.Drawing.Size(169, 58);
            this.pwdChangeBtn.TabIndex = 10;
            this.pwdChangeBtn.Text = "Change";
            this.pwdChangeBtn.UseVisualStyleBackColor = true;
            this.pwdChangeBtn.Click += new System.EventHandler(this.pwdChangeBtn_Click);
            // 
            // pwdTxt
            // 
            this.pwdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pwdTxt.Location = new System.Drawing.Point(570, 108);
            this.pwdTxt.Name = "pwdTxt";
            this.pwdTxt.Size = new System.Drawing.Size(365, 48);
            this.pwdTxt.TabIndex = 9;
            this.pwdTxt.TextChanged += new System.EventHandler(this.pwdTxt_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.creditLimitLbl3);
            this.groupBox3.Controls.Add(this.balanceLbl3);
            this.groupBox3.Controls.Add(this.branchNumLbl3);
            this.groupBox3.Controls.Add(this.accountNameLbl3);
            this.groupBox3.Controls.Add(this.accountNumLbl3);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Location = new System.Drawing.Point(77, 960);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1303, 363);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account 3";
            // 
            // creditLimitLbl3
            // 
            this.creditLimitLbl3.AutoSize = true;
            this.creditLimitLbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.creditLimitLbl3.Location = new System.Drawing.Point(801, 291);
            this.creditLimitLbl3.Name = "creditLimitLbl3";
            this.creditLimitLbl3.Size = new System.Drawing.Size(57, 40);
            this.creditLimitLbl3.TabIndex = 21;
            this.creditLimitLbl3.Text = "10";
            // 
            // balanceLbl3
            // 
            this.balanceLbl3.AutoSize = true;
            this.balanceLbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.balanceLbl3.Location = new System.Drawing.Point(801, 234);
            this.balanceLbl3.Name = "balanceLbl3";
            this.balanceLbl3.Size = new System.Drawing.Size(57, 40);
            this.balanceLbl3.TabIndex = 20;
            this.balanceLbl3.Text = "10";
            // 
            // branchNumLbl3
            // 
            this.branchNumLbl3.AutoSize = true;
            this.branchNumLbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.branchNumLbl3.Location = new System.Drawing.Point(801, 170);
            this.branchNumLbl3.Name = "branchNumLbl3";
            this.branchNumLbl3.Size = new System.Drawing.Size(57, 40);
            this.branchNumLbl3.TabIndex = 19;
            this.branchNumLbl3.Text = "10";
            // 
            // accountNameLbl3
            // 
            this.accountNameLbl3.AutoSize = true;
            this.accountNameLbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.accountNameLbl3.Location = new System.Drawing.Point(801, 104);
            this.accountNameLbl3.Name = "accountNameLbl3";
            this.accountNameLbl3.Size = new System.Drawing.Size(57, 40);
            this.accountNameLbl3.TabIndex = 18;
            this.accountNameLbl3.Text = "10";
            // 
            // accountNumLbl3
            // 
            this.accountNumLbl3.AutoSize = true;
            this.accountNumLbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.accountNumLbl3.Location = new System.Drawing.Point(801, 41);
            this.accountNumLbl3.Name = "accountNumLbl3";
            this.accountNumLbl3.Size = new System.Drawing.Size(57, 40);
            this.accountNumLbl3.TabIndex = 17;
            this.accountNumLbl3.Text = "10";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label19.Location = new System.Drawing.Point(227, 291);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(219, 40);
            this.label19.TabIndex = 6;
            this.label19.Text = "Credit Limit: ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label20.Location = new System.Drawing.Point(227, 234);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(167, 40);
            this.label20.TabIndex = 5;
            this.label20.Text = "Balance: ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label21.Location = new System.Drawing.Point(227, 170);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(289, 40);
            this.label21.TabIndex = 4;
            this.label21.Text = "Branch Number: ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label22.Location = new System.Drawing.Point(227, 104);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(273, 40);
            this.label22.TabIndex = 3;
            this.label22.Text = "Account Name: ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label23.Location = new System.Drawing.Point(227, 41);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(315, 40);
            this.label23.TabIndex = 1;
            this.label23.Text = "Account Number:  ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.creditLimitLbl2);
            this.groupBox2.Controls.Add(this.balanceLbl2);
            this.groupBox2.Controls.Add(this.branchNumLbl2);
            this.groupBox2.Controls.Add(this.accountNameLbl2);
            this.groupBox2.Controls.Add(this.accountNumLbl2);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(77, 582);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1303, 363);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account 2";
            // 
            // creditLimitLbl2
            // 
            this.creditLimitLbl2.AutoSize = true;
            this.creditLimitLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.creditLimitLbl2.Location = new System.Drawing.Point(801, 291);
            this.creditLimitLbl2.Name = "creditLimitLbl2";
            this.creditLimitLbl2.Size = new System.Drawing.Size(57, 40);
            this.creditLimitLbl2.TabIndex = 21;
            this.creditLimitLbl2.Text = "10";
            // 
            // balanceLbl2
            // 
            this.balanceLbl2.AutoSize = true;
            this.balanceLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.balanceLbl2.Location = new System.Drawing.Point(801, 234);
            this.balanceLbl2.Name = "balanceLbl2";
            this.balanceLbl2.Size = new System.Drawing.Size(57, 40);
            this.balanceLbl2.TabIndex = 20;
            this.balanceLbl2.Text = "10";
            // 
            // branchNumLbl2
            // 
            this.branchNumLbl2.AutoSize = true;
            this.branchNumLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.branchNumLbl2.Location = new System.Drawing.Point(801, 170);
            this.branchNumLbl2.Name = "branchNumLbl2";
            this.branchNumLbl2.Size = new System.Drawing.Size(57, 40);
            this.branchNumLbl2.TabIndex = 19;
            this.branchNumLbl2.Text = "10";
            // 
            // accountNameLbl2
            // 
            this.accountNameLbl2.AutoSize = true;
            this.accountNameLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.accountNameLbl2.Location = new System.Drawing.Point(801, 104);
            this.accountNameLbl2.Name = "accountNameLbl2";
            this.accountNameLbl2.Size = new System.Drawing.Size(57, 40);
            this.accountNameLbl2.TabIndex = 18;
            this.accountNameLbl2.Text = "10";
            // 
            // accountNumLbl2
            // 
            this.accountNumLbl2.AutoSize = true;
            this.accountNumLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.accountNumLbl2.Location = new System.Drawing.Point(801, 41);
            this.accountNumLbl2.Name = "accountNumLbl2";
            this.accountNumLbl2.Size = new System.Drawing.Size(57, 40);
            this.accountNumLbl2.TabIndex = 17;
            this.accountNumLbl2.Text = "10";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(227, 291);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(219, 40);
            this.label14.TabIndex = 6;
            this.label14.Text = "Credit Limit: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(227, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(167, 40);
            this.label15.TabIndex = 5;
            this.label15.Text = "Balance: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.Location = new System.Drawing.Point(227, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(289, 40);
            this.label16.TabIndex = 4;
            this.label16.Text = "Branch Number: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label17.Location = new System.Drawing.Point(227, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(273, 40);
            this.label17.TabIndex = 3;
            this.label17.Text = "Account Name: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label18.Location = new System.Drawing.Point(227, 41);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(315, 40);
            this.label18.TabIndex = 1;
            this.label18.Text = "Account Number:  ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.creditLimitLbl1);
            this.groupBox1.Controls.Add(this.balanceLbl1);
            this.groupBox1.Controls.Add(this.branchNumLbl1);
            this.groupBox1.Controls.Add(this.accountNameLbl1);
            this.groupBox1.Controls.Add(this.accountNumLbl1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(77, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1303, 363);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account 1";
            // 
            // creditLimitLbl1
            // 
            this.creditLimitLbl1.AutoSize = true;
            this.creditLimitLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.creditLimitLbl1.Location = new System.Drawing.Point(801, 291);
            this.creditLimitLbl1.Name = "creditLimitLbl1";
            this.creditLimitLbl1.Size = new System.Drawing.Size(57, 40);
            this.creditLimitLbl1.TabIndex = 16;
            this.creditLimitLbl1.Text = "10";
            // 
            // balanceLbl1
            // 
            this.balanceLbl1.AutoSize = true;
            this.balanceLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.balanceLbl1.Location = new System.Drawing.Point(801, 234);
            this.balanceLbl1.Name = "balanceLbl1";
            this.balanceLbl1.Size = new System.Drawing.Size(57, 40);
            this.balanceLbl1.TabIndex = 15;
            this.balanceLbl1.Text = "10";
            // 
            // branchNumLbl1
            // 
            this.branchNumLbl1.AutoSize = true;
            this.branchNumLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.branchNumLbl1.Location = new System.Drawing.Point(801, 170);
            this.branchNumLbl1.Name = "branchNumLbl1";
            this.branchNumLbl1.Size = new System.Drawing.Size(57, 40);
            this.branchNumLbl1.TabIndex = 14;
            this.branchNumLbl1.Text = "10";
            // 
            // accountNameLbl1
            // 
            this.accountNameLbl1.AutoSize = true;
            this.accountNameLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.accountNameLbl1.Location = new System.Drawing.Point(801, 104);
            this.accountNameLbl1.Name = "accountNameLbl1";
            this.accountNameLbl1.Size = new System.Drawing.Size(57, 40);
            this.accountNameLbl1.TabIndex = 13;
            this.accountNameLbl1.Text = "10";
            // 
            // accountNumLbl1
            // 
            this.accountNumLbl1.AutoSize = true;
            this.accountNumLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.accountNumLbl1.Location = new System.Drawing.Point(801, 41);
            this.accountNumLbl1.Name = "accountNumLbl1";
            this.accountNumLbl1.Size = new System.Drawing.Size(57, 40);
            this.accountNumLbl1.TabIndex = 12;
            this.accountNumLbl1.Text = "10";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(227, 291);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(219, 40);
            this.label13.TabIndex = 6;
            this.label13.Text = "Credit Limit: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(227, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 40);
            this.label12.TabIndex = 5;
            this.label12.Text = "Balance: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(227, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(289, 40);
            this.label11.TabIndex = 4;
            this.label11.Text = "Branch Number: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(227, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(273, 40);
            this.label9.TabIndex = 3;
            this.label9.Text = "Account Name: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(227, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(315, 40);
            this.label7.TabIndex = 1;
            this.label7.Text = "Account Number:  ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(111, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 40);
            this.label10.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(70, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 40);
            this.label8.TabIndex = 2;
            this.label8.Text = "Password: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(70, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 40);
            this.label6.TabIndex = 0;
            this.label6.Text = "Client ID: ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Location = new System.Drawing.Point(10, 47);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1455, 1412);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Transaction";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.transResultLbl);
            this.groupBox6.Controls.Add(this.transAmountTxt);
            this.groupBox6.Controls.Add(this.label39);
            this.groupBox6.Controls.Add(this.transConfirmBtn);
            this.groupBox6.Controls.Add(this.transToBalanceLbl);
            this.groupBox6.Controls.Add(this.label38);
            this.groupBox6.Controls.Add(this.transToCombo);
            this.groupBox6.Controls.Add(this.label36);
            this.groupBox6.Controls.Add(this.transFromBalanceLbl);
            this.groupBox6.Controls.Add(this.label35);
            this.groupBox6.Controls.Add(this.transFromCombo);
            this.groupBox6.Controls.Add(this.label33);
            this.groupBox6.Location = new System.Drawing.Point(31, 824);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1377, 562);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Transfer";
            // 
            // transResultLbl
            // 
            this.transResultLbl.AutoSize = true;
            this.transResultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.transResultLbl.Location = new System.Drawing.Point(177, 479);
            this.transResultLbl.Name = "transResultLbl";
            this.transResultLbl.Size = new System.Drawing.Size(290, 36);
            this.transResultLbl.TabIndex = 10;
            this.transResultLbl.Text = "Transfer Succeeded!";
            // 
            // transAmountTxt
            // 
            this.transAmountTxt.Location = new System.Drawing.Point(751, 327);
            this.transAmountTxt.Name = "transAmountTxt";
            this.transAmountTxt.Size = new System.Drawing.Size(436, 35);
            this.transAmountTxt.TabIndex = 13;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label39.Location = new System.Drawing.Point(177, 324);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(252, 36);
            this.label39.TabIndex = 12;
            this.label39.Text = "Transfer Amount: ";
            // 
            // transConfirmBtn
            // 
            this.transConfirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.transConfirmBtn.Location = new System.Drawing.Point(1037, 458);
            this.transConfirmBtn.Name = "transConfirmBtn";
            this.transConfirmBtn.Size = new System.Drawing.Size(162, 57);
            this.transConfirmBtn.TabIndex = 11;
            this.transConfirmBtn.Text = "Confirm";
            this.transConfirmBtn.UseVisualStyleBackColor = true;
            this.transConfirmBtn.Click += new System.EventHandler(this.transConfirmBtn_Click);
            // 
            // transToBalanceLbl
            // 
            this.transToBalanceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.transToBalanceLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transToBalanceLbl.Location = new System.Drawing.Point(751, 250);
            this.transToBalanceLbl.Name = "transToBalanceLbl";
            this.transToBalanceLbl.Size = new System.Drawing.Size(436, 36);
            this.transToBalanceLbl.TabIndex = 10;
            this.transToBalanceLbl.Text = "0";
            this.transToBalanceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label38.Location = new System.Drawing.Point(177, 250);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(268, 36);
            this.label38.TabIndex = 9;
            this.label38.Text = "Available Balance: ";
            // 
            // transToCombo
            // 
            this.transToCombo.FormattingEnabled = true;
            this.transToCombo.Location = new System.Drawing.Point(751, 185);
            this.transToCombo.Name = "transToCombo";
            this.transToCombo.Size = new System.Drawing.Size(436, 37);
            this.transToCombo.TabIndex = 8;
            this.transToCombo.SelectedIndexChanged += new System.EventHandler(this.transToCombo_SelectedIndexChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label36.Location = new System.Drawing.Point(177, 182);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(398, 36);
            this.label36.TabIndex = 7;
            this.label36.Text = "Choose transfer account To: ";
            // 
            // transFromBalanceLbl
            // 
            this.transFromBalanceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.transFromBalanceLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transFromBalanceLbl.Location = new System.Drawing.Point(751, 121);
            this.transFromBalanceLbl.Name = "transFromBalanceLbl";
            this.transFromBalanceLbl.Size = new System.Drawing.Size(436, 36);
            this.transFromBalanceLbl.TabIndex = 6;
            this.transFromBalanceLbl.Text = "0";
            this.transFromBalanceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label35.Location = new System.Drawing.Point(177, 121);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(268, 36);
            this.label35.TabIndex = 5;
            this.label35.Text = "Available Balance: ";
            // 
            // transFromCombo
            // 
            this.transFromCombo.FormattingEnabled = true;
            this.transFromCombo.Location = new System.Drawing.Point(751, 55);
            this.transFromCombo.Name = "transFromCombo";
            this.transFromCombo.Size = new System.Drawing.Size(436, 37);
            this.transFromCombo.TabIndex = 4;
            this.transFromCombo.SelectedIndexChanged += new System.EventHandler(this.transFromCombo_SelectedIndexChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label33.Location = new System.Drawing.Point(177, 56);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(431, 36);
            this.label33.TabIndex = 3;
            this.label33.Text = "Choose transfer account From: ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.depResultLbl);
            this.groupBox5.Controls.Add(this.depConfirmBtn);
            this.groupBox5.Controls.Add(this.depAmountTxt);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.depBalanceLbl);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.depCombo);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Location = new System.Drawing.Point(31, 402);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1377, 416);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Deposit";
            // 
            // depResultLbl
            // 
            this.depResultLbl.AutoSize = true;
            this.depResultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.depResultLbl.Location = new System.Drawing.Point(177, 328);
            this.depResultLbl.Name = "depResultLbl";
            this.depResultLbl.Size = new System.Drawing.Size(281, 36);
            this.depResultLbl.TabIndex = 9;
            this.depResultLbl.Text = "Deposit Succeeded!";
            // 
            // depConfirmBtn
            // 
            this.depConfirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.depConfirmBtn.Location = new System.Drawing.Point(1025, 307);
            this.depConfirmBtn.Name = "depConfirmBtn";
            this.depConfirmBtn.Size = new System.Drawing.Size(162, 57);
            this.depConfirmBtn.TabIndex = 8;
            this.depConfirmBtn.Text = "Confirm";
            this.depConfirmBtn.UseVisualStyleBackColor = true;
            this.depConfirmBtn.Click += new System.EventHandler(this.depConfirmBtn_Click);
            // 
            // depAmountTxt
            // 
            this.depAmountTxt.Location = new System.Drawing.Point(751, 226);
            this.depAmountTxt.Name = "depAmountTxt";
            this.depAmountTxt.Size = new System.Drawing.Size(436, 35);
            this.depAmountTxt.TabIndex = 7;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label32.Location = new System.Drawing.Point(177, 223);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(243, 36);
            this.label32.TabIndex = 6;
            this.label32.Text = "Deposit Amount: ";
            // 
            // depBalanceLbl
            // 
            this.depBalanceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.depBalanceLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.depBalanceLbl.Location = new System.Drawing.Point(751, 154);
            this.depBalanceLbl.Name = "depBalanceLbl";
            this.depBalanceLbl.Size = new System.Drawing.Size(436, 36);
            this.depBalanceLbl.TabIndex = 5;
            this.depBalanceLbl.Text = "0";
            this.depBalanceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label31.Location = new System.Drawing.Point(177, 154);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(268, 36);
            this.label31.TabIndex = 4;
            this.label31.Text = "Available Balance: ";
            // 
            // depCombo
            // 
            this.depCombo.FormattingEnabled = true;
            this.depCombo.Location = new System.Drawing.Point(751, 77);
            this.depCombo.Name = "depCombo";
            this.depCombo.Size = new System.Drawing.Size(436, 37);
            this.depCombo.TabIndex = 2;
            this.depCombo.SelectedIndexChanged += new System.EventHandler(this.depCombo_SelectedIndexChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label29.Location = new System.Drawing.Point(177, 78);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(314, 36);
            this.label29.TabIndex = 1;
            this.label29.Text = "Choose your account: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.withResultLbl);
            this.groupBox4.Controls.Add(this.withComfirmBtn);
            this.groupBox4.Controls.Add(this.withAmountTxt);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.withBalanceLbl);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.withCombo);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Location = new System.Drawing.Point(31, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1377, 378);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Withdraw";
            // 
            // withResultLbl
            // 
            this.withResultLbl.AutoSize = true;
            this.withResultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.withResultLbl.Location = new System.Drawing.Point(177, 299);
            this.withResultLbl.Name = "withResultLbl";
            this.withResultLbl.Size = new System.Drawing.Size(306, 36);
            this.withResultLbl.TabIndex = 7;
            this.withResultLbl.Text = "Withdraw Succeeded!";
            // 
            // withComfirmBtn
            // 
            this.withComfirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.withComfirmBtn.Location = new System.Drawing.Point(1025, 278);
            this.withComfirmBtn.Name = "withComfirmBtn";
            this.withComfirmBtn.Size = new System.Drawing.Size(162, 57);
            this.withComfirmBtn.TabIndex = 6;
            this.withComfirmBtn.Text = "Confirm";
            this.withComfirmBtn.UseVisualStyleBackColor = true;
            this.withComfirmBtn.Click += new System.EventHandler(this.withComfirmBtn_Click);
            // 
            // withAmountTxt
            // 
            this.withAmountTxt.Location = new System.Drawing.Point(751, 194);
            this.withAmountTxt.Name = "withAmountTxt";
            this.withAmountTxt.Size = new System.Drawing.Size(436, 35);
            this.withAmountTxt.TabIndex = 5;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label28.Location = new System.Drawing.Point(177, 191);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(268, 36);
            this.label28.TabIndex = 4;
            this.label28.Text = "Withdraw Amount: ";
            // 
            // withBalanceLbl
            // 
            this.withBalanceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.withBalanceLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.withBalanceLbl.Location = new System.Drawing.Point(745, 129);
            this.withBalanceLbl.Name = "withBalanceLbl";
            this.withBalanceLbl.Size = new System.Drawing.Size(442, 36);
            this.withBalanceLbl.TabIndex = 3;
            this.withBalanceLbl.Text = "0";
            this.withBalanceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label26.Location = new System.Drawing.Point(177, 129);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(268, 36);
            this.label26.TabIndex = 2;
            this.label26.Text = "Available Balance: ";
            // 
            // withCombo
            // 
            this.withCombo.FormattingEnabled = true;
            this.withCombo.Location = new System.Drawing.Point(751, 62);
            this.withCombo.Name = "withCombo";
            this.withCombo.Size = new System.Drawing.Size(436, 37);
            this.withCombo.TabIndex = 1;
            this.withCombo.SelectedIndexChanged += new System.EventHandler(this.withCombo_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label25.Location = new System.Drawing.Point(177, 59);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(314, 36);
            this.label25.TabIndex = 0;
            this.label25.Text = "Choose your account: ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label24.Location = new System.Drawing.Point(51, 48);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(0, 40);
            this.label24.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reloadBtn);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(10, 47);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1455, 1412);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Histroy";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reloadBtn
            // 
            this.reloadBtn.Location = new System.Drawing.Point(1202, 1313);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(205, 60);
            this.reloadBtn.TabIndex = 5;
            this.reloadBtn.Text = "Reload";
            this.reloadBtn.UseVisualStyleBackColor = true;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Time,
            this.Transaction_Type,
            this.Amount,
            this.BranchCode});
            this.dataGridView1.Location = new System.Drawing.Point(63, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1344, 1231);
            this.dataGridView1.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "{0:MM/dd/yyyy}";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // Transaction_Type
            // 
            this.Transaction_Type.HeaderText = "Transaction_Type";
            this.Transaction_Type.Name = "Transaction_Type";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // BranchCode
            // 
            this.BranchCode.HeaderText = "BranchCode";
            this.BranchCode.Name = "BranchCode";
            // 
            // transcriptBindingSource
            // 
            this.transcriptBindingSource.DataMember = "Transcript";
            this.transcriptBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(1287, 47);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(205, 60);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(811, 102);
            this.label1.TabIndex = 2;
            this.label1.Text = "CAPO Online Bank";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(1287, 1611);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(205, 60);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // transcriptTableAdapter
            // 
            this.transcriptTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1529, 1707);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "CAPO BANK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transcriptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox loginPwdTxt;
        private System.Windows.Forms.TextBox loginIdTxt;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button pwdChangeBtn;
        private System.Windows.Forms.TextBox pwdTxt;
        private System.Windows.Forms.Label clientIdLbl;
        private System.Windows.Forms.Label creditLimitLbl3;
        private System.Windows.Forms.Label balanceLbl3;
        private System.Windows.Forms.Label branchNumLbl3;
        private System.Windows.Forms.Label accountNameLbl3;
        private System.Windows.Forms.Label accountNumLbl3;
        private System.Windows.Forms.Label creditLimitLbl2;
        private System.Windows.Forms.Label balanceLbl2;
        private System.Windows.Forms.Label branchNumLbl2;
        private System.Windows.Forms.Label accountNameLbl2;
        private System.Windows.Forms.Label accountNumLbl2;
        private System.Windows.Forms.Label creditLimitLbl1;
        private System.Windows.Forms.Label balanceLbl1;
        private System.Windows.Forms.Label branchNumLbl1;
        private System.Windows.Forms.Label accountNameLbl1;
        private System.Windows.Forms.Label accountNumLbl1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label transResultLbl;
        private System.Windows.Forms.TextBox transAmountTxt;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Button transConfirmBtn;
        private System.Windows.Forms.Label transToBalanceLbl;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox transToCombo;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label transFromBalanceLbl;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox transFromCombo;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label depResultLbl;
        private System.Windows.Forms.Button depConfirmBtn;
        private System.Windows.Forms.TextBox depAmountTxt;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label depBalanceLbl;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox depCombo;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label withResultLbl;
        private System.Windows.Forms.Button withComfirmBtn;
        private System.Windows.Forms.TextBox withAmountTxt;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label withBalanceLbl;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox withCombo;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TabPage tabPage4;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource transcriptBindingSource;
        private Database1DataSetTableAdapters.TranscriptTableAdapter transcriptTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchCode;
        private System.Windows.Forms.Button reloadBtn;
    }
}

