namespace TicketBooking.Views
{
    partial class TakePictureForm
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
            this.button1_takepicture = new System.Windows.Forms.Button();
            this.pictureBox1_camera = new System.Windows.Forms.PictureBox();
            this.button1_OK = new System.Windows.Forms.Button();
            this.button1_takeAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_camera)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_takepicture
            // 
            this.button1_takepicture.BackgroundImage = global::TicketBooking.Properties.Resources.camera;
            this.button1_takepicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1_takepicture.Location = new System.Drawing.Point(840, 226);
            this.button1_takepicture.Name = "button1_takepicture";
            this.button1_takepicture.Size = new System.Drawing.Size(113, 113);
            this.button1_takepicture.TabIndex = 1;
            this.button1_takepicture.UseVisualStyleBackColor = true;
            this.button1_takepicture.Click += new System.EventHandler(this.button1_takepicture_Click);
            // 
            // pictureBox1_camera
            // 
            this.pictureBox1_camera.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1_camera.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1_camera.Name = "pictureBox1_camera";
            this.pictureBox1_camera.Size = new System.Drawing.Size(834, 553);
            this.pictureBox1_camera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1_camera.TabIndex = 0;
            this.pictureBox1_camera.TabStop = false;
            // 
            // button1_OK
            // 
            this.button1_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1_OK.Enabled = false;
            this.button1_OK.Location = new System.Drawing.Point(859, 496);
            this.button1_OK.Name = "button1_OK";
            this.button1_OK.Size = new System.Drawing.Size(75, 45);
            this.button1_OK.TabIndex = 2;
            this.button1_OK.Text = "Đồng ý";
            this.button1_OK.UseVisualStyleBackColor = false;
            this.button1_OK.Click += new System.EventHandler(this.button1_OK_Click);
            // 
            // button1_takeAgain
            // 
            this.button1_takeAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1_takeAgain.Location = new System.Drawing.Point(859, 445);
            this.button1_takeAgain.Name = "button1_takeAgain";
            this.button1_takeAgain.Size = new System.Drawing.Size(75, 45);
            this.button1_takeAgain.TabIndex = 3;
            this.button1_takeAgain.Text = "Chụp lại";
            this.button1_takeAgain.UseVisualStyleBackColor = false;
            this.button1_takeAgain.Click += new System.EventHandler(this.button1_takeAgain_Click);
            // 
            // TakePictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 553);
            this.Controls.Add(this.button1_takeAgain);
            this.Controls.Add(this.button1_OK);
            this.Controls.Add(this.button1_takepicture);
            this.Controls.Add(this.pictureBox1_camera);
            this.Name = "TakePictureForm";
            this.Text = "TakePictureForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_camera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1_camera;
        private System.Windows.Forms.Button button1_takepicture;
        private System.Windows.Forms.Button button1_OK;
        private System.Windows.Forms.Button button1_takeAgain;
    }
}