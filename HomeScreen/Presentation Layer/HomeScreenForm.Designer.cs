namespace INF2011SProject.Presentation_Layer
{
    partial class HomeScreenForm
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
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnMakeaBooking = new System.Windows.Forms.Button();
            this.btnUpdateBooking = new System.Windows.Forms.Button();
            this.btnBookingEnquiry = new System.Windows.Forms.Button();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.lbBookingDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BackgroundImage = global::INF2011SProject.Properties.Resources.Screenshot__1_;
            this.picBox.Location = new System.Drawing.Point(2, 2);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(184, 111);
            this.picBox.TabIndex = 26;
            this.picBox.TabStop = false;
            // 
            // btnMakeaBooking
            // 
            this.btnMakeaBooking.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeaBooking.ForeColor = System.Drawing.Color.HotPink;
            this.btnMakeaBooking.Location = new System.Drawing.Point(350, 181);
            this.btnMakeaBooking.Name = "btnMakeaBooking";
            this.btnMakeaBooking.Size = new System.Drawing.Size(394, 48);
            this.btnMakeaBooking.TabIndex = 27;
            this.btnMakeaBooking.Text = "Make a Booking";
            this.btnMakeaBooking.UseVisualStyleBackColor = true;
            // 
            // btnUpdateBooking
            // 
            this.btnUpdateBooking.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBooking.ForeColor = System.Drawing.Color.HotPink;
            this.btnUpdateBooking.Location = new System.Drawing.Point(350, 269);
            this.btnUpdateBooking.Name = "btnUpdateBooking";
            this.btnUpdateBooking.Size = new System.Drawing.Size(394, 48);
            this.btnUpdateBooking.TabIndex = 28;
            this.btnUpdateBooking.Text = "Update Booking";
            this.btnUpdateBooking.UseVisualStyleBackColor = true;
            // 
            // btnBookingEnquiry
            // 
            this.btnBookingEnquiry.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingEnquiry.ForeColor = System.Drawing.Color.HotPink;
            this.btnBookingEnquiry.Location = new System.Drawing.Point(350, 355);
            this.btnBookingEnquiry.Name = "btnBookingEnquiry";
            this.btnBookingEnquiry.Size = new System.Drawing.Size(394, 48);
            this.btnBookingEnquiry.TabIndex = 29;
            this.btnBookingEnquiry.Text = "Guest Booking Enquiry";
            this.btnBookingEnquiry.UseVisualStyleBackColor = true;
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBooking.ForeColor = System.Drawing.Color.HotPink;
            this.btnCancelBooking.Location = new System.Drawing.Point(350, 445);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(394, 48);
            this.btnCancelBooking.TabIndex = 30;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = true;
            // 
            // lbBookingDetails
            // 
            this.lbBookingDetails.AutoSize = true;
            this.lbBookingDetails.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookingDetails.ForeColor = System.Drawing.Color.HotPink;
            this.lbBookingDetails.Location = new System.Drawing.Point(330, 82);
            this.lbBookingDetails.Name = "lbBookingDetails";
            this.lbBookingDetails.Size = new System.Drawing.Size(435, 31);
            this.lbBookingDetails.TabIndex = 31;
            this.lbBookingDetails.Text = "REST EASY BOOKING SYSTEMS";
            // 
            // HomeScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 586);
            this.Controls.Add(this.lbBookingDetails);
            this.Controls.Add(this.btnCancelBooking);
            this.Controls.Add(this.btnBookingEnquiry);
            this.Controls.Add(this.btnUpdateBooking);
            this.Controls.Add(this.btnMakeaBooking);
            this.Controls.Add(this.picBox);
            this.Name = "HomeScreenForm";
            this.Text = "HomeScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnMakeaBooking;
        private System.Windows.Forms.Button btnUpdateBooking;
        private System.Windows.Forms.Button btnBookingEnquiry;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.Label lbBookingDetails;
    }
}