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
        private TextBox[] analogTextBox;
        private Engine engineSerial;
        private Device_Interface arduino;
        public Envo(string com,string device)
        {
            comPort = com;
            deviceName = device;
            InitializeComponent();
            redImage = arduino_to_envo_desktop.Properties.Resources.red;
            greenImage = arduino_to_envo_desktop.Properties.Resources.green;
            arduino = Device_Factory.getDevice(deviceName, comPort);
        }

        private void Envo_Load(object sender, EventArgs e)
        {
            engineSerial = new Engine(comPort);
            engineSerial.serialPortEvent += EngineSerial_serialPortEvent;
            device_img.Image = arduino.img;
            grImages = new PictureBox[arduino.digitalPins.Length];
            analogLabel = new Label[arduino.analogPins.Length];
            analogTextBox = new TextBox[arduino.analogPins.Length];
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
                analogTextBox[i] = new TextBox();

                analogLabel[i].Name = "analogLabel_" + i.ToString();
                analogTextBox[i].Name = "analogTextbox_" + i.ToString();

                analogLabel[i].Location = new Point(arduino.positionOfAnalogTexts[0, i], arduino.positionOfAnalogTexts[1, i]);
                analogTextBox[i].Location = new Point(arduino.positionOfAnalogTexts[0, i] + 30, arduino.positionOfAnalogTexts[1, i]);

                analogLabel[i].Size = new Size(30, 15);
                analogTextBox[i].Size = new Size(97, 15);

                analogLabel[i].Text = "A" + i.ToString();

                analogLabel[i].Visible = true;
                analogTextBox[i].Visible = true;
                this.Controls.Add(analogLabel[i]);
                this.Controls.Add(analogTextBox[i]);
            }




        }

        private void EngineSerial_serialPortEvent(object sender, ArgPins e)
        {
            if(e.PIN == -1)
            {
                serialConsole.BeginInvoke(new MethodInvoker(() => serialConsole.Text += e.STATUS+"\n"));
            }
            else if (e.PIN < arduino.digitalPins.Length)
            {
                if (e.STATUS == "ON")
                {
                    arduino.digitalPins[e.PIN] = true;
                    grImages[e.PIN].Image = (Bitmap)(arduino_to_envo_desktop.Properties.Resources.green);
                }
                else if (e.STATUS == "OFF")
                {
                    arduino.digitalPins[e.PIN] = false;
                    grImages[e.PIN].Image = (Bitmap)(arduino_to_envo_desktop.Properties.Resources.red);
                }
            }
            else if(e.PIN >= arduino.analogPins.Length)
            {
                analogTextBox[arduino.digitalPins.Length - e.PIN].BeginInvoke(new MethodInvoker(() => analogTextBox[arduino.digitalPins.Length - e.PIN].Text = e.STATUS));
                arduino.analogPins[arduino.digitalPins.Length - e.PIN] = Int32.Parse(e.STATUS);
            }
            serialConsole.BeginInvoke(new MethodInvoker(() => serialConsole.SelectionStart = serialConsole.Text.Length));
            serialConsole.BeginInvoke(new MethodInvoker(() => serialConsole.ScrollToCaret()));

        }
    }
}
