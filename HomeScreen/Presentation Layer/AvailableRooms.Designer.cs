namespace HomeScreen.Presentation_Layer
{
    partial class AvailableRooms
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
            this.lblAvailableRooms = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.pnlAvailability = new System.Windows.Forms.Panel();
            this.rtbAvailableRooms = new System.Windows.Forms.RichTextBox();
            this.lblTheFollowing = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.pnlAvailability.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BackgroundImage = global::HomeScreen.Properties.Resources.Screenshot__1_;
            this.picBox.Location = new System.Drawing.Point(-3, 1);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(184, 111);
            this.picBox.TabIndex = 27;
            this.picBox.TabStop = false;
            // 
            // lblAvailableRooms
            // 
            this.lblAvailableRooms.AutoSize = true;
            this.lblAvailableRooms.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableRooms.ForeColor = System.Drawing.Color.HotPink;
            this.lblAvailableRooms.Location = new System.Drawing.Point(396, 81);
            this.lblAvailableRooms.Name = "lblAvailableRooms";
            this.lblAvailableRooms.Size = new System.Drawing.Size(275, 31);
            this.lblAvailableRooms.TabIndex = 28;
            this.lblAvailableRooms.Text = "AVAILABLE ROOMS";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.HotPink;
            this.btnNext.Location = new System.Drawing.Point(748, 447);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(123, 48);
            this.btnNext.TabIndex = 29;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.HotPink;
            this.btnPrevious.Location = new System.Drawing.Point(145, 447);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(123, 48);
            this.btnPrevious.TabIndex = 30;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // pnlAvailability
            // 
            this.pnlAvailability.Controls.Add(this.rtbAvailableRooms);
            this.pnlAvailability.Controls.Add(this.lblTheFollowing);
            this.pnlAvailability.Location = new System.Drawing.Point(293, 139);
            this.pnlAvailability.Name = "pnlAvailability";
            this.pnlAvailability.Size = new System.Drawing.Size(447, 241);
            this.pnlAvailability.TabIndex = 32;
            // 
            // rtbAvailableRooms
            // 
            this.rtbAvailableRooms.Location = new System.Drawing.Point(3, 18);
            this.rtbAvailableRooms.Name = "rtbAvailableRooms";
            this.rtbAvailableRooms.Size = new System.Drawing.Size(441, 220);
            this.rtbAvailableRooms.TabIndex = 1;
            this.rtbAvailableRooms.Text = "";
            // 
            // lblTheFollowing
            // 
            this.lblTheFollowing.AutoSize = true;
            this.lblTheFollowing.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheFollowing.Location = new System.Drawing.Point(3, 0);
            this.lblTheFollowing.Name = "lblTheFollowing";
            this.lblTheFollowing.Size = new System.Drawing.Size(194, 15);
            this.lblTheFollowing.TabIndex = 0;
            this.lblTheFollowing.Text = "The Following Rooms Are Availabe";
            // 
            // AvailableRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 581);
            this.Controls.Add(this.pnlAvailability);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblAvailableRooms);
            this.Controls.Add(this.picBox);
            this.Name = "AvailableRooms";
            this.Text = "Rest easy Hotel";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.pnlAvailability.ResumeLayout(false);
            this.pnlAvailability.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lblAvailableRooms;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Panel pnlAvailability;
        private System.Windows.Forms.Label lblTheFollowing;
        private System.Windows.Forms.RichTextBox rtbAvailableRooms;
    }
}