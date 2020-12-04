namespace SendMailDemo
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
            this.textBox1_cc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2_content = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1_cc
            // 
            this.textBox1_cc.Location = new System.Drawing.Point(92, 81);
            this.textBox1_cc.Name = "textBox1_cc";
            this.textBox1_cc.Size = new System.Drawing.Size(319, 22);
            this.textBox1_cc.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2_content
            // 
            this.textBox2_content.Location = new System.Drawing.Point(92, 127);
            this.textBox2_content.Name = "textBox2_content";
            this.textBox2_content.Size = new System.Drawing.Size(319, 22);
            this.textBox2_content.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2_content);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1_cc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_cc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2_content;
    }
}

