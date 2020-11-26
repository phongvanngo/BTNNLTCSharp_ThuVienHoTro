namespace Webcam
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
            this.pictureBox_color = new System.Windows.Forms.PictureBox();
            this.pictureBox_whiteAndBlack = new System.Windows.Forms.PictureBox();
            this.button_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_whiteAndBlack)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_color
            // 
            this.pictureBox_color.Location = new System.Drawing.Point(47, 36);
            this.pictureBox_color.Name = "pictureBox_color";
            this.pictureBox_color.Size = new System.Drawing.Size(357, 266);
            this.pictureBox_color.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_color.TabIndex = 0;
            this.pictureBox_color.TabStop = false;
            // 
            // pictureBox_whiteAndBlack
            // 
            this.pictureBox_whiteAndBlack.Location = new System.Drawing.Point(442, 36);
            this.pictureBox_whiteAndBlack.Name = "pictureBox_whiteAndBlack";
            this.pictureBox_whiteAndBlack.Size = new System.Drawing.Size(357, 266);
            this.pictureBox_whiteAndBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_whiteAndBlack.TabIndex = 1;
            this.pictureBox_whiteAndBlack.TabStop = false;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(406, 326);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "button1";
            this.button_start.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.pictureBox_whiteAndBlack);
            this.Controls.Add(this.pictureBox_color);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_whiteAndBlack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_color;
        private System.Windows.Forms.PictureBox pictureBox_whiteAndBlack;
        private System.Windows.Forms.Button button_start;
    }
}

