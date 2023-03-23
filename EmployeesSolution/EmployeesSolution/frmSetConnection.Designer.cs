namespace EmployeesSolution
{
    partial class frmSetConnection
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtServer = new TextBox();
            txtCatalog = new TextBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            chkSecurity = new CheckBox();
            btnTest = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 64);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Server";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 103);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Initial Catalog";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 139);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "User ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 177);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // txtServer
            // 
            txtServer.Location = new Point(158, 64);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(100, 23);
            txtServer.TabIndex = 4;
            // 
            // txtCatalog
            // 
            txtCatalog.Location = new Point(158, 100);
            txtCatalog.Name = "txtCatalog";
            txtCatalog.Size = new Size(100, 23);
            txtCatalog.TabIndex = 5;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(158, 139);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(100, 23);
            txtUser.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(158, 177);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 7;
            // 
            // chkSecurity
            // 
            chkSecurity.AutoSize = true;
            chkSecurity.Location = new Point(283, 141);
            chkSecurity.Name = "chkSecurity";
            chkSecurity.Size = new Size(125, 19);
            chkSecurity.TabIndex = 8;
            chkSecurity.Text = "Integrated Security";
            chkSecurity.UseVisualStyleBackColor = true;
            chkSecurity.CheckedChanged += chkSecurity_CheckedChanged;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(64, 236);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(75, 23);
            btnTest.TabIndex = 9;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(183, 236);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmSetConnection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 306);
            Controls.Add(btnExit);
            Controls.Add(btnTest);
            Controls.Add(chkSecurity);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(txtCatalog);
            Controls.Add(txtServer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSetConnection";
            Text = "Set Connection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtServer;
        private TextBox txtCatalog;
        private TextBox txtUser;
        private TextBox txtPassword;
        private CheckBox chkSecurity;
        private Button btnTest;
        private Button btnExit;
    }
}