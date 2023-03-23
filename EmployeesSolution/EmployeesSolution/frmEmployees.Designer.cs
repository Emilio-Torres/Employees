namespace EmployeesSolution
{
    partial class frmEmployees
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
            btnConnection = new Button();
            btnAdd = new Button();
            cmbstatus = new ComboBox();
            dtpBorn = new DateTimePicker();
            txtRFC = new TextBox();
            txtLastName = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvEmployees = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colLastName = new DataGridViewTextBoxColumn();
            colRFC = new DataGridViewTextBoxColumn();
            colBornDate = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // btnConnection
            // 
            btnConnection.Location = new Point(221, 245);
            btnConnection.Name = "btnConnection";
            btnConnection.Size = new Size(101, 23);
            btnConnection.TabIndex = 27;
            btnConnection.Text = "Set Connection";
            btnConnection.UseVisualStyleBackColor = true;
            btnConnection.Click += btnConnection_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(49, 245);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(101, 23);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Add Employee";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbstatus
            // 
            cmbstatus.FormattingEnabled = true;
            cmbstatus.Items.AddRange(new object[] { "NotSet", "Active", "Inactive" });
            cmbstatus.Location = new Point(149, 196);
            cmbstatus.Name = "cmbstatus";
            cmbstatus.Size = new Size(121, 23);
            cmbstatus.TabIndex = 25;
            // 
            // dtpBorn
            // 
            dtpBorn.Format = DateTimePickerFormat.Short;
            dtpBorn.Location = new Point(149, 167);
            dtpBorn.Name = "dtpBorn";
            dtpBorn.Size = new Size(102, 23);
            dtpBorn.TabIndex = 24;
            // 
            // txtRFC
            // 
            txtRFC.CharacterCasing = CharacterCasing.Upper;
            txtRFC.Location = new Point(149, 134);
            txtRFC.Name = "txtRFC";
            txtRFC.Size = new Size(173, 23);
            txtRFC.TabIndex = 23;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(149, 104);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(173, 23);
            txtLastName.TabIndex = 22;
            // 
            // txtName
            // 
            txtName.Location = new Point(149, 74);
            txtName.Name = "txtName";
            txtName.Size = new Size(173, 23);
            txtName.TabIndex = 21;
            // 
            // txtId
            // 
            txtId.Location = new Point(149, 44);
            txtId.Name = "txtId";
            txtId.Size = new Size(102, 23);
            txtId.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 47);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 19;
            label6.Text = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 167);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 18;
            label5.Text = "Born Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 197);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 17;
            label4.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 137);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 16;
            label3.Text = "RFC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 77);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 15;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 107);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 14;
            label1.Text = "Last Name";
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colLastName, colRFC, colBornDate, colStatus });
            dgvEmployees.Location = new Point(391, 49);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.RowTemplate.Height = 25;
            dgvEmployees.Size = new Size(631, 219);
            dgvEmployees.TabIndex = 28;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.Name = "colID";
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";
            colName.Name = "colName";
            // 
            // colLastName
            // 
            colLastName.DataPropertyName = "LastName";
            colLastName.HeaderText = "Last Name";
            colLastName.Name = "colLastName";
            // 
            // colRFC
            // 
            colRFC.DataPropertyName = "RFC";
            colRFC.HeaderText = "RFC";
            colRFC.Name = "colRFC";
            // 
            // colBornDate
            // 
            colBornDate.DataPropertyName = "BornDate";
            colBornDate.HeaderText = "Born Date";
            colBornDate.Name = "colBornDate";
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(490, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(102, 23);
            textBox1.TabIndex = 29;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(391, 28);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 30;
            label7.Text = "Filter by Name";
            // 
            // frmEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 323);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(dgvEmployees);
            Controls.Add(btnConnection);
            Controls.Add(btnAdd);
            Controls.Add(cmbstatus);
            Controls.Add(dtpBorn);
            Controls.Add(txtRFC);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEmployees";
            Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnection;
        private Button btnAdd;
        private ComboBox cmbstatus;
        private DateTimePicker dtpBorn;
        private TextBox txtRFC;
        private TextBox txtLastName;
        private TextBox txtName;
        private TextBox txtId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvEmployees;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colLastName;
        private DataGridViewTextBoxColumn colRFC;
        private DataGridViewTextBoxColumn colBornDate;
        private DataGridViewTextBoxColumn colStatus;
        private TextBox textBox1;
        private Label label7;
    }
}