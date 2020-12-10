namespace TicketBooking.Views
{
    partial class SuccessCheckInForm
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
            this.label_dateCreated = new System.Windows.Forms.Label();
            this.label_Seat = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.labeell = new System.Windows.Forms.Label();
            this.label_Loaighe = new System.Windows.Forms.Label();
            this.label1_name = new System.Windows.Forms.Label();
            this.labelll = new System.Windows.Forms.Label();
            this.ovalPictureBox1_avatar = new OvalPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label_dateCreated
            // 
            this.label_dateCreated.ForeColor = System.Drawing.Color.Red;
            this.label_dateCreated.Location = new System.Drawing.Point(202, 616);
            this.label_dateCreated.Name = "label_dateCreated";
            this.label_dateCreated.Size = new System.Drawing.Size(272, 41);
            this.label_dateCreated.TabIndex = 37;
            this.label_dateCreated.Text = "00:00";
            this.label_dateCreated.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Seat
            // 
            this.label_Seat.ForeColor = System.Drawing.Color.Red;
            this.label_Seat.Location = new System.Drawing.Point(202, 559);
            this.label_Seat.Name = "label_Seat";
            this.label_Seat.Size = new System.Drawing.Size(272, 41);
            this.label_Seat.TabIndex = 36;
            this.label_Seat.Text = "A";
            this.label_Seat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_email
            // 
            this.label_email.ForeColor = System.Drawing.Color.Red;
            this.label_email.Location = new System.Drawing.Point(202, 503);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(272, 41);
            this.label_email.TabIndex = 35;
            this.label_email.Text = "*@gmail.com";
            this.label_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labeell
            // 
            this.labeell.ForeColor = System.Drawing.Color.Black;
            this.labeell.Location = new System.Drawing.Point(69, 616);
            this.labeell.Name = "labeell";
            this.labeell.Size = new System.Drawing.Size(127, 41);
            this.labeell.TabIndex = 34;
            this.labeell.Text = "Ngày đặt vé";
            this.labeell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Loaighe
            // 
            this.label_Loaighe.ForeColor = System.Drawing.Color.Black;
            this.label_Loaighe.Location = new System.Drawing.Point(69, 559);
            this.label_Loaighe.Name = "label_Loaighe";
            this.label_Loaighe.Size = new System.Drawing.Size(127, 41);
            this.label_Loaighe.TabIndex = 33;
            this.label_Loaighe.Text = "Loại ghế";
            this.label_Loaighe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1_name
            // 
            this.label1_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_name.Location = new System.Drawing.Point(173, 428);
            this.label1_name.Name = "label1_name";
            this.label1_name.Size = new System.Drawing.Size(205, 41);
            this.label1_name.TabIndex = 31;
            this.label1_name.Text = "Họ Tên";
            this.label1_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelll
            // 
            this.labelll.ForeColor = System.Drawing.Color.Black;
            this.labelll.Location = new System.Drawing.Point(69, 503);
            this.labelll.Name = "labelll";
            this.labelll.Size = new System.Drawing.Size(99, 41);
            this.labelll.TabIndex = 32;
            this.labelll.Text = "Email";
            this.labelll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ovalPictureBox1_avatar
            // 
            this.ovalPictureBox1_avatar.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox1_avatar.Location = new System.Drawing.Point(74, 12);
            this.ovalPictureBox1_avatar.Name = "ovalPictureBox1_avatar";
            this.ovalPictureBox1_avatar.Size = new System.Drawing.Size(400, 400);
            this.ovalPictureBox1_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovalPictureBox1_avatar.TabIndex = 23;
            this.ovalPictureBox1_avatar.TabStop = false;
            // 
            // SuccessCheckInForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(556, 711);
            this.Controls.Add(this.label_dateCreated);
            this.Controls.Add(this.label_Seat);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.labeell);
            this.Controls.Add(this.label_Loaighe);
            this.Controls.Add(this.labelll);
            this.Controls.Add(this.label1_name);
            this.Controls.Add(this.ovalPictureBox1_avatar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SuccessCheckInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuccessCheckInForm";
            this.Load += new System.EventHandler(this.SuccessCheckInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1_avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OvalPictureBox ovalPictureBox1_avatar;
        private System.Windows.Forms.Label label_dateCreated;
        private System.Windows.Forms.Label label_Seat;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label labeell;
        private System.Windows.Forms.Label label_Loaighe;
        private System.Windows.Forms.Label label1_name;
        private System.Windows.Forms.Label labelll;
    }
}