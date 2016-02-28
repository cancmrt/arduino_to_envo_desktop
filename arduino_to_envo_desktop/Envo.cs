using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arduino_to_envo_desktop
{
    public partial class Envo : Form
    {
        private string comPort;
        private string deviceName;
        private PictureBox[] grImages;
        private Image redImage;
        private Image greenImage;
        private Label[] analogLabel;
        private Engine engineSerial;
        public Envo(string com,string device)
        {
            comPort = com;
            deviceName = device;
            InitializeComponent();
            redImage = arduino_to_envo_desktop.Properties.Resources.red;
            greenImage = arduino_to_envo_desktop.Properties.Resources.green;
        }

        private void Envo_Load(object sender, EventArgs e)
        {
            engineSerial = new Engine(comPort);
            engineSerial.serialPortEvent += EngineSerial_serialPortEvent;
            Device_Interface arduino = Device_Factory.getDevice(deviceName, comPort);
            device_img.Image = arduino.img;
            grImages = new PictureBox[arduino.digitalPins.Length];
            analogLabel = new Label[arduino.analogPins.Length];
            for(int i=0; i<arduino.digitalPins.Length; i++)
            {
                grImages[i] = new PictureBox();
                grImages[i].Name = "grImage_" + i.ToString();
                grImages[i].Location = new Point(arduino.positionsOfDigitPinsImage[0,i],arduino.positionsOfDigitPinsImage[1,i]);
                grImages[i].Size = new Size(7, 7);
                grImages[i].Image = (Bitmap)(arduino_to_envo_desktop.Properties.Resources.red);
                grImages[i].Visible = true;
                this.Controls.Add(grImages[i]);
                Controls.SetChildIndex(grImages[i], 0);
            }
            for(int i=0; i<arduino.analogPins.Length;i++)
            {
                analogLabel[i] = new Label();
                analogLabel[i].Name = "analogLabel_" + i.ToString();
                analogLabel[i].Location = new Point(arduino.positionOfAnalogTexts[0, i], arduino.positionOfAnalogTexts[1, i]);
                analogLabel[i].Size = new Size(100, 15);
                analogLabel[i].Text = "A" + i.ToString();
                analogLabel[i].Visible = true;
                this.Controls.Add(analogLabel[i]);
            }




        }

        private void EngineSerial_serialPortEvent(object sender, ArgPins e)
        {
            if (e.STATUS == "ON")
            {
                grImages[e.PIN].Image = (Bitmap)(arduino_to_envo_desktop.Properties.Resources.green);
            }
            else if(e.STATUS == "OFF")
            {
                grImages[e.PIN].Image = (Bitmap)(arduino_to_envo_desktop.Properties.Resources.red);
            }
            
        }
    }
}
