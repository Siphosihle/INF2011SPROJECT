namespace HomeScreen.Presentation_Layer
{
    partial class ConfirmReservation
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
            this.lblReservationComplete = new System.Windows.Forms.Label();
            this.lblReservation = new System.Windows.Forms.Label();
            this.rtbReservationDetails = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReservationComplete
            // 
            this.lblReservationComplete.AutoSize = true;
            this.lblReservationComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationComplete.Location = new System.Drawing.Point(351, 95);
            this.lblReservationComplete.Name = "lblReservationComplete";
            this.lblReservationComplete.Size = new System.Drawing.Size(283, 31);
            this.lblReservationComplete.TabIndex = 0;
            this.lblReservationComplete.Text = "Reservation Complete";
            // 
            // lblReservation
            // 
            this.lblReservation.AutoSize = true;
            this.lblReservation.Location = new System.Drawing.Point(369, 142);
            this.lblReservation.Name = "lblReservation";
            this.lblReservation.Size = new System.Drawing.Size(82, 13);
            this.lblReservation.TabIndex = 1;
            this.lblReservation.Text = "Reservation for ";
            // 
            // rtbReservationDetails
            // 
            this.rtbReservationDetails.Location = new System.Drawing.Point(372, 158);
            this.rtbReservationDetails.Name = "rtbReservationDetails";
            this.rtbReservationDetails.Size = new System.Drawing.Size(243, 163);
            this.rtbReservationDetails.TabIndex = 2;
            this.rtbReservationDetails.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HomeScreen.Properties.Resources.Screenshot__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 111);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(417, 340);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(150, 23);
            this.btnSendEmail.TabIndex = 4;
            this.btnSendEmail.Text = "Send Confirmation Email";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(455, 379);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // ConfirmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rtbReservationDetails);
            this.Controls.Add(this.lblReservation);
            this.Controls.Add(this.lblReservationComplete);
            this.Name = "ConfirmReservation";
            this.Text = "ConfirmReservation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReservationComplete;
        private System.Windows.Forms.Label lblReservation;
        private System.Windows.Forms.RichTextBox rtbReservationDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnHome;
    }
}