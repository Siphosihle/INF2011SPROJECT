namespace HomeScreen
{
    partial class HomeScreen
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
            this.lblBookingDetails = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.lblNumberOfRoomss = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.cmbNumberOfGuests = new System.Windows.Forms.ComboBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.cmbNumberOfRooms = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookingDetails
            // 
            this.lblBookingDetails.AutoSize = true;
            this.lblBookingDetails.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDetails.ForeColor = System.Drawing.Color.HotPink;
            this.lblBookingDetails.Location = new System.Drawing.Point(390, 81);
            this.lblBookingDetails.Name = "lblBookingDetails";
            this.lblBookingDetails.Size = new System.Drawing.Size(269, 31);
            this.lblBookingDetails.TabIndex = 0;
            this.lblBookingDetails.Text = "BOOKING DETAILS";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.CalendarForeColor = System.Drawing.Color.Salmon;
            this.dtpCheckIn.CalendarMonthBackground = System.Drawing.Color.LightCoral;
            this.dtpCheckIn.CalendarTitleBackColor = System.Drawing.Color.LightCoral;
            this.dtpCheckIn.CalendarTitleForeColor = System.Drawing.Color.LightCoral;
            this.dtpCheckIn.CalendarTrailingForeColor = System.Drawing.Color.Salmon;
            this.dtpCheckIn.Location = new System.Drawing.Point(491, 210);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckIn.TabIndex = 7;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(491, 269);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckOut.TabIndex = 8;
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckInDate.ForeColor = System.Drawing.Color.HotPink;
            this.lblCheckInDate.Location = new System.Drawing.Point(393, 215);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(86, 15);
            this.lblCheckInDate.TabIndex = 15;
            this.lblCheckInDate.Text = "Check-In Date";
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOutDate.ForeColor = System.Drawing.Color.HotPink;
            this.lblCheckOutDate.Location = new System.Drawing.Point(389, 274);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(96, 15);
            this.lblCheckOutDate.TabIndex = 16;
            this.lblCheckOutDate.Text = "Check-Out Date";
            // 
            // lblNumberOfRoomss
            // 
            this.lblNumberOfRoomss.AutoSize = true;
            this.lblNumberOfRoomss.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRoomss.ForeColor = System.Drawing.Color.HotPink;
            this.lblNumberOfRoomss.Location = new System.Drawing.Point(378, 394);
            this.lblNumberOfRoomss.Name = "lblNumberOfRoomss";
            this.lblNumberOfRoomss.Size = new System.Drawing.Size(105, 15);
            this.lblNumberOfRoomss.TabIndex = 20;
            this.lblNumberOfRoomss.Text = "Number of Guests";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1102, -3);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 463);
            this.vScrollBar1.TabIndex = 22;
            // 
            // cmbNumberOfGuests
            // 
            this.cmbNumberOfGuests.AllowDrop = true;
            this.cmbNumberOfGuests.AutoCompleteCustomSource.AddRange(new string[] {
            "hshshs",
            "1"});
            this.cmbNumberOfGuests.BackColor = System.Drawing.SystemColors.Window;
            this.cmbNumberOfGuests.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumberOfGuests.FormattingEnabled = true;
            this.cmbNumberOfGuests.Items.AddRange(new object[] {
            "\"hshs\"",
            "2",
            "3",
            "4"});
            this.cmbNumberOfGuests.Location = new System.Drawing.Point(491, 388);
            this.cmbNumberOfGuests.Name = "cmbNumberOfGuests";
            this.cmbNumberOfGuests.Size = new System.Drawing.Size(200, 21);
            this.cmbNumberOfGuests.TabIndex = 23;
            this.cmbNumberOfGuests.SelectedIndexChanged += new System.EventHandler(this.cmbNumberOfGuests_SelectedIndexChanged);
            // 
            // picBox
            // 
            this.picBox.BackgroundImage = global::HomeScreen.Properties.Resources.Screenshot__1_;
            this.picBox.Location = new System.Drawing.Point(0, 1);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(184, 111);
            this.picBox.TabIndex = 25;
            this.picBox.TabStop = false;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.HotPink;
            this.btnCheck.Location = new System.Drawing.Point(463, 522);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(123, 48);
            this.btnCheck.TabIndex = 26;
            this.btnCheck.Text = "Check Booking";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // cmbNumberOfRooms
            // 
            this.cmbNumberOfRooms.FormattingEnabled = true;
            this.cmbNumberOfRooms.Items.AddRange(new object[] {
            "a"});
            this.cmbNumberOfRooms.Location = new System.Drawing.Point(491, 326);
            this.cmbNumberOfRooms.Name = "cmbNumberOfRooms";
            this.cmbNumberOfRooms.Size = new System.Drawing.Size(200, 21);
            this.cmbNumberOfRooms.TabIndex = 27;
            this.cmbNumberOfRooms.SelectedIndexChanged += new System.EventHandler(this.cmbNumberofRooms_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.HotPink;
            this.label1.Location = new System.Drawing.Point(379, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Number of Rooms";
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1048, 627);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNumberOfRooms);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.cmbNumberOfGuests);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.lblNumberOfRoomss);
            this.Controls.Add(this.lblCheckOutDate);
            this.Controls.Add(this.lblCheckInDate);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.lblBookingDetails);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.LightCoral;
            this.Name = "HomeScreen";
            this.Text = "Rest Easy Hotel ";
            this.TransparencyKey = System.Drawing.Color.Silver;
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookingDetails;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.Label lblNumberOfRoomss;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ComboBox cmbNumberOfGuests;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ComboBox cmbNumberOfRooms;
        private System.Windows.Forms.Label label1;
    }
}

