namespace QuizManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label4 = new Label();
            txtSelectUser = new Guna.UI2.WinForms.Guna2ComboBox();
            btnExit = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            checkBoxShowHide = new CheckBox();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            wrongLabel = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btnStudentLogin = new Guna.UI2.WinForms.Guna2Button();
            btnStudentRegister = new Guna.UI2.WinForms.Guna2Button();
            txtEnrollmentNo = new Guna.UI2.WinForms.Guna2TextBox();
            label8 = new Label();
            label9 = new Label();
            wrongCredential = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(643, 12);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(579, 51);
            label1.TabIndex = 0;
            label1.Text = "Quiz Management System";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(801, 131);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(254, 33);
            label4.TabIndex = 3;
            label4.Text = "Select User Types";
            label4.Click += label4_Click;
            // 
            // txtSelectUser
            // 
            txtSelectUser.BackColor = Color.Transparent;
            txtSelectUser.CustomizableEdges = customizableEdges17;
            txtSelectUser.DrawMode = DrawMode.OwnerDrawFixed;
            txtSelectUser.DropDownStyle = ComboBoxStyle.DropDownList;
            txtSelectUser.FocusedColor = Color.FromArgb(94, 148, 255);
            txtSelectUser.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSelectUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSelectUser.ForeColor = Color.Black;
            txtSelectUser.ItemHeight = 30;
            txtSelectUser.Items.AddRange(new object[] { "Student", "Teacher" });
            txtSelectUser.Location = new Point(729, 177);
            txtSelectUser.Name = "txtSelectUser";
            txtSelectUser.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtSelectUser.Size = new Size(391, 36);
            txtSelectUser.TabIndex = 4;
            txtSelectUser.SelectedIndexChanged += txtSelectUser_SelectedIndexChanged;
            // 
            // btnExit
            // 
            btnExit.CustomizableEdges = customizableEdges19;
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.FillColor = Color.Empty;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageSize = new Size(30, 30);
            btnExit.Location = new Point(1653, 12);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnExit.Size = new Size(172, 68);
            btnExit.TabIndex = 6;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 486);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(661, 569);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxShowHide);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(wrongLabel);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(729, 307);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 529);
            panel1.TabIndex = 8;
            // 
            // checkBoxShowHide
            // 
            checkBoxShowHide.AutoSize = true;
            checkBoxShowHide.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxShowHide.Location = new Point(98, 341);
            checkBoxShowHide.Name = "checkBoxShowHide";
            checkBoxShowHide.Size = new Size(202, 36);
            checkBoxShowHide.TabIndex = 9;
            checkBoxShowHide.Text = "Show Password";
            checkBoxShowHide.UseVisualStyleBackColor = true;
            checkBoxShowHide.CheckedChanged += checkBoxShowHide_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 18;
            btnLogin.BorderThickness = 1;
            btnLogin.CustomizableEdges = customizableEdges21;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.LimeGreen;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.HoverState.FillColor = Color.White;
            btnLogin.HoverState.ForeColor = Color.LimeGreen;
            btnLogin.Location = new Point(25, 404);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btnLogin.Size = new Size(341, 36);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.CustomizableEdges = customizableEdges23;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.FromArgb(0, 0, 64);
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Location = new Point(25, 278);
            txtPassword.Margin = new Padding(4, 4, 4, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges24;
            txtPassword.Size = new Size(341, 36);
            txtPassword.TabIndex = 5;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUsername
            // 
            txtUsername.CustomizableEdges = customizableEdges25;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.FromArgb(0, 0, 64);
            txtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Location = new Point(25, 164);
            txtUsername.Margin = new Padding(4, 4, 4, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PlaceholderText = "";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges26;
            txtUsername.Size = new Size(341, 36);
            txtUsername.TabIndex = 4;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            txtUsername.TextChanged += guna2TextBox1_TextChanged;
            // 
            // wrongLabel
            // 
            wrongLabel.AutoSize = true;
            wrongLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Italic, GraphicsUnit.Point);
            wrongLabel.ForeColor = Color.Red;
            wrongLabel.Location = new Point(59, 479);
            wrongLabel.Name = "wrongLabel";
            wrongLabel.Size = new Size(287, 25);
            wrongLabel.TabIndex = 3;
            wrongLabel.Text = "Wrong Username 'or' Password";
            wrongLabel.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(131, 226);
            label5.Name = "label5";
            label5.Size = new Size(120, 29);
            label5.TabIndex = 2;
            label5.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(127, 108);
            label3.Name = "label3";
            label3.Size = new Size(124, 29);
            label3.TabIndex = 1;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(98, 29);
            label2.Name = "label2";
            label2.Size = new Size(182, 29);
            label2.TabIndex = 0;
            label2.Text = "Teacher Login";
            // 
            // panel2
            // 
            panel2.Controls.Add(wrongCredential);
            panel2.Controls.Add(btnStudentLogin);
            panel2.Controls.Add(btnStudentRegister);
            panel2.Controls.Add(txtEnrollmentNo);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(415, 219);
            panel2.Name = "panel2";
            panel2.Size = new Size(391, 529);
            panel2.TabIndex = 9;
            // 
            // btnStudentLogin
            // 
            btnStudentLogin.BorderRadius = 18;
            btnStudentLogin.BorderThickness = 1;
            btnStudentLogin.CustomizableEdges = customizableEdges27;
            btnStudentLogin.DisabledState.BorderColor = Color.DarkGray;
            btnStudentLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnStudentLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnStudentLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnStudentLogin.FillColor = Color.LimeGreen;
            btnStudentLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudentLogin.ForeColor = Color.White;
            btnStudentLogin.HoverState.FillColor = Color.White;
            btnStudentLogin.HoverState.ForeColor = Color.LimeGreen;
            btnStudentLogin.Location = new Point(25, 313);
            btnStudentLogin.Name = "btnStudentLogin";
            btnStudentLogin.ShadowDecoration.CustomizableEdges = customizableEdges28;
            btnStudentLogin.Size = new Size(341, 36);
            btnStudentLogin.TabIndex = 7;
            btnStudentLogin.Text = "Login";
            btnStudentLogin.Click += btnStudentLogin_Click;
            // 
            // btnStudentRegister
            // 
            btnStudentRegister.BorderRadius = 18;
            btnStudentRegister.BorderThickness = 1;
            btnStudentRegister.CustomizableEdges = customizableEdges29;
            btnStudentRegister.DisabledState.BorderColor = Color.DarkGray;
            btnStudentRegister.DisabledState.CustomBorderColor = Color.DarkGray;
            btnStudentRegister.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnStudentRegister.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnStudentRegister.FillColor = Color.LimeGreen;
            btnStudentRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudentRegister.ForeColor = Color.White;
            btnStudentRegister.HoverState.FillColor = Color.White;
            btnStudentRegister.HoverState.ForeColor = Color.LimeGreen;
            btnStudentRegister.Location = new Point(25, 385);
            btnStudentRegister.Name = "btnStudentRegister";
            btnStudentRegister.ShadowDecoration.CustomizableEdges = customizableEdges30;
            btnStudentRegister.Size = new Size(341, 36);
            btnStudentRegister.TabIndex = 6;
            btnStudentRegister.Text = "Register";
            btnStudentRegister.Click += btnStudentRegister_Click;
            // 
            // txtEnrollmentNo
            // 
            txtEnrollmentNo.CustomizableEdges = customizableEdges31;
            txtEnrollmentNo.DefaultText = "";
            txtEnrollmentNo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEnrollmentNo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEnrollmentNo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEnrollmentNo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEnrollmentNo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEnrollmentNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnrollmentNo.ForeColor = Color.FromArgb(0, 0, 64);
            txtEnrollmentNo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEnrollmentNo.Location = new Point(25, 205);
            txtEnrollmentNo.Margin = new Padding(4, 4, 4, 4);
            txtEnrollmentNo.Name = "txtEnrollmentNo";
            txtEnrollmentNo.PasswordChar = '\0';
            txtEnrollmentNo.PlaceholderText = "";
            txtEnrollmentNo.SelectedText = "";
            txtEnrollmentNo.ShadowDecoration.CustomizableEdges = customizableEdges32;
            txtEnrollmentNo.Size = new Size(341, 46);
            txtEnrollmentNo.TabIndex = 4;
            txtEnrollmentNo.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(68, 158);
            label8.Name = "label8";
            label8.Size = new Size(255, 29);
            label8.TabIndex = 1;
            label8.Text = "Student Enrollment No";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(106, 29);
            label9.Name = "label9";
            label9.Size = new Size(174, 29);
            label9.TabIndex = 0;
            label9.Text = "Student Login";
            // 
            // wrongCredential
            // 
            wrongCredential.AutoSize = true;
            wrongCredential.BackColor = Color.White;
            wrongCredential.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Italic, GraphicsUnit.Point);
            wrongCredential.ForeColor = Color.Red;
            wrongCredential.Location = new Point(87, 458);
            wrongCredential.Name = "wrongCredential";
            wrongCredential.Size = new Size(165, 25);
            wrongCredential.TabIndex = 8;
            wrongCredential.Text = "Wrong Credential";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(26F, 51F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1050);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(txtSelectUser);
            Controls.Add(label4);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 6, 7, 6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox txtSelectUser;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label wrongLabel;
        private Label label5;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private CheckBox checkBoxShowHide;
        private Panel panel2;
        private CheckBox checkBox1;
        private Guna.UI2.WinForms.Guna2Button btnStudentRegister;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtEnrollmentNo;
        private Label label7;
        private Label label8;
        private Label label9;
        private Guna.UI2.WinForms.Guna2Button btnStudentLogin;
        private Label wrongCredential;
    }
}