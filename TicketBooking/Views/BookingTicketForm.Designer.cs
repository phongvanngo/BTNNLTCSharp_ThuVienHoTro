namespace TicketBooking.Views
{
    partial class BookingTicketForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingTicketForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3_TimeAndPlace = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_takePicture = new System.Windows.Forms.Button();
            this.button1_submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Total = new System.Windows.Forms.Label();
            this.ovalPictureBox1_avatar = new OvalPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_SeatType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1_avatar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.checkBox5);
            this.panel2.Controls.Add(this.checkBox4);
            this.panel2.Controls.Add(this.checkBox3);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.comboBox3_TimeAndPlace);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button_takePicture);
            this.panel2.Controls.Add(this.button1_submit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label_Total);
            this.panel2.Controls.Add(this.ovalPictureBox1_avatar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox_SeatType);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox_email);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox_Name);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 575);
            this.panel2.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(587, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(330, 45);
            this.label8.TabIndex = 30;
            this.label8.Text = "Chọn sự kiện bạn sẽ tham gia";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox3_TimeAndPlace
            // 
            this.comboBox3_TimeAndPlace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3_TimeAndPlace.DisplayMember = "0";
            this.comboBox3_TimeAndPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3_TimeAndPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3_TimeAndPlace.FormattingEnabled = true;
            this.comboBox3_TimeAndPlace.Items.AddRange(new object[] {
            "7:00 - 15:00  Ngày 22/12 - 122 Nguyên Hồng, Phường 12, TP HCM",
            "7:00 - 15:00  Ngày 28/12 - 159 Nguyễn Văn Trỗi, Hoàn Kiếm, Hà Nội"});
            this.comboBox3_TimeAndPlace.Location = new System.Drawing.Point(592, 171);
            this.comboBox3_TimeAndPlace.Name = "comboBox3_TimeAndPlace";
            this.comboBox3_TimeAndPlace.Size = new System.Drawing.Size(590, 28);
            this.comboBox3_TimeAndPlace.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(587, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 30);
            this.label5.TabIndex = 28;
            this.label5.Text = "Chọn địa điểm và thời gian";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_takePicture
            // 
            this.button_takePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_takePicture.BackgroundImage")));
            this.button_takePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_takePicture.Location = new System.Drawing.Point(441, 129);
            this.button_takePicture.Name = "button_takePicture";
            this.button_takePicture.Size = new System.Drawing.Size(80, 80);
            this.button_takePicture.TabIndex = 21;
            this.button_takePicture.UseVisualStyleBackColor = true;
            this.button_takePicture.Click += new System.EventHandler(this.button_takePicture_Click);
            // 
            // button1_submit
            // 
            this.button1_submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(127)))), ((int)(((byte)(23)))));
            this.button1_submit.Location = new System.Drawing.Point(1030, 511);
            this.button1_submit.Name = "button1_submit";
            this.button1_submit.Size = new System.Drawing.Size(152, 46);
            this.button1_submit.TabIndex = 20;
            this.button1_submit.Text = "Đặt vé";
            this.button1_submit.UseVisualStyleBackColor = false;
            this.button1_submit.Click += new System.EventHandler(this.button1_submit_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Total
            // 
            this.label_Total.ForeColor = System.Drawing.Color.Red;
            this.label_Total.Location = new System.Drawing.Point(178, 417);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(388, 45);
            this.label_Total.TabIndex = 17;
            this.label_Total.Text = "Thành tiền";
            this.label_Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ovalPictureBox1_avatar
            // 
            this.ovalPictureBox1_avatar.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox1_avatar.ErrorImage = global::TicketBooking.Properties.Resources.NoAvatar;
            this.ovalPictureBox1_avatar.Image = global::TicketBooking.Properties.Resources.NoAvatar;
            this.ovalPictureBox1_avatar.InitialImage = global::TicketBooking.Properties.Resources.NoAvatar;
            this.ovalPictureBox1_avatar.Location = new System.Drawing.Point(174, 67);
            this.ovalPictureBox1_avatar.Name = "ovalPictureBox1_avatar";
            this.ovalPictureBox1_avatar.Size = new System.Drawing.Size(233, 205);
            this.ovalPictureBox1_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovalPictureBox1_avatar.TabIndex = 19;
            this.ovalPictureBox1_avatar.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 45);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ảnh đại diện";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_SeatType
            // 
            this.comboBox_SeatType.DisplayMember = "0";
            this.comboBox_SeatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SeatType.FormattingEnabled = true;
            this.comboBox_SeatType.Items.AddRange(new object[] {
            "Hạng A",
            "Hạng B",
            "Hạng C"});
            this.comboBox_SeatType.Location = new System.Drawing.Point(183, 356);
            this.comboBox_SeatType.Name = "comboBox_SeatType";
            this.comboBox_SeatType.Size = new System.Drawing.Size(383, 33);
            this.comboBox_SeatType.TabIndex = 18;
            this.comboBox_SeatType.SelectedIndexChanged += new System.EventHandler(this.comboBox_SeatType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 45);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 45);
            this.label3.TabIndex = 13;
            this.label3.Text = "Loại vé";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(183, 297);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(383, 30);
            this.textBox_email.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 45);
            this.label4.TabIndex = 14;
            this.label4.Text = "Thành tiền";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Name.Location = new System.Drawing.Point(174, 31);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(1008, 30);
            this.textBox_Name.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 225);
            this.panel3.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::TicketBooking.Properties.Resources.vnwebsubmit;
            this.pictureBox1.Location = new System.Drawing.Point(0, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(127)))), ((int)(((byte)(23)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1200, 45);
            this.label7.TabIndex = 20;
            this.label7.Text = "Phần đặt vé";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(592, 255);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(290, 29);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "Tương lai của công nghệ web";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(592, 303);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(414, 29);
            this.checkBox2.TabIndex = 33;
            this.checkBox2.Text = "Ứng dụng của điện toán đám mây trong IOT";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(592, 349);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(420, 29);
            this.checkBox3.TabIndex = 34;
            this.checkBox3.Text = "Trí tuệ nhân tạo và những phát triển vượt bậc";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(592, 399);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(357, 29);
            this.checkBox4.TabIndex = 35;
            this.checkBox4.Text = "Xu hướng công nghệ trong năm 2020";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(592, 449);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(295, 29);
            this.checkBox5.TabIndex = 36;
            this.checkBox5.Text = "Gặp gỡ giao lưu với Steve Job";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BookingTicketForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BookingTicketForm";
            this.Size = new System.Drawing.Size(1200, 800);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1_avatar)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Total;
        private OvalPictureBox ovalPictureBox1_avatar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1_submit;
        private System.Windows.Forms.Button button_takePicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox_SeatType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3_TimeAndPlace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
