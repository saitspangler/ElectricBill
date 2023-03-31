namespace ElectricBill
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
            lbCustomers = new ListBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblkWh = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtkWh = new TextBox();
            btnBill = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTotalCust = new TextBox();
            txtAvgBill = new TextBox();
            txtKWHUsed = new TextBox();
            SuspendLayout();
            // 
            // lbCustomers
            // 
            lbCustomers.FormattingEnabled = true;
            lbCustomers.ItemHeight = 19;
            lbCustomers.Location = new Point(59, 227);
            lbCustomers.Margin = new Padding(4, 3, 4, 3);
            lbCustomers.Name = "lbCustomers";
            lbCustomers.Size = new Size(872, 175);
            lbCustomers.TabIndex = 0;
            lbCustomers.Tag = "Customer List";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(59, 47);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(109, 19);
            lblFirstName.TabIndex = 1;
            lblFirstName.Tag = "lblFirstName";
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(59, 89);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(99, 19);
            lblLastName.TabIndex = 2;
            lblLastName.Tag = "lblLastName";
            lblLastName.Text = "Last Name";
            // 
            // lblkWh
            // 
            lblkWh.AutoSize = true;
            lblkWh.Location = new Point(59, 134);
            lblkWh.Margin = new Padding(4, 0, 4, 0);
            lblkWh.Name = "lblkWh";
            lblkWh.Size = new Size(89, 19);
            lblkWh.TabIndex = 3;
            lblkWh.Tag = "lblkWh";
            lblkWh.Text = "kWh Used";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(177, 38);
            txtFirstName.Margin = new Padding(4, 3, 4, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(141, 26);
            txtFirstName.TabIndex = 4;
            txtFirstName.Tag = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(177, 80);
            txtLastName.Margin = new Padding(4, 3, 4, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(141, 26);
            txtLastName.TabIndex = 5;
            txtLastName.Tag = "Last Name";
            // 
            // txtkWh
            // 
            txtkWh.Location = new Point(177, 125);
            txtkWh.Margin = new Padding(4, 3, 4, 3);
            txtkWh.Name = "txtkWh";
            txtkWh.Size = new Size(141, 26);
            txtkWh.TabIndex = 6;
            txtkWh.Tag = "kWh";
            // 
            // btnBill
            // 
            btnBill.Location = new Point(353, 66);
            btnBill.Name = "btnBill";
            btnBill.Size = new Size(219, 53);
            btnBill.TabIndex = 7;
            btnBill.Text = "&Calculate Bill";
            btnBill.UseVisualStyleBackColor = true;
            btnBill.Click += btnBill_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 182);
            label1.Name = "label1";
            label1.Size = new Size(129, 19);
            label1.TabIndex = 9;
            label1.Text = "List of Accounts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 441);
            label2.Name = "label2";
            label2.Size = new Size(159, 19);
            label2.TabIndex = 10;
            label2.Text = "Total Customers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(393, 441);
            label3.Name = "label3";
            label3.Size = new Size(149, 19);
            label3.TabIndex = 11;
            label3.Text = "Total kWh Used";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(697, 441);
            label4.Name = "label4";
            label4.Size = new Size(129, 19);
            label4.TabIndex = 12;
            label4.Text = "Average Bill";
            // 
            // txtTotalCust
            // 
            txtTotalCust.Location = new Point(97, 484);
            txtTotalCust.Name = "txtTotalCust";
            txtTotalCust.ReadOnly = true;
            txtTotalCust.Size = new Size(159, 26);
            txtTotalCust.TabIndex = 13;
            // 
            // txtAvgBill
            // 
            txtAvgBill.Location = new Point(697, 484);
            txtAvgBill.Name = "txtAvgBill";
            txtAvgBill.ReadOnly = true;
            txtAvgBill.Size = new Size(121, 26);
            txtAvgBill.TabIndex = 14;
            // 
            // txtKWHUsed
            // 
            txtKWHUsed.Location = new Point(393, 484);
            txtKWHUsed.Name = "txtKWHUsed";
            txtKWHUsed.ReadOnly = true;
            txtKWHUsed.Size = new Size(129, 26);
            txtKWHUsed.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 710);
            Controls.Add(txtKWHUsed);
            Controls.Add(txtAvgBill);
            Controls.Add(txtTotalCust);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBill);
            Controls.Add(txtkWh);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblkWh);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lbCustomers);
            Font = new Font("Hack Nerd Font Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbCustomers;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblkWh;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtkWh;
        private Button btnBill;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTotalCust;
        private TextBox txtAvgBill;
        private TextBox txtKWHUsed;
    }
}