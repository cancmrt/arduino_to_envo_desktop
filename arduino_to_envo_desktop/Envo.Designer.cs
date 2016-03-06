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
            this.red_or_green_images = new System.Windows.Forms.ImageList(this.components);
            this.serialConsole = new System.Windows.Forms.RichTextBox();
            this.labelSerialConsole = new System.Windows.Forms.Label();
            this.labelAnalogValues = new System.Windows.Forms.Label();
            this.restart_img_btn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.device_img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.restart_img_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.device_img)).BeginInit();
            this.SuspendLayout();
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
            this.serialConsole.Location = new System.Drawing.Point(665, 243);
            this.serialConsole.Name = "serialConsole";
            this.serialConsole.Size = new System.Drawing.Size(687, 322);
            this.serialConsole.TabIndex = 1;
            this.serialConsole.Text = "";
            // 
            // labelSerialConsole
            // 
            this.labelSerialConsole.AutoSize = true;
            this.labelSerialConsole.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSerialConsole.Location = new System.Drawing.Point(657, 195);
            this.labelSerialConsole.Name = "labelSerialConsole";
            this.labelSerialConsole.Size = new System.Drawing.Size(288, 45);
            this.labelSerialConsole.TabIndex = 2;
            this.labelSerialConsole.Text = "Serial Port Console";
            // 
            // labelAnalogValues
            // 
            this.labelAnalogValues.AutoSize = true;
            this.labelAnalogValues.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAnalogValues.Location = new System.Drawing.Point(46, 28);
            this.labelAnalogValues.Name = "labelAnalogValues";
            this.labelAnalogValues.Size = new System.Drawing.Size(221, 45);
            this.labelAnalogValues.TabIndex = 4;
            this.labelAnalogValues.Text = "Analog Values";
            // 
            // restart_img_btn
            // 
            this.restart_img_btn.Image = global::arduino_to_envo_desktop.Properties.Resources._1457279205_Power___Restart;
            this.restart_img_btn.Location = new System.Drawing.Point(1256, 89);
            this.restart_img_btn.Name = "restart_img_btn";
            this.restart_img_btn.Size = new System.Drawing.Size(56, 50);
            this.restart_img_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restart_img_btn.TabIndex = 5;
            this.restart_img_btn.TabStop = false;
            this.restart_img_btn.Click += new System.EventHandler(this.restart_img_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::arduino_to_envo_desktop.Properties.Resources.maxresdefault;
            this.pictureBox1.Location = new System.Drawing.Point(1214, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
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
            // Envo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1364, 788);
            this.Controls.Add(this.restart_img_btn);
            this.Controls.Add(this.labelAnalogValues);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelSerialConsole);
            this.Controls.Add(this.serialConsole);
            this.Controls.Add(this.device_img);
            this.Name = "Envo";
            this.Text = "Envo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Envo_FormClosed);
            this.Load += new System.EventHandler(this.Envo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restart_img_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.device_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox device_img;
        private System.Windows.Forms.ImageList red_or_green_images;
        private System.Windows.Forms.RichTextBox serialConsole;
        private System.Windows.Forms.Label labelSerialConsole;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAnalogValues;
        private System.Windows.Forms.PictureBox restart_img_btn;
    }
}