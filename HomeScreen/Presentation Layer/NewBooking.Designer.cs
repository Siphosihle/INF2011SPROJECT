namespace HomeScreen.Presentation_Layer
{
    partial class NewBooking
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbBookingDetails = new System.Windows.Forms.Label();
            this.rtbReservationDetails = new System.Windows.Forms.RichTextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnProceed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HomeScreen.Properties.Resources.Screenshot__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 111);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbBookingDetails
            // 
            this.lbBookingDetails.AutoSize = true;
            this.lbBookingDetails.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookingDetails.ForeColor = System.Drawing.Color.HotPink;
            this.lbBookingDetails.Location = new System.Drawing.Point(229, 92);
            this.lbBookingDetails.Name = "lbBookingDetails";
            this.lbBookingDetails.Size = new System.Drawing.Size(304, 31);
            this.lbBookingDetails.TabIndex = 55;
            this.lbBookingDetails.Text = "Reservation Information";
            // 
            // rtbReservationDetails
            // 
            this.rtbReservationDetails.Location = new System.Drawing.Point(234, 158);
            this.rtbReservationDetails.Name = "rtbReservationDetails";
            this.rtbReservationDetails.Size = new System.Drawing.Size(362, 198);
            this.rtbReservationDetails.TabIndex = 56;
            this.rtbReservationDetails.Text = "";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.HotPink;
            this.btnHome.Location = new System.Drawing.Point(234, 402);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(162, 32);
            this.btnHome.TabIndex = 58;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.Color.HotPink;
            this.btnProceed.Location = new System.Drawing.Point(434, 402);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(162, 32);
            this.btnProceed.TabIndex = 59;
            this.btnProceed.Text = "Proceed with Booking";
            this.btnProceed.UseVisualStyleBackColor = true;
            // 
            // NewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 547);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.rtbReservationDetails);
            this.Controls.Add(this.lbBookingDetails);
            this.Controls.Add(this.pictureBox1);
            this.Name = "NewBooking";
            this.Text = "NewBooking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbBookingDetails;
        private System.Windows.Forms.RichTextBox rtbReservationDetails;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnProceed;
    }
}