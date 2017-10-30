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
            this.lbBookingDetails = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lbCheckInDate = new System.Windows.Forms.Label();
            this.lbCheckOutDate = new System.Windows.Forms.Label();
            this.lbNumberOfGuests = new System.Windows.Forms.Label();
            this.lbSpecialRequirements = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.cbNumberOfGuests = new System.Windows.Forms.ComboBox();
            this.cbSpecialRequirements = new System.Windows.Forms.ComboBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBookingDetails
            // 
            this.lbBookingDetails.AutoSize = true;
            this.lbBookingDetails.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookingDetails.ForeColor = System.Drawing.Color.HotPink;
            this.lbBookingDetails.Location = new System.Drawing.Point(491, 81);
            this.lbBookingDetails.Name = "lbBookingDetails";
            this.lbBookingDetails.Size = new System.Drawing.Size(269, 31);
            this.lbBookingDetails.TabIndex = 0;
            this.lbBookingDetails.Text = "BOOKING DETAILS";
            this.lbBookingDetails.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.CalendarForeColor = System.Drawing.Color.Salmon;
            this.dtpCheckIn.CalendarMonthBackground = System.Drawing.Color.LightCoral;
            this.dtpCheckIn.CalendarTitleBackColor = System.Drawing.Color.LightCoral;
            this.dtpCheckIn.CalendarTitleForeColor = System.Drawing.Color.LightCoral;
            this.dtpCheckIn.CalendarTrailingForeColor = System.Drawing.Color.Salmon;
            this.dtpCheckIn.Location = new System.Drawing.Point(560, 214);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckIn.TabIndex = 7;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(560, 272);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckOut.TabIndex = 8;
            this.dtpCheckOut.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // lbCheckInDate
            // 
            this.lbCheckInDate.AutoSize = true;
            this.lbCheckInDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckInDate.ForeColor = System.Drawing.Color.HotPink;
            this.lbCheckInDate.Location = new System.Drawing.Point(468, 219);
            this.lbCheckInDate.Name = "lbCheckInDate";
            this.lbCheckInDate.Size = new System.Drawing.Size(86, 15);
            this.lbCheckInDate.TabIndex = 15;
            this.lbCheckInDate.Text = "Check-In Date";
            // 
            // lbCheckOutDate
            // 
            this.lbCheckOutDate.AutoSize = true;
            this.lbCheckOutDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckOutDate.ForeColor = System.Drawing.Color.HotPink;
            this.lbCheckOutDate.Location = new System.Drawing.Point(458, 277);
            this.lbCheckOutDate.Name = "lbCheckOutDate";
            this.lbCheckOutDate.Size = new System.Drawing.Size(96, 15);
            this.lbCheckOutDate.TabIndex = 16;
            this.lbCheckOutDate.Text = "Check-Out Date";
            this.lbCheckOutDate.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbNumberOfGuests
            // 
            this.lbNumberOfGuests.AutoSize = true;
            this.lbNumberOfGuests.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfGuests.ForeColor = System.Drawing.Color.HotPink;
            this.lbNumberOfGuests.Location = new System.Drawing.Point(449, 334);
            this.lbNumberOfGuests.Name = "lbNumberOfGuests";
            this.lbNumberOfGuests.Size = new System.Drawing.Size(105, 15);
            this.lbNumberOfGuests.TabIndex = 20;
            this.lbNumberOfGuests.Text = "Number of Guests";
            // 
            // lbSpecialRequirements
            // 
            this.lbSpecialRequirements.AutoSize = true;
            this.lbSpecialRequirements.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpecialRequirements.ForeColor = System.Drawing.Color.HotPink;
            this.lbSpecialRequirements.Location = new System.Drawing.Point(427, 386);
            this.lbSpecialRequirements.Name = "lbSpecialRequirements";
            this.lbSpecialRequirements.Size = new System.Drawing.Size(127, 15);
            this.lbSpecialRequirements.TabIndex = 21;
            this.lbSpecialRequirements.Text = "Special Requirements";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1102, -3);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 463);
            this.vScrollBar1.TabIndex = 22;
            // 
            // cbNumberOfGuests
            // 
            this.cbNumberOfGuests.FormattingEnabled = true;
            this.cbNumberOfGuests.Location = new System.Drawing.Point(560, 328);
            this.cbNumberOfGuests.Name = "cbNumberOfGuests";
            this.cbNumberOfGuests.Size = new System.Drawing.Size(200, 21);
            this.cbNumberOfGuests.TabIndex = 23;
            this.cbNumberOfGuests.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbSpecialRequirements
            // 
            this.cbSpecialRequirements.FormattingEnabled = true;
            this.cbSpecialRequirements.Location = new System.Drawing.Point(560, 380);
            this.cbSpecialRequirements.Name = "cbSpecialRequirements";
            this.cbSpecialRequirements.Size = new System.Drawing.Size(200, 21);
            this.cbSpecialRequirements.TabIndex = 24;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.HotPink;
            this.button1.Location = new System.Drawing.Point(595, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 48);
            this.button1.TabIndex = 26;
            this.button1.Text = "Check Booking";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1048, 627);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.cbSpecialRequirements);
            this.Controls.Add(this.cbNumberOfGuests);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.lbSpecialRequirements);
            this.Controls.Add(this.lbNumberOfGuests);
            this.Controls.Add(this.lbCheckOutDate);
            this.Controls.Add(this.lbCheckInDate);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.lbBookingDetails);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.LightCoral;
            this.Name = "HomeScreen";
            this.Text = "Rest Easy Hotel ";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBookingDetails;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label lbCheckInDate;
        private System.Windows.Forms.Label lbCheckOutDate;
        private System.Windows.Forms.Label lbNumberOfGuests;
        private System.Windows.Forms.Label lbSpecialRequirements;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ComboBox cbNumberOfGuests;
        private System.Windows.Forms.ComboBox cbSpecialRequirements;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button button1;
    }
}

