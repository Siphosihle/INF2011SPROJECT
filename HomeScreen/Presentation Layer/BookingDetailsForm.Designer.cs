namespace HomeScreen.Presentation_Layer
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
            this.lbCheckInDate = new System.Windows.Forms.Label();
            this.lbCheckOutDate = new System.Windows.Forms.Label();
            this.lbNumberOfGuests = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbNoOfGuests = new System.Windows.Forms.ComboBox();
            this.lblHotelName = new System.Windows.Forms.Label();
            this.cmbHotelName = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.lbBookingDetails.Location = new System.Drawing.Point(422, 82);
            this.lbBookingDetails.Name = "lbBookingDetails";
            this.lbBookingDetails.Size = new System.Drawing.Size(269, 31);
            this.lbBookingDetails.TabIndex = 32;
            this.lbBookingDetails.Text = "BOOKING DETAILS";
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.Location = new System.Drawing.Point(510, 214);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckInDate.TabIndex = 33;
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Location = new System.Drawing.Point(510, 268);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckOutDate.TabIndex = 34;
            // 
            // lbCheckInDate
            // 
            this.lbCheckInDate.AutoSize = true;
            this.lbCheckInDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckInDate.ForeColor = System.Drawing.Color.HotPink;
            this.lbCheckInDate.Location = new System.Drawing.Point(418, 219);
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
            this.lbCheckOutDate.Location = new System.Drawing.Point(408, 273);
            this.lbCheckOutDate.Name = "lbCheckOutDate";
            this.lbCheckOutDate.Size = new System.Drawing.Size(96, 15);
            this.lbCheckOutDate.TabIndex = 38;
            this.lbCheckOutDate.Text = "Check-Out Date";
            // 
            // lbNumberOfGuests
            // 
            this.lbNumberOfGuests.AutoSize = true;
            this.lbNumberOfGuests.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfGuests.ForeColor = System.Drawing.Color.HotPink;
            this.lbNumberOfGuests.Location = new System.Drawing.Point(399, 327);
            this.lbNumberOfGuests.Name = "lbNumberOfGuests";
            this.lbNumberOfGuests.Size = new System.Drawing.Size(105, 15);
            this.lbNumberOfGuests.TabIndex = 40;
            this.lbNumberOfGuests.Text = "Number of Guests";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.HotPink;
            this.btnSubmit.Location = new System.Drawing.Point(545, 438);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(123, 48);
            this.btnSubmit.TabIndex = 42;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbNoOfGuests
            // 
            this.cmbNoOfGuests.FormattingEnabled = true;
            this.cmbNoOfGuests.Location = new System.Drawing.Point(510, 325);
            this.cmbNoOfGuests.Name = "cmbNoOfGuests";
            this.cmbNoOfGuests.Size = new System.Drawing.Size(200, 21);
            this.cmbNoOfGuests.TabIndex = 44;
            // 
            // lblHotelName
            // 
            this.lblHotelName.AutoSize = true;
            this.lblHotelName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelName.ForeColor = System.Drawing.Color.HotPink;
            this.lblHotelName.Location = new System.Drawing.Point(458, 169);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(36, 15);
            this.lblHotelName.TabIndex = 45;
            this.lblHotelName.Text = "Hotel";
            // 
            // cmbHotelName
            // 
            this.cmbHotelName.FormattingEnabled = true;
            this.cmbHotelName.Items.AddRange(new object[] {
            "RestEasy Cape Town CBD"});
            this.cmbHotelName.Location = new System.Drawing.Point(510, 163);
            this.cmbHotelName.Name = "cmbHotelName";
            this.cmbHotelName.Size = new System.Drawing.Size(200, 21);
            this.cmbHotelName.TabIndex = 46;
            this.cmbHotelName.SelectedIndexChanged += new System.EventHandler(this.cmbHotelName_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(722, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(378, 550);
            this.listBox1.TabIndex = 47;
            // 
            // BookingDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 575);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmbHotelName);
            this.Controls.Add(this.lblHotelName);
            this.Controls.Add(this.cmbNoOfGuests);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbNumberOfGuests);
            this.Controls.Add(this.lbCheckOutDate);
            this.Controls.Add(this.lbCheckInDate);
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
        private System.Windows.Forms.Label lbCheckInDate;
        private System.Windows.Forms.Label lbCheckOutDate;
        private System.Windows.Forms.Label lbNumberOfGuests;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbNoOfGuests;
        private System.Windows.Forms.Label lblHotelName;
        private System.Windows.Forms.ComboBox cmbHotelName;
        private System.Windows.Forms.ListBox listBox1;
    }
}