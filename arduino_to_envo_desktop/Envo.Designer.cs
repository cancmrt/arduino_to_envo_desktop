namespace arduino_to_envo_desktop
{
    partial class Envo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Envo));
            this.device_img = new System.Windows.Forms.PictureBox();
            this.red_or_green_images = new System.Windows.Forms.ImageList(this.components);
            this.serialConsole = new System.Windows.Forms.RichTextBox();
            this.labelSerialConsole = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.device_img)).BeginInit();
            this.SuspendLayout();
            // 
            // device_img
            // 
            this.device_img.Location = new System.Drawing.Point(12, 211);
            this.device_img.Name = "device_img";
            this.device_img.Size = new System.Drawing.Size(623, 354);
            this.device_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.device_img.TabIndex = 0;
            this.device_img.TabStop = false;
            // 
            // red_or_green_images
            // 
            this.red_or_green_images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("red_or_green_images.ImageStream")));
            this.red_or_green_images.TransparentColor = System.Drawing.Color.Transparent;
            this.red_or_green_images.Images.SetKeyName(0, "red.jpg");
            this.red_or_green_images.Images.SetKeyName(1, "green.jpg");
            // 
            // serialConsole
            // 
            this.serialConsole.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.serialConsole.Location = new System.Drawing.Point(665, 281);
            this.serialConsole.Name = "serialConsole";
            this.serialConsole.Size = new System.Drawing.Size(687, 284);
            this.serialConsole.TabIndex = 1;
            this.serialConsole.Text = "";
            // 
            // labelSerialConsole
            // 
            this.labelSerialConsole.AutoSize = true;
            this.labelSerialConsole.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSerialConsole.Location = new System.Drawing.Point(668, 211);
            this.labelSerialConsole.Name = "labelSerialConsole";
            this.labelSerialConsole.Size = new System.Drawing.Size(288, 45);
            this.labelSerialConsole.TabIndex = 2;
            this.labelSerialConsole.Text = "Serial Port Console";
            // 
            // Envo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1364, 788);
            this.Controls.Add(this.labelSerialConsole);
            this.Controls.Add(this.serialConsole);
            this.Controls.Add(this.device_img);
            this.Name = "Envo";
            this.Text = "Envo";
            this.Load += new System.EventHandler(this.Envo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.device_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox device_img;
        private System.Windows.Forms.ImageList red_or_green_images;
        private System.Windows.Forms.RichTextBox serialConsole;
        private System.Windows.Forms.Label labelSerialConsole;
    }
}