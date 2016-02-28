namespace arduino_to_envo_desktop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.list_arduinos = new System.Windows.Forms.ComboBox();
            this.arduino_imgs = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.list_coms = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.arduino_img = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.next_btn = new System.Windows.Forms.Button();
            this.com_ports_checker = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arduino_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Showduino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose your device";
            // 
            // list_arduinos
            // 
            this.list_arduinos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.list_arduinos.FormattingEnabled = true;
            this.list_arduinos.Items.AddRange(new object[] {
            "Arduino Uno R3",
            "Arduino Mega 2560 R3"});
            this.list_arduinos.Location = new System.Drawing.Point(20, 126);
            this.list_arduinos.Name = "list_arduinos";
            this.list_arduinos.Size = new System.Drawing.Size(133, 21);
            this.list_arduinos.TabIndex = 3;
            this.list_arduinos.SelectedIndexChanged += new System.EventHandler(this.list_arduinos_SelectedIndexChanged);
            // 
            // arduino_imgs
            // 
            this.arduino_imgs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("arduino_imgs.ImageStream")));
            this.arduino_imgs.TransparentColor = System.Drawing.Color.Transparent;
            this.arduino_imgs.Images.SetKeyName(0, "arduino_uno.png");
            this.arduino_imgs.Images.SetKeyName(1, "arduino_mega_rev_3_bb.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(187, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choose your COM port";
            // 
            // list_coms
            // 
            this.list_coms.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.list_coms.FormattingEnabled = true;
            this.list_coms.Location = new System.Drawing.Point(191, 126);
            this.list_coms.Name = "list_coms";
            this.list_coms.Size = new System.Drawing.Size(133, 21);
            this.list_coms.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::arduino_to_envo_desktop.Properties.Resources._2000px_USB_Icon_svg;
            this.pictureBox3.Location = new System.Drawing.Point(384, 101);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(124, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // arduino_img
            // 
            this.arduino_img.Location = new System.Drawing.Point(20, 153);
            this.arduino_img.Name = "arduino_img";
            this.arduino_img.Size = new System.Drawing.Size(503, 217);
            this.arduino_img.TabIndex = 4;
            this.arduino_img.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::arduino_to_envo_desktop.Properties.Resources.maxresdefault;
            this.pictureBox1.Location = new System.Drawing.Point(892, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // next_btn
            // 
            this.next_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.next_btn.Location = new System.Drawing.Point(916, 328);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(103, 42);
            this.next_btn.TabIndex = 8;
            this.next_btn.Text = "Next";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // com_ports_checker
            // 
            this.com_ports_checker.Interval = 5000;
            this.com_ports_checker.Tick += new System.EventHandler(this.com_ports_checker_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1031, 378);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.list_coms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.arduino_img);
            this.Controls.Add(this.list_arduinos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arduino_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox list_arduinos;
        private System.Windows.Forms.ImageList arduino_imgs;
        private System.Windows.Forms.PictureBox arduino_img;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox list_coms;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Timer com_ports_checker;
    }
}

