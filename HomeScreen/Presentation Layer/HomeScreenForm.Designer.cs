namespace HomeScreen.Presentation_Layer
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbBookingDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BackgroundImage = global::HomeScreen.Properties.Resources.Screenshot__1_;
            this.picBox.Location = new System.Drawing.Point(2, 2);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(184, 111);
            this.picBox.TabIndex = 26;
            this.picBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.HotPink;
            this.button1.Location = new System.Drawing.Point(383, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(394, 48);
            this.button1.TabIndex = 27;
            this.button1.Text = "Make a Booking";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.HotPink;
            this.button2.Location = new System.Drawing.Point(383, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(394, 48);
            this.button2.TabIndex = 28;
            this.button2.Text = "Upgdate Booking";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.HotPink;
            this.button3.Location = new System.Drawing.Point(383, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(394, 48);
            this.button3.TabIndex = 29;
            this.button3.Text = "Guest Booking Enquiry";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.HotPink;
            this.button4.Location = new System.Drawing.Point(383, 445);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(394, 48);
            this.button4.TabIndex = 30;
            this.button4.Text = "Cancel Booking";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lbBookingDetails
            // 
            this.lbBookingDetails.AutoSize = true;
            this.lbBookingDetails.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookingDetails.ForeColor = System.Drawing.Color.HotPink;
            this.lbBookingDetails.Location = new System.Drawing.Point(377, 82);
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
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picBox);
            this.Name = "HomeScreenForm";
            this.Text = "HomeScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbBookingDetails;
    }
}