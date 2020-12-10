namespace TicketBooking
{
    partial class MainWindow
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
            this.panel_scanQrCode = new System.Windows.Forms.Panel();
            this.panel_sidebar = new System.Windows.Forms.Panel();
            this.panel_FormBookingArea = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_scanQrCode
            // 
            this.panel_scanQrCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel_scanQrCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_scanQrCode.Location = new System.Drawing.Point(0, 0);
            this.panel_scanQrCode.Name = "panel_scanQrCode";
            this.panel_scanQrCode.Size = new System.Drawing.Size(494, 1033);
            this.panel_scanQrCode.TabIndex = 0;
            // 
            // panel_sidebar
            // 
            this.panel_sidebar.BackColor = System.Drawing.Color.Black;
            this.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_sidebar.Location = new System.Drawing.Point(1753, 0);
            this.panel_sidebar.Name = "panel_sidebar";
            this.panel_sidebar.Size = new System.Drawing.Size(149, 1033);
            this.panel_sidebar.TabIndex = 1;
            // 
            // panel_FormBookingArea
            // 
            this.panel_FormBookingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_FormBookingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_FormBookingArea.Location = new System.Drawing.Point(494, 0);
            this.panel_FormBookingArea.Name = "panel_FormBookingArea";
            this.panel_FormBookingArea.Size = new System.Drawing.Size(1259, 1033);
            this.panel_FormBookingArea.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel_FormBookingArea);
            this.Controls.Add(this.panel_sidebar);
            this.Controls.Add(this.panel_scanQrCode);
            this.MinimumSize = new System.Drawing.Size(1918, 1040);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình đặt vé";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_scanQrCode;
        private System.Windows.Forms.Panel panel_sidebar;
        private System.Windows.Forms.Panel panel_FormBookingArea;
    }
}