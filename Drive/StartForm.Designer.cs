namespace Drive
{
    partial class StartForm
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
            this.pnLogin = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTitle = new System.Windows.Forms.Label();
            this.pnRegister = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRegis = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnReset1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.pnReset2 = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txbConfirmNewPass = new Drive.CustomControl.TextBoxCustom();
            this.txbNewPass = new Drive.CustomControl.TextBoxCustom();
            this.txbOTP = new Drive.CustomControl.TextBoxCustom();
            this.txbPwLogin = new Drive.CustomControl.TextBoxCustom();
            this.txbEmailLogin = new Drive.CustomControl.TextBoxCustom();
            this.txbNameRegis = new Drive.CustomControl.TextBoxCustom();
            this.txbConfirmRegis = new Drive.CustomControl.TextBoxCustom();
            this.txbPwRegis = new Drive.CustomControl.TextBoxCustom();
            this.txbEmailRegis = new Drive.CustomControl.TextBoxCustom();
            this.txbEmailReset = new Drive.CustomControl.TextBoxCustom();
            this.pnLogin.SuspendLayout();
            this.pnRegister.SuspendLayout();
            this.pnReset1.SuspendLayout();
            this.pnReset2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLogin
            // 
            this.pnLogin.Controls.Add(this.txbPwLogin);
            this.pnLogin.Controls.Add(this.txbEmailLogin);
            this.pnLogin.Controls.Add(this.label3);
            this.pnLogin.Controls.Add(this.label8);
            this.pnLogin.Controls.Add(this.btnSignIn);
            this.pnLogin.Controls.Add(this.label5);
            this.pnLogin.Controls.Add(this.label4);
            this.pnLogin.Controls.Add(this.label2);
            this.pnLogin.Controls.Add(this.txbTitle);
            this.pnLogin.Location = new System.Drawing.Point(35, 29);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(425, 481);
            this.pnLogin.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Forgot your password?";
            this.label3.Click += new System.EventHandler(this.LoadResetPass);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(342, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 23);
            this.label8.TabIndex = 27;
            this.label8.Text = "Sign up";
            this.label8.Click += new System.EventHandler(this.LoadRegisterPanel);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(307, 354);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(107, 49);
            this.btnSignIn.TabIndex = 26;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.SignIn);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Don\'t have an account?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 28);
            this.label4.TabIndex = 24;
            this.label4.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Email:";
            // 
            // txbTitle
            // 
            this.txbTitle.AutoSize = true;
            this.txbTitle.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTitle.Location = new System.Drawing.Point(129, 6);
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(174, 53);
            this.txbTitle.TabIndex = 13;
            this.txbTitle.Text = "Sign In";
            // 
            // pnRegister
            // 
            this.pnRegister.Controls.Add(this.txbNameRegis);
            this.pnRegister.Controls.Add(this.label6);
            this.pnRegister.Controls.Add(this.label1);
            this.pnRegister.Controls.Add(this.label13);
            this.pnRegister.Controls.Add(this.txbConfirmRegis);
            this.pnRegister.Controls.Add(this.label12);
            this.pnRegister.Controls.Add(this.txbPwRegis);
            this.pnRegister.Controls.Add(this.txbEmailRegis);
            this.pnRegister.Controls.Add(this.btnRegis);
            this.pnRegister.Controls.Add(this.label9);
            this.pnRegister.Controls.Add(this.label10);
            this.pnRegister.Controls.Add(this.label11);
            this.pnRegister.Location = new System.Drawing.Point(35, 29);
            this.pnRegister.Name = "pnRegister";
            this.pnRegister.Size = new System.Drawing.Size(425, 481);
            this.pnRegister.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "Sign in";
            this.label1.Click += new System.EventHandler(this.LoadLoginPage);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(150, 373);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 23);
            this.label13.TabIndex = 33;
            this.label13.Text = "Already have an account?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 28);
            this.label12.TabIndex = 31;
            this.label12.Text = "Confirm:";
            // 
            // btnRegis
            // 
            this.btnRegis.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRegis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegis.ForeColor = System.Drawing.Color.White;
            this.btnRegis.Location = new System.Drawing.Point(307, 418);
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.Size = new System.Drawing.Size(107, 49);
            this.btnRegis.TabIndex = 26;
            this.btnRegis.Text = "Sign up";
            this.btnRegis.UseVisualStyleBackColor = false;
            this.btnRegis.Click += new System.EventHandler(this.SignUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 28);
            this.label9.TabIndex = 24;
            this.label9.Text = "Password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 28);
            this.label10.TabIndex = 23;
            this.label10.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(113, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 53);
            this.label11.TabIndex = 13;
            this.label11.Text = "Sign up";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 28);
            this.label6.TabIndex = 35;
            this.label6.Text = "Name:";
            // 
            // pnReset1
            // 
            this.pnReset1.Controls.Add(this.btnSend);
            this.pnReset1.Controls.Add(this.txbEmailReset);
            this.pnReset1.Controls.Add(this.btnBack);
            this.pnReset1.Controls.Add(this.label17);
            this.pnReset1.Controls.Add(this.a);
            this.pnReset1.Location = new System.Drawing.Point(35, 29);
            this.pnReset1.Name = "pnReset1";
            this.pnReset1.Size = new System.Drawing.Size(425, 481);
            this.pnReset1.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(196, 228);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 49);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.LoadLoginPage);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(13, 168);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 28);
            this.label17.TabIndex = 23;
            this.label17.Text = "Email:";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(11, 6);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(404, 53);
            this.a.TabIndex = 13;
            this.a.Text = "Reset Password";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(307, 228);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(107, 49);
            this.btnSend.TabIndex = 30;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.LoadConfirmPage);
            // 
            // pnReset2
            // 
            this.pnReset2.Controls.Add(this.btnCancel);
            this.pnReset2.Controls.Add(this.txbConfirmNewPass);
            this.pnReset2.Controls.Add(this.lblConfirm);
            this.pnReset2.Controls.Add(this.txbNewPass);
            this.pnReset2.Controls.Add(this.lblNewPass);
            this.pnReset2.Controls.Add(this.btnConfirm);
            this.pnReset2.Controls.Add(this.txbOTP);
            this.pnReset2.Controls.Add(this.label7);
            this.pnReset2.Controls.Add(this.label14);
            this.pnReset2.Location = new System.Drawing.Point(35, 29);
            this.pnReset2.Name = "pnReset2";
            this.pnReset2.Size = new System.Drawing.Size(425, 481);
            this.pnReset2.TabIndex = 31;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(308, 354);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(107, 49);
            this.btnConfirm.TabIndex = 30;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.ConfirmOTP);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 28);
            this.label7.TabIndex = 23;
            this.label7.Text = "OTP:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(404, 53);
            this.label14.TabIndex = 13;
            this.label14.Text = "Reset Password";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.Location = new System.Drawing.Point(12, 223);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(107, 28);
            this.lblNewPass.TabIndex = 31;
            this.lblNewPass.Text = "New Pass:";
            this.lblNewPass.Visible = false;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.Location = new System.Drawing.Point(11, 278);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(93, 28);
            this.lblConfirm.TabIndex = 33;
            this.lblConfirm.Text = "Confirm:";
            this.lblConfirm.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(197, 354);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 49);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.LoadLoginPage);
            // 
            // txbConfirmNewPass
            // 
            this.txbConfirmNewPass.BackColor = System.Drawing.SystemColors.Window;
            this.txbConfirmNewPass.BorderColor = System.Drawing.Color.LightSlateGray;
            this.txbConfirmNewPass.BorderFocusColor = System.Drawing.Color.Black;
            this.txbConfirmNewPass.BorderRadius = 0;
            this.txbConfirmNewPass.BorderSize = 2;
            this.txbConfirmNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConfirmNewPass.ForeColor = System.Drawing.Color.DimGray;
            this.txbConfirmNewPass.Location = new System.Drawing.Point(147, 278);
            this.txbConfirmNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txbConfirmNewPass.Multiline = false;
            this.txbConfirmNewPass.Name = "txbConfirmNewPass";
            this.txbConfirmNewPass.Padding = new System.Windows.Forms.Padding(7);
            this.txbConfirmNewPass.PasswordChar = false;
            this.txbConfirmNewPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbConfirmNewPass.PlaceholderText = "";
            this.txbConfirmNewPass.ReadOnly = false;
            this.txbConfirmNewPass.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.txbConfirmNewPass.SelectionColor = System.Drawing.Color.Yellow;
            this.txbConfirmNewPass.Size = new System.Drawing.Size(265, 35);
            this.txbConfirmNewPass.TabIndex = 34;
            this.txbConfirmNewPass.Texts = "";
            this.txbConfirmNewPass.UnderlinedStyle = false;
            this.txbConfirmNewPass.Visible = false;
            // 
            // txbNewPass
            // 
            this.txbNewPass.BackColor = System.Drawing.SystemColors.Window;
            this.txbNewPass.BorderColor = System.Drawing.Color.LightSlateGray;
            this.txbNewPass.BorderFocusColor = System.Drawing.Color.Black;
            this.txbNewPass.BorderRadius = 0;
            this.txbNewPass.BorderSize = 2;
            this.txbNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewPass.ForeColor = System.Drawing.Color.DimGray;
            this.txbNewPass.Location = new System.Drawing.Point(148, 223);
            this.txbNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txbNewPass.Multiline = false;
            this.txbNewPass.Name = "txbNewPass";
            this.txbNewPass.Padding = new System.Windows.Forms.Padding(7);
            this.txbNewPass.PasswordChar = false;
            this.txbNewPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbNewPass.PlaceholderText = "";
            this.txbNewPass.ReadOnly = false;
            this.txbNewPass.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.txbNewPass.SelectionColor = System.Drawing.Color.Yellow;
            this.txbNewPass.Size = new System.Drawing.Size(265, 35);
            this.txbNewPass.TabIndex = 32;
            this.txbNewPass.Texts = "";
            this.txbNewPass.UnderlinedStyle = false;
            this.txbNewPass.Visible = false;
            // 
            // txbOTP
            // 
            this.txbOTP.BackColor = System.Drawing.SystemColors.Window;
            this.txbOTP.BorderColor = System.Drawing.Color.LightSlateGray;
            this.txbOTP.BorderFocusColor = System.Drawing.Color.Black;
            this.txbOTP.BorderRadius = 0;
            this.txbOTP.BorderSize = 2;
            this.txbOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOTP.ForeColor = System.Drawing.Color.DimGray;
            this.txbOTP.Location = new System.Drawing.Point(149, 168);
            this.txbOTP.Margin = new System.Windows.Forms.Padding(4);
            this.txbOTP.Multiline = false;
            this.txbOTP.Name = "txbOTP";
            this.txbOTP.Padding = new System.Windows.Forms.Padding(7);
            this.txbOTP.PasswordChar = false;
            this.txbOTP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbOTP.PlaceholderText = "";
            this.txbOTP.ReadOnly = false;
            this.txbOTP.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.txbOTP.SelectionColor = System.Drawing.Color.Yellow;
            this.txbOTP.Size = new System.Drawing.Size(265, 35);
            this.txbOTP.TabIndex = 29;
            this.txbOTP.Texts = "";
            this.txbOTP.UnderlinedStyle = false;
            // 
            // txbPwLogin
            // 
            this.txbPwLogin.BackColor = System.Drawing.SystemColors.Window;
            this.txbPwLogin.BorderColor = System.Drawing.Color.LightSlateGray;
            this.txbPwLogin.BorderFocusColor = System.Drawing.Color.Black;
            this.txbPwLogin.BorderRadius = 0;
            this.txbPwLogin.BorderSize = 2;
            this.txbPwLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPwLogin.ForeColor = System.Drawing.Color.DimGray;
            this.txbPwLogin.Location = new System.Drawing.Point(149, 245);
            this.txbPwLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txbPwLogin.Multiline = false;
            this.txbPwLogin.Name = "txbPwLogin";
            this.txbPwLogin.Padding = new System.Windows.Forms.Padding(7);
            this.txbPwLogin.PasswordChar = false;
            this.txbPwLogin.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbPwLogin.PlaceholderText = "";
            this.txbPwLogin.ReadOnly = false;
            this.txbPwLogin.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.txbPwLogin.SelectionColor = System.Drawing.Color.Yellow;
            this.txbPwLogin.Size = new System.Drawing.Size(265, 35);
            this.txbPwLogin.TabIndex = 30;
            this.txbPwLogin.Texts = "";
            this.txbPwLogin.UnderlinedStyle = false;
            // 
            // txbEmailLogin
            // 
            this.txbEmailLogin.BackColor = System.Drawing.SystemColors.Window;
            this.txbEmailLogin.BorderColor = System.Drawing.Color.LightSlateGray;
            this.txbEmailLogin.BorderFocusColor = System.Drawing.Color.Black;
            this.txbEmailLogin.BorderRadius = 0;
            this.txbEmailLogin.BorderSize = 2;
            this.txbEmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmailLogin.ForeColor = System.Drawing.Color.DimGray;
            this.txbEmailLogin.Location = new System.Drawing.Point(149, 168);
            this.txbEmailLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmailLogin.Multiline = false;
            this.txbEmailLogin.Name = "txbEmailLogin";
            this.txbEmailLogin.Padding = new System.Windows.Forms.Padding(7);
            this.txbEmailLogin.PasswordChar = false;
            this.txbEmailLogin.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbEmailLogin.PlaceholderText = "";
            this.txbEmailLogin.ReadOnly = false;
            this.txbEmailLogin.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.txbEmailLogin.SelectionColor = System.Drawing.Color.Yellow;
            this.txbEmailLogin.Size = new System.Drawing.Size(265, 35);
            this.txbEmailLogin.TabIndex = 29;
            this.txbEmailLogin.Texts = "";
            this.txbEmailLogin.UnderlinedStyle = false;
            // 
            // txbNameRegis
            // 
            this.txbNameRegis.BackColor = System.Drawing.SystemColors.Window;
            this.txbNameRegis.BorderColor = System.Drawing.Color.LightSlateGray;
            this.txbNameRegis.BorderFocusColor = System.Drawing.Color.Black;
            this.txbNameRegis.BorderRadius = 0;
            this.txbNameRegis.BorderSize = 2;
            this.txbNameRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameRegis.ForeColor = System.Drawing.Color.DimGray;
            this.txbNameRegis.Location = new System.Drawing.Point(149, 175);
            this.txbNameRegis.Margin = new System.Windows.Forms.Padding(4);
            this.txbNameRegis.Multiline = false;
            this.txbNameRegis.Name = "txbNameRegis";
            this.txbNameRegis.Padding = new System.Windows.Forms.Padding(7);
            this.txbNameRegis.PasswordChar = false;
            this.txbNameRegis.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbNameRegis.PlaceholderText = "";
            this.txbNameRegis.ReadOnly = false;
            this.txbNameRegis.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.txbNameRegis.SelectionColor = System.Drawing.Color.Yellow;
            this.txbNameRegis.Size = new System.Drawing.Size(265, 35);
            this.txbNameRegis.TabIndex = 36;
            this.txbNameRegis.Texts = "";
            this.txbNameRegis.UnderlinedStyle = false;
            // 
            // txbConfirmRegis
            // 
            this.txbConfirmRegis.BackColor = System.Drawing.SystemColors.Window;
            this.txbConfirmRegis.BorderColor = System.Drawing.Color.LightSlateGray;
            this.txbConfirmRegis.BorderFocusColor = System.Drawing.Color.Black;
            this.txbConfirmRegis.BorderRadius = 0;
            this.txbConfirmRegis.BorderSize = 2;
            this.txbConfirmRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConfirmRegis.ForeColor = System.Drawing.Color.DimGray;
            this.txbConfirmRegis.Location = new System.Drawing.Point(148, 303);
            this.txbConfirmRegis.Margin = new System.Windows.Forms.Padding(4);
            this.txbConfirmRegis.Multiline = false;
            this.txbConfirmRegis.Name = "txbConfirmRegis";
            this.txbConfirmRegis.Padding = new System.Windows.Forms.Padding(7);
            this.txbConfirmRegis.PasswordChar = false;
            this.txbConfirmRegis.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbConfirmRegis.PlaceholderText = "";
            this.txbConfirmRegis.ReadOnly = false;
            this.txbConfirmRegis.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.txbConfirmRegis.SelectionColor = System.Drawing.Color.Yellow;
            this.txbConfirmRegis.Size = new System.Drawing.Size(265, 35);
            this.txbConfirmRegis.TabIndex = 32;
            this.txbConfirmRegis.Texts = "";
            this.txbConfirmRegis.UnderlinedStyle = false;
            // 
            // txbPwRegis
            // 
            this.txbPwRegis.BackColor = System.Drawing.SystemColors.Window;
            this.txbPwRegis.BorderColor = System.Drawing.Color.LightSlateGray;
            this.txbPwRegis.BorderFocusColor = System.Drawing.Color.Black;
            this.txbPwRegis.BorderRadius = 0;
            this.txbPwRegis.BorderSize = 2;
            this.txbPwRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPwRegis.ForeColor = System.Drawing.Color.DimGray;
            this.txbPwRegis.Location = new System.Drawing.Point(149, 238);
            this.txbPwRegis.Margin = new System.Windows.Forms.Padding(4);
            this.txbPwRegis.Multiline = false;
            this.txbPwRegis.Name = "txbPwRegis";
            this.txbPwRegis.Padding = new System.Windows.Forms.Padding(7);
            this.txbPwRegis.PasswordChar = false;
            this.txbPwRegis.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbPwRegis.PlaceholderText = "";
            this.txbPwRegis.ReadOnly = false;
            this.txbPwRegis.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.txbPwRegis.SelectionColor = System.Drawing.Color.Yellow;
            this.txbPwRegis.Size = new System.Drawing.Size(265, 35);
            this.txbPwRegis.TabIndex = 30;
            this.txbPwRegis.Texts = "";
            this.txbPwRegis.UnderlinedStyle = false;
            // 
            // txbEmailRegis
            // 
            this.txbEmailRegis.BackColor = System.Drawing.SystemColors.Window;
            this.txbEmailRegis.BorderColor = System.Drawing.Color.LightSlateGray;
            this.txbEmailRegis.BorderFocusColor = System.Drawing.Color.Black;
            this.txbEmailRegis.BorderRadius = 0;
            this.txbEmailRegis.BorderSize = 2;
            this.txbEmailRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmailRegis.ForeColor = System.Drawing.Color.DimGray;
            this.txbEmailRegis.Location = new System.Drawing.Point(149, 111);
            this.txbEmailRegis.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmailRegis.Multiline = false;
            this.txbEmailRegis.Name = "txbEmailRegis";
            this.txbEmailRegis.Padding = new System.Windows.Forms.Padding(7);
            this.txbEmailRegis.PasswordChar = false;
            this.txbEmailRegis.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbEmailRegis.PlaceholderText = "";
            this.txbEmailRegis.ReadOnly = false;
            this.txbEmailRegis.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.txbEmailRegis.SelectionColor = System.Drawing.Color.Yellow;
            this.txbEmailRegis.Size = new System.Drawing.Size(265, 35);
            this.txbEmailRegis.TabIndex = 29;
            this.txbEmailRegis.Texts = "";
            this.txbEmailRegis.UnderlinedStyle = false;
            // 
            // txbEmailReset
            // 
            this.txbEmailReset.BackColor = System.Drawing.SystemColors.Window;
            this.txbEmailReset.BorderColor = System.Drawing.Color.LightSlateGray;
            this.txbEmailReset.BorderFocusColor = System.Drawing.Color.Black;
            this.txbEmailReset.BorderRadius = 0;
            this.txbEmailReset.BorderSize = 2;
            this.txbEmailReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmailReset.ForeColor = System.Drawing.Color.DimGray;
            this.txbEmailReset.Location = new System.Drawing.Point(149, 168);
            this.txbEmailReset.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmailReset.Multiline = false;
            this.txbEmailReset.Name = "txbEmailReset";
            this.txbEmailReset.Padding = new System.Windows.Forms.Padding(7);
            this.txbEmailReset.PasswordChar = false;
            this.txbEmailReset.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbEmailReset.PlaceholderText = "";
            this.txbEmailReset.ReadOnly = false;
            this.txbEmailReset.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.txbEmailReset.SelectionColor = System.Drawing.Color.Yellow;
            this.txbEmailReset.Size = new System.Drawing.Size(265, 35);
            this.txbEmailReset.TabIndex = 29;
            this.txbEmailReset.Texts = "";
            this.txbEmailReset.UnderlinedStyle = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 576);
            this.Controls.Add(this.pnReset2);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.pnRegister);
            this.Controls.Add(this.pnReset1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.pnRegister.ResumeLayout(false);
            this.pnRegister.PerformLayout();
            this.pnReset1.ResumeLayout(false);
            this.pnReset1.PerformLayout();
            this.pnReset2.ResumeLayout(false);
            this.pnReset2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.Label txbTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private CustomControl.TextBoxCustom txbPwLogin;
        private CustomControl.TextBoxCustom txbEmailLogin;
        private System.Windows.Forms.Panel pnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private CustomControl.TextBoxCustom txbConfirmRegis;
        private System.Windows.Forms.Label label12;
        private CustomControl.TextBoxCustom txbPwRegis;
        private CustomControl.TextBoxCustom txbEmailRegis;
        private System.Windows.Forms.Button btnRegis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private CustomControl.TextBoxCustom txbNameRegis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnReset1;
        private System.Windows.Forms.Button btnSend;
        private CustomControl.TextBoxCustom txbEmailReset;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Panel pnReset2;
        private System.Windows.Forms.Button btnCancel;
        private CustomControl.TextBoxCustom txbConfirmNewPass;
        private System.Windows.Forms.Label lblConfirm;
        private CustomControl.TextBoxCustom txbNewPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Button btnConfirm;
        private CustomControl.TextBoxCustom txbOTP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
    }
}