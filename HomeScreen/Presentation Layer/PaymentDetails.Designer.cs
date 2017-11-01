namespace INF2011SProject.Presentation_Layer
{
    partial class PaymentDetails
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
            this.lblCCPayment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtboxCVV = new System.Windows.Forms.TextBox();
            this.txtboxExpiry = new System.Windows.Forms.TextBox();
            this.txtboxCCNumber = new System.Windows.Forms.TextBox();
            this.txtboxCCType = new System.Windows.Forms.TextBox();
            this.txtboxCCName = new System.Windows.Forms.TextBox();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblCVV = new System.Windows.Forms.Label();
            this.lblCCType = new System.Windows.Forms.Label();
            this.lblCCNumber = new System.Windows.Forms.Label();
            this.lblCardHolder = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDepositDue = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCCPayment
            // 
            this.lblCCPayment.AutoSize = true;
            this.lblCCPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCPayment.Location = new System.Drawing.Point(219, 83);
            this.lblCCPayment.Name = "lblCCPayment";
            this.lblCCPayment.Size = new System.Drawing.Size(267, 31);
            this.lblCCPayment.TabIndex = 1;
            this.lblCCPayment.Text = "Credit Card Payment";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtboxCVV);
            this.panel1.Controls.Add(this.txtboxExpiry);
            this.panel1.Controls.Add(this.txtboxCCNumber);
            this.panel1.Controls.Add(this.txtboxCCType);
            this.panel1.Controls.Add(this.txtboxCCName);
            this.panel1.Controls.Add(this.lblExpiryDate);
            this.panel1.Controls.Add(this.lblCVV);
            this.panel1.Controls.Add(this.lblCCType);
            this.panel1.Controls.Add(this.lblCCNumber);
            this.panel1.Controls.Add(this.lblCardHolder);
            this.panel1.Location = new System.Drawing.Point(25, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 315);
            this.panel1.TabIndex = 2;
            // 
            // txtboxCVV
            // 
            this.txtboxCVV.Location = new System.Drawing.Point(147, 155);
            this.txtboxCVV.Name = "txtboxCVV";
            this.txtboxCVV.Size = new System.Drawing.Size(100, 20);
            this.txtboxCVV.TabIndex = 13;
            // 
            // txtboxExpiry
            // 
            this.txtboxExpiry.Location = new System.Drawing.Point(147, 192);
            this.txtboxExpiry.Name = "txtboxExpiry";
            this.txtboxExpiry.Size = new System.Drawing.Size(100, 20);
            this.txtboxExpiry.TabIndex = 12;
            // 
            // txtboxCCNumber
            // 
            this.txtboxCCNumber.Location = new System.Drawing.Point(147, 81);
            this.txtboxCCNumber.Name = "txtboxCCNumber";
            this.txtboxCCNumber.Size = new System.Drawing.Size(100, 20);
            this.txtboxCCNumber.TabIndex = 11;
            // 
            // txtboxCCType
            // 
            this.txtboxCCType.Location = new System.Drawing.Point(147, 118);
            this.txtboxCCType.Name = "txtboxCCType";
            this.txtboxCCType.Size = new System.Drawing.Size(100, 20);
            this.txtboxCCType.TabIndex = 10;
            // 
            // txtboxCCName
            // 
            this.txtboxCCName.Location = new System.Drawing.Point(147, 44);
            this.txtboxCCName.Name = "txtboxCCName";
            this.txtboxCCName.Size = new System.Drawing.Size(100, 20);
            this.txtboxCCName.TabIndex = 9;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(17, 195);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(61, 13);
            this.lblExpiryDate.TabIndex = 8;
            this.lblExpiryDate.Text = "Expiry Date";
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Location = new System.Drawing.Point(17, 158);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(28, 13);
            this.lblCVV.TabIndex = 7;
            this.lblCVV.Text = "CVV";
            // 
            // lblCCType
            // 
            this.lblCCType.AutoSize = true;
            this.lblCCType.Location = new System.Drawing.Point(17, 121);
            this.lblCCType.Name = "lblCCType";
            this.lblCCType.Size = new System.Drawing.Size(86, 13);
            this.lblCCType.TabIndex = 6;
            this.lblCCType.Text = "Credit Card Type";
            // 
            // lblCCNumber
            // 
            this.lblCCNumber.AutoSize = true;
            this.lblCCNumber.Location = new System.Drawing.Point(17, 84);
            this.lblCCNumber.Name = "lblCCNumber";
            this.lblCCNumber.Size = new System.Drawing.Size(99, 13);
            this.lblCCNumber.TabIndex = 5;
            this.lblCCNumber.Text = "Credit Card Number";
            // 
            // lblCardHolder
            // 
            this.lblCardHolder.AutoSize = true;
            this.lblCardHolder.Location = new System.Drawing.Point(17, 47);
            this.lblCardHolder.Name = "lblCardHolder";
            this.lblCardHolder.Size = new System.Drawing.Size(124, 13);
            this.lblCardHolder.TabIndex = 4;
            this.lblCardHolder.Text = "Credit Card Name Holder";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDepositDue);
            this.panel2.Controls.Add(this.lblAmountDue);
            this.panel2.Location = new System.Drawing.Point(319, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 315);
            this.panel2.TabIndex = 3;
            // 
            // lblDepositDue
            // 
            this.lblDepositDue.AutoSize = true;
            this.lblDepositDue.Location = new System.Drawing.Point(15, 80);
            this.lblDepositDue.Name = "lblDepositDue";
            this.lblDepositDue.Size = new System.Drawing.Size(66, 13);
            this.lblDepositDue.TabIndex = 10;
            this.lblDepositDue.Text = "Deposit Due";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(15, 47);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(93, 13);
            this.lblAmountDue.TabIndex = 9;
            this.lblAmountDue.Text = "Total Amount Due";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Confirm Payment";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HomeScreen.Properties.Resources.Screenshot__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 114);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 527);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCCPayment);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PaymentDetails";
            this.Text = "PaymentDetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCCPayment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.Label lblCCType;
        private System.Windows.Forms.Label lblCCNumber;
        private System.Windows.Forms.Label lblCardHolder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDepositDue;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtboxCVV;
        private System.Windows.Forms.TextBox txtboxExpiry;
        private System.Windows.Forms.TextBox txtboxCCNumber;
        private System.Windows.Forms.TextBox txtboxCCType;
        private System.Windows.Forms.TextBox txtboxCCName;
    }
}