namespace HomeScreen
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bokking Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Salmon;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.LightCoral;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.LightCoral;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.LightCoral;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Salmon;
            this.dateTimePicker1.Location = new System.Drawing.Point(560, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(560, 272);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(469, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Check-In Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(461, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Check-Out Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(453, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Number of Guests";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Salmon;
            this.label5.Location = new System.Drawing.Point(435, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Special Requirements";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1102, -3);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 463);
            this.vScrollBar1.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(560, 328);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(560, 380);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1120, 627);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.LightCoral;
            this.Name = "Form1";
            this.Text = "Rest Easy Hotel ";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

