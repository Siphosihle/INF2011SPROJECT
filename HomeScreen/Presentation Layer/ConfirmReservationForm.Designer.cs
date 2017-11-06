namespace HomeScreen.Presentation_Layer
{
    partial class ConfirmReservationForm
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
            this.rtbReservationDetails = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHotelName = new System.Windows.Forms.Label();
            this.lbBookingDetails = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbReservationDetails
            // 
            this.rtbReservationDetails.Location = new System.Drawing.Point(372, 158);
            this.rtbReservationDetails.Name = "rtbReservationDetails";
            this.rtbReservationDetails.Size = new System.Drawing.Size(362, 198);
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
            // lblHotelName
            // 
            this.lblHotelName.AutoSize = true;
            this.lblHotelName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelName.ForeColor = System.Drawing.Color.HotPink;
            this.lblHotelName.Location = new System.Drawing.Point(369, 140);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(139, 15);
            this.lblHotelName.TabIndex = 47;
            this.lblHotelName.Text = "Reservation Information";
            // 
            // lbBookingDetails
            // 
            this.lbBookingDetails.AutoSize = true;
            this.lbBookingDetails.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookingDetails.ForeColor = System.Drawing.Color.HotPink;
            this.lbBookingDetails.Location = new System.Drawing.Point(366, 80);
            this.lbBookingDetails.Name = "lbBookingDetails";
            this.lbBookingDetails.Size = new System.Drawing.Size(368, 31);
            this.lbBookingDetails.TabIndex = 54;
            this.lbBookingDetails.Text = "RESERVATION COMPLETE";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.HotPink;
            this.btnPrevious.Location = new System.Drawing.Point(372, 423);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(176, 32);
            this.btnPrevious.TabIndex = 55;
            this.btnPrevious.Text = "Send Confirmation Email";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.HotPink;
            this.button1.Location = new System.Drawing.Point(372, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 32);
            this.button1.TabIndex = 56;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ConfirmReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lbBookingDetails);
            this.Controls.Add(this.lblHotelName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rtbReservationDetails);
            this.Name = "ConfirmReservationForm";
            this.Text = "ConfirmReservation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbReservationDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHotelName;
        private System.Windows.Forms.Label lbBookingDetails;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button button1;
    }
}