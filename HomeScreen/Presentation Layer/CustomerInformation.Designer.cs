namespace HomeScreen
{
    partial class CustomerInformation
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
            this.lblGuestDetails = new System.Windows.Forms.Label();
            this.txtboxFirstName = new System.Windows.Forms.TextBox();
            this.txtboxLastName = new System.Windows.Forms.TextBox();
            this.txtboxID = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnCheckStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGuestDetails
            // 
            this.lblGuestDetails.AutoSize = true;
            this.lblGuestDetails.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestDetails.ForeColor = System.Drawing.Color.HotPink;
            this.lblGuestDetails.Location = new System.Drawing.Point(356, 81);
            this.lblGuestDetails.Name = "lblGuestDetails";
            this.lblGuestDetails.Size = new System.Drawing.Size(229, 31);
            this.lblGuestDetails.TabIndex = 1;
            this.lblGuestDetails.Text = "GUEST DETAILS";
            this.lblGuestDetails.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtboxFirstName
            // 
            this.txtboxFirstName.Location = new System.Drawing.Point(423, 175);
            this.txtboxFirstName.Name = "txtboxFirstName";
            this.txtboxFirstName.Size = new System.Drawing.Size(162, 22);
            this.txtboxFirstName.TabIndex = 2;
            // 
            // txtboxLastName
            // 
            this.txtboxLastName.Location = new System.Drawing.Point(423, 236);
            this.txtboxLastName.Name = "txtboxLastName";
            this.txtboxLastName.Size = new System.Drawing.Size(162, 22);
            this.txtboxLastName.TabIndex = 3;
            // 
            // txtboxID
            // 
            this.txtboxID.Location = new System.Drawing.Point(423, 296);
            this.txtboxID.Name = "txtboxID";
            this.txtboxID.Size = new System.Drawing.Size(162, 22);
            this.txtboxID.TabIndex = 4;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.HotPink;
            this.lblFirstName.Location = new System.Drawing.Point(340, 182);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(68, 15);
            this.lblFirstName.TabIndex = 16;
            this.lblFirstName.Text = "First Name";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.ForeColor = System.Drawing.Color.HotPink;
            this.lbLastName.Location = new System.Drawing.Point(343, 243);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(65, 15);
            this.lbLastName.TabIndex = 17;
            this.lbLastName.Text = "Last Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.HotPink;
            this.lblID.Location = new System.Drawing.Point(388, 303);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 15);
            this.lblID.TabIndex = 18;
            this.lblID.Text = "ID";
            this.lblID.Click += new System.EventHandler(this.label3_Click);
            // 
            // picBox
            // 
            this.picBox.BackgroundImage = global::HomeScreen.Properties.Resources.Screenshot__1_;
            this.picBox.Location = new System.Drawing.Point(0, 1);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(184, 111);
            this.picBox.TabIndex = 26;
            this.picBox.TabStop = false;
            // 
            // btnCheckStatus
            // 
            this.btnCheckStatus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckStatus.ForeColor = System.Drawing.Color.HotPink;
            this.btnCheckStatus.Location = new System.Drawing.Point(437, 377);
            this.btnCheckStatus.Name = "btnCheckStatus";
            this.btnCheckStatus.Size = new System.Drawing.Size(123, 48);
            this.btnCheckStatus.TabIndex = 27;
            this.btnCheckStatus.Text = "Check Status";
            this.btnCheckStatus.UseVisualStyleBackColor = true;
            this.btnCheckStatus.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.btnCheckStatus);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtboxID);
            this.Controls.Add(this.txtboxLastName);
            this.Controls.Add(this.txtboxFirstName);
            this.Controls.Add(this.lblGuestDetails);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CustomerInformation";
            this.Text = "Rest Easy Hotel";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuestDetails;
        private System.Windows.Forms.TextBox txtboxFirstName;
        private System.Windows.Forms.TextBox txtboxLastName;
        private System.Windows.Forms.TextBox txtboxID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnCheckStatus;
    }
}