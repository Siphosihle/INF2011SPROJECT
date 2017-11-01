namespace INF2011SProject.Presentation_Layer
{
    partial class PaymentForm
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
            this.lblPaymentDetails = new System.Windows.Forms.Label();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.lblGuestProfile = new System.Windows.Forms.Label();
            this.lblPaymentSummary = new System.Windows.Forms.Label();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDepositDue = new System.Windows.Forms.Label();
            this.lblReferenceNumber = new System.Windows.Forms.Label();
            this.lblTotalDue = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPaymentDetails
            // 
            this.lblPaymentDetails.AutoSize = true;
            this.lblPaymentDetails.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDetails.ForeColor = System.Drawing.Color.HotPink;
            this.lblPaymentDetails.Location = new System.Drawing.Point(406, 81);
            this.lblPaymentDetails.Name = "lblPaymentDetails";
            this.lblPaymentDetails.Size = new System.Drawing.Size(270, 31);
            this.lblPaymentDetails.TabIndex = 28;
            this.lblPaymentDetails.Text = "PAYMENT DETAILS";
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Location = new System.Drawing.Point(452, 218);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(183, 21);
            this.cmbPaymentType.TabIndex = 29;
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.ForeColor = System.Drawing.Color.HotPink;
            this.lblPaymentType.Location = new System.Drawing.Point(354, 224);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(82, 15);
            this.lblPaymentType.TabIndex = 30;
            this.lblPaymentType.Text = "Payment Type";
            this.lblPaymentType.Click += new System.EventHandler(this.label2_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(721, 218);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(242, 234);
            this.treeView1.TabIndex = 31;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(1, 214);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(242, 234);
            this.treeView2.TabIndex = 32;
            // 
            // lblGuestProfile
            // 
            this.lblGuestProfile.AutoSize = true;
            this.lblGuestProfile.Location = new System.Drawing.Point(814, 221);
            this.lblGuestProfile.Name = "lblGuestProfile";
            this.lblGuestProfile.Size = new System.Drawing.Size(67, 13);
            this.lblGuestProfile.TabIndex = 33;
            this.lblGuestProfile.Text = "Guest Profile";
            this.lblGuestProfile.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPaymentSummary
            // 
            this.lblPaymentSummary.AutoSize = true;
            this.lblPaymentSummary.Location = new System.Drawing.Point(62, 218);
            this.lblPaymentSummary.Name = "lblPaymentSummary";
            this.lblPaymentSummary.Size = new System.Drawing.Size(83, 13);
            this.lblPaymentSummary.TabIndex = 34;
            this.lblPaymentSummary.Text = "Payment Details";
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Location = new System.Drawing.Point(727, 399);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(84, 13);
            this.lblCheckOutDate.TabIndex = 35;
            this.lblCheckOutDate.Text = "Check-Out Date";
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Location = new System.Drawing.Point(727, 362);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(76, 13);
            this.lblCheckInDate.TabIndex = 36;
            this.lblCheckInDate.Text = "Check-In Date";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(727, 324);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 37;
            this.lblID.Text = "ID";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(727, 289);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 38;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(727, 257);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 39;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblDepositDue
            // 
            this.lblDepositDue.AutoSize = true;
            this.lblDepositDue.Location = new System.Drawing.Point(12, 387);
            this.lblDepositDue.Name = "lblDepositDue";
            this.lblDepositDue.Size = new System.Drawing.Size(66, 13);
            this.lblDepositDue.TabIndex = 40;
            this.lblDepositDue.Text = "Deposit Due";
            // 
            // lblReferenceNumber
            // 
            this.lblReferenceNumber.AutoSize = true;
            this.lblReferenceNumber.Location = new System.Drawing.Point(12, 324);
            this.lblReferenceNumber.Name = "lblReferenceNumber";
            this.lblReferenceNumber.Size = new System.Drawing.Size(141, 13);
            this.lblReferenceNumber.TabIndex = 41;
            this.lblReferenceNumber.Text = "Payment Reference Number";
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.AutoSize = true;
            this.lblTotalDue.Location = new System.Drawing.Point(12, 257);
            this.lblTotalDue.Name = "lblTotalDue";
            this.lblTotalDue.Size = new System.Drawing.Size(91, 13);
            this.lblTotalDue.TabIndex = 42;
            this.lblTotalDue.Text = "Total Amount due";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(206, 257);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = ".";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(206, 387);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = ".";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(206, 324);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = ".";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(871, 257);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(10, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = ".";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(871, 399);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(10, 13);
            this.label17.TabIndex = 47;
            this.label17.Text = ".";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(871, 362);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(10, 13);
            this.label18.TabIndex = 48;
            this.label18.Text = ".";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(871, 324);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(10, 13);
            this.label19.TabIndex = 49;
            this.label19.Text = ".";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(871, 289);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(10, 13);
            this.label20.TabIndex = 50;
            this.label20.Text = ".";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.HotPink;
            this.button1.Location = new System.Drawing.Point(465, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 48);
            this.button1.TabIndex = 51;
            this.button1.Text = "Make Payment";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.HotPink;
            this.button2.Location = new System.Drawing.Point(49, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 48);
            this.button2.TabIndex = 52;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // picBox
            // 
            this.picBox.Image = global::HomeScreen.Properties.Resources.Screenshot__1_;
            this.picBox.Location = new System.Drawing.Point(1, 1);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(184, 111);
            this.picBox.TabIndex = 27;
            this.picBox.TabStop = false;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblTotalDue);
            this.Controls.Add(this.lblReferenceNumber);
            this.Controls.Add(this.lblDepositDue);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblCheckInDate);
            this.Controls.Add(this.lblCheckOutDate);
            this.Controls.Add(this.lblPaymentSummary);
            this.Controls.Add(this.lblGuestProfile);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.lblPaymentType);
            this.Controls.Add(this.cmbPaymentType);
            this.Controls.Add(this.lblPaymentDetails);
            this.Controls.Add(this.picBox);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lblPaymentDetails;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Label lblGuestProfile;
        private System.Windows.Forms.Label lblPaymentSummary;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDepositDue;
        private System.Windows.Forms.Label lblReferenceNumber;
        private System.Windows.Forms.Label lblTotalDue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}