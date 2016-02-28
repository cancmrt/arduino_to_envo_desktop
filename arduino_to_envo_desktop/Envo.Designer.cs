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
            // Envo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1364, 788);
            this.Controls.Add(this.device_img);
            this.Name = "Envo";
            this.Text = "Envo";
            this.Load += new System.EventHandler(this.Envo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.device_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox device_img;
        private System.Windows.Forms.ImageList red_or_green_images;
    }
}