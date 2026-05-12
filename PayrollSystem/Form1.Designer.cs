namespace PayrollSystem
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
            lblHeading = new Label();
            txtName = new TextBox();
            txtHours = new TextBox();
            txtDependents = new TextBox();
            lblName = new Label();
            lblHours = new Label();
            label4 = new Label();
            btnCalculate = new Button();
            btnReset = new Button();
            btnExit = new Button();
            lblGrossPay = new Label();
            lblPAYE = new Label();
            lblUIF = new Label();
            lblMembership = new Label();
            lblNET = new Label();
            txtGrossPay = new TextBox();
            txtPAYE = new TextBox();
            txtUIF = new TextBox();
            txtMembership = new TextBox();
            txtNET = new TextBox();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = SystemColors.Control;
            lblHeading.Location = new Point(317, 24);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(330, 35);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Mzanzi Tech Contractors";
            // 
            // txtName
            // 
            txtName.Location = new Point(216, 121);
            txtName.Name = "txtName";
            txtName.Size = new Size(218, 27);
            txtName.TabIndex = 1;
            // 
            // txtHours
            // 
            txtHours.Location = new Point(216, 176);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(218, 27);
            txtHours.TabIndex = 2;
            // 
            // txtDependents
            // 
            txtDependents.Location = new Point(216, 233);
            txtDependents.Name = "txtDependents";
            txtDependents.Size = new Size(218, 27);
            txtDependents.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.Control;
            lblName.Location = new Point(37, 121);
            lblName.Name = "lblName";
            lblName.Size = new Size(130, 20);
            lblName.TabIndex = 4;
            lblName.Text = "Contractor Name";
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHours.ForeColor = SystemColors.Control;
            lblHours.Location = new Point(37, 179);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(110, 20);
            lblHours.TabIndex = 5;
            lblHours.Text = "Hours Worked";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(37, 237);
            label4.Name = "label4";
            label4.Size = new Size(174, 20);
            label4.TabIndex = 6;
            label4.Text = "Number of Dependants";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(37, 288);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(149, 53);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate Net Pay";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(194, 288);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(117, 53);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(317, 288);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(117, 53);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblGrossPay
            // 
            lblGrossPay.AutoSize = true;
            lblGrossPay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrossPay.ForeColor = SystemColors.Control;
            lblGrossPay.Location = new Point(561, 121);
            lblGrossPay.Name = "lblGrossPay";
            lblGrossPay.Size = new Size(82, 20);
            lblGrossPay.TabIndex = 10;
            lblGrossPay.Text = "Gross Pay:";
            // 
            // lblPAYE
            // 
            lblPAYE.AutoSize = true;
            lblPAYE.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPAYE.ForeColor = SystemColors.Control;
            lblPAYE.Location = new Point(561, 176);
            lblPAYE.Name = "lblPAYE";
            lblPAYE.Size = new Size(124, 20);
            lblPAYE.TabIndex = 11;
            lblPAYE.Text = "PAYE Deduction:";
            // 
            // lblUIF
            // 
            lblUIF.AutoSize = true;
            lblUIF.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUIF.ForeColor = SystemColors.Control;
            lblUIF.Location = new Point(561, 233);
            lblUIF.Name = "lblUIF";
            lblUIF.Size = new Size(113, 20);
            lblUIF.TabIndex = 12;
            lblUIF.Text = "UIF Deduction:";
            // 
            // lblMembership
            // 
            lblMembership.AutoSize = true;
            lblMembership.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMembership.ForeColor = SystemColors.Control;
            lblMembership.Location = new Point(561, 288);
            lblMembership.Name = "lblMembership";
            lblMembership.Size = new Size(129, 20);
            lblMembership.TabIndex = 13;
            lblMembership.Text = "Membership Fee:";
            // 
            // lblNET
            // 
            lblNET.AutoSize = true;
            lblNET.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNET.ForeColor = SystemColors.Control;
            lblNET.Location = new Point(561, 339);
            lblNET.Name = "lblNET";
            lblNET.Size = new Size(67, 20);
            lblNET.TabIndex = 14;
            lblNET.Text = "NET Pay";
            // 
            // txtGrossPay
            // 
            txtGrossPay.Location = new Point(718, 118);
            txtGrossPay.Name = "txtGrossPay";
            txtGrossPay.Size = new Size(218, 27);
            txtGrossPay.TabIndex = 15;
            // 
            // txtPAYE
            // 
            txtPAYE.Location = new Point(718, 169);
            txtPAYE.Name = "txtPAYE";
            txtPAYE.Size = new Size(218, 27);
            txtPAYE.TabIndex = 16;
            // 
            // txtUIF
            // 
            txtUIF.Location = new Point(718, 230);
            txtUIF.Name = "txtUIF";
            txtUIF.Size = new Size(218, 27);
            txtUIF.TabIndex = 17;
            // 
            // txtMembership
            // 
            txtMembership.Location = new Point(718, 285);
            txtMembership.Name = "txtMembership";
            txtMembership.Size = new Size(218, 27);
            txtMembership.TabIndex = 18;
            // 
            // txtNET
            // 
            txtNET.Location = new Point(718, 336);
            txtNET.Name = "txtNET";
            txtNET.Size = new Size(218, 27);
            txtNET.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1030, 484);
            Controls.Add(txtNET);
            Controls.Add(txtMembership);
            Controls.Add(txtUIF);
            Controls.Add(txtPAYE);
            Controls.Add(txtGrossPay);
            Controls.Add(lblNET);
            Controls.Add(lblMembership);
            Controls.Add(lblUIF);
            Controls.Add(lblPAYE);
            Controls.Add(lblGrossPay);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnCalculate);
            Controls.Add(label4);
            Controls.Add(lblHours);
            Controls.Add(lblName);
            Controls.Add(txtDependents);
            Controls.Add(txtHours);
            Controls.Add(txtName);
            Controls.Add(lblHeading);
            Name = "Form1";
            Text = "Mzanzi Tech Contractors Payroll System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private TextBox txtName;
        private TextBox txtHours;
        private TextBox txtDependents;
        private Label lblName;
        private Label lblHours;
        private Label label4;
        private Button btnCalculate;
        private Button btnReset;
        private Button btnExit;
        private Label lblGrossPay;
        private Label lblPAYE;
        private Label lblUIF;
        private Label lblMembership;
        private Label lblNET;
        private TextBox txtGrossPay;
        private TextBox txtPAYE;
        private TextBox txtUIF;
        private TextBox txtMembership;
        private TextBox txtNET;
    }
}
