﻿namespace HomeScreen.Presentation_Layer
{
    partial class BookingDetailsForm
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
            this.lbBookingDetails = new System.Windows.Forms.Label();
            this.dtpCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.cmbNumberOfGuests = new System.Windows.Forms.ComboBox();
            this.cmbNumberOfRooms = new System.Windows.Forms.ComboBox();
            this.lbCheckInDate = new System.Windows.Forms.Label();
            this.lbCheckOutDate = new System.Windows.Forms.Label();
            this.lbNumberOfRooms = new System.Windows.Forms.Label();
            this.lbNumberOfGuests = new System.Windows.Forms.Label();
            this.btnCheckBooking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BackgroundImage = global::HomeScreen.Properties.Resources.Screenshot__1_;
            this.picBox.Location = new System.Drawing.Point(1, 2);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(184, 111);
            this.picBox.TabIndex = 27;
            this.picBox.TabStop = false;
            // 
            // lbBookingDetails
            // 
            this.lbBookingDetails.AutoSize = true;
            this.lbBookingDetails.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookingDetails.ForeColor = System.Drawing.Color.HotPink;
            this.lbBookingDetails.Location = new System.Drawing.Point(380, 82);
            this.lbBookingDetails.Name = "lbBookingDetails";
            this.lbBookingDetails.Size = new System.Drawing.Size(269, 31);
            this.lbBookingDetails.TabIndex = 32;
            this.lbBookingDetails.Text = "BOOKING DETAILS";
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.Location = new System.Drawing.Point(449, 165);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckInDate.TabIndex = 33;
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Location = new System.Drawing.Point(449, 231);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckOutDate.TabIndex = 34;
            // 
            // cmbNumberOfGuests
            // 
            this.cmbNumberOfGuests.FormattingEnabled = true;
            this.cmbNumberOfGuests.Location = new System.Drawing.Point(449, 352);
            this.cmbNumberOfGuests.Name = "cmbNumberOfGuests";
            this.cmbNumberOfGuests.Size = new System.Drawing.Size(200, 21);
            this.cmbNumberOfGuests.TabIndex = 35;
            this.cmbNumberOfGuests.SelectedIndexChanged += new System.EventHandler(this.cmbNumberOfGuests_SelectedIndexChanged);
            // 
            // cmbNumberOfRooms
            // 
            this.cmbNumberOfRooms.FormattingEnabled = true;
            this.cmbNumberOfRooms.Location = new System.Drawing.Point(449, 292);
            this.cmbNumberOfRooms.Name = "cmbNumberOfRooms";
            this.cmbNumberOfRooms.Size = new System.Drawing.Size(200, 21);
            this.cmbNumberOfRooms.TabIndex = 36;
            this.cmbNumberOfRooms.SelectedIndexChanged += new System.EventHandler(this.cmbNumberOfRooms_SelectedIndexChanged);
            // 
            // lbCheckInDate
            // 
            this.lbCheckInDate.AutoSize = true;
            this.lbCheckInDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckInDate.ForeColor = System.Drawing.Color.HotPink;
            this.lbCheckInDate.Location = new System.Drawing.Point(354, 170);
            this.lbCheckInDate.Name = "lbCheckInDate";
            this.lbCheckInDate.Size = new System.Drawing.Size(86, 15);
            this.lbCheckInDate.TabIndex = 37;
            this.lbCheckInDate.Text = "Check-In Date";
            // 
            // lbCheckOutDate
            // 
            this.lbCheckOutDate.AutoSize = true;
            this.lbCheckOutDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckOutDate.ForeColor = System.Drawing.Color.HotPink;
            this.lbCheckOutDate.Location = new System.Drawing.Point(344, 236);
            this.lbCheckOutDate.Name = "lbCheckOutDate";
            this.lbCheckOutDate.Size = new System.Drawing.Size(96, 15);
            this.lbCheckOutDate.TabIndex = 38;
            this.lbCheckOutDate.Text = "Check-Out Date";
            // 
            // lbNumberOfRooms
            // 
            this.lbNumberOfRooms.AutoSize = true;
            this.lbNumberOfRooms.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfRooms.ForeColor = System.Drawing.Color.HotPink;
            this.lbNumberOfRooms.Location = new System.Drawing.Point(336, 298);
            this.lbNumberOfRooms.Name = "lbNumberOfRooms";
            this.lbNumberOfRooms.Size = new System.Drawing.Size(104, 15);
            this.lbNumberOfRooms.TabIndex = 39;
            this.lbNumberOfRooms.Text = "Number of Rooms";
            // 
            // lbNumberOfGuests
            // 
            this.lbNumberOfGuests.AutoSize = true;
            this.lbNumberOfGuests.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfGuests.ForeColor = System.Drawing.Color.HotPink;
            this.lbNumberOfGuests.Location = new System.Drawing.Point(335, 358);
            this.lbNumberOfGuests.Name = "lbNumberOfGuests";
            this.lbNumberOfGuests.Size = new System.Drawing.Size(105, 15);
            this.lbNumberOfGuests.TabIndex = 40;
            this.lbNumberOfGuests.Text = "Number of Guests";
            // 
            // btnCheckBooking
            // 
            this.btnCheckBooking.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBooking.ForeColor = System.Drawing.Color.HotPink;
            this.btnCheckBooking.Location = new System.Drawing.Point(489, 488);
            this.btnCheckBooking.Name = "btnCheckBooking";
            this.btnCheckBooking.Size = new System.Drawing.Size(123, 48);
            this.btnCheckBooking.TabIndex = 41;
            this.btnCheckBooking.Text = "Check Booking";
            this.btnCheckBooking.UseVisualStyleBackColor = true;
            this.btnCheckBooking.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // BookingDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 575);
            this.Controls.Add(this.btnCheckBooking);
            this.Controls.Add(this.lbNumberOfGuests);
            this.Controls.Add(this.lbNumberOfRooms);
            this.Controls.Add(this.lbCheckOutDate);
            this.Controls.Add(this.lbCheckInDate);
            this.Controls.Add(this.cmbNumberOfRooms);
            this.Controls.Add(this.cmbNumberOfGuests);
            this.Controls.Add(this.dtpCheckOutDate);
            this.Controls.Add(this.dtpCheckInDate);
            this.Controls.Add(this.lbBookingDetails);
            this.Controls.Add(this.picBox);
            this.Name = "BookingDetailsForm";
            this.Text = "BookingDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lbBookingDetails;
        private System.Windows.Forms.DateTimePicker dtpCheckInDate;
        private System.Windows.Forms.DateTimePicker dtpCheckOutDate;
        private System.Windows.Forms.ComboBox cmbNumberOfGuests;
        private System.Windows.Forms.ComboBox cmbNumberOfRooms;
        private System.Windows.Forms.Label lbCheckInDate;
        private System.Windows.Forms.Label lbCheckOutDate;
        private System.Windows.Forms.Label lbNumberOfRooms;
        private System.Windows.Forms.Label lbNumberOfGuests;
        private System.Windows.Forms.Button btnCheckBooking;
    }
}