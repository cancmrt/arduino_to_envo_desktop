using System;
using System.Windows.Forms;

namespace arduino_to_envo_desktop
{
    public partial class Form1 : Form
    {
        bool changeOfArduino = false;
        bool changeOfCom = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void loadAvailableComPorts()
        {
            string[] coms = System.IO.Ports.SerialPort.GetPortNames();
            for (int i = 0; i < coms.Length; i++)
            {
                list_coms.Items.Add(coms[i]);
            }
        }
        private bool lookAvaliableComPorts(string com)
        {
            string[] coms = System.IO.Ports.SerialPort.GetPortNames();
            for (int i = 0; i < coms.Length; i++)
            {
                if(coms[i] == com)
                {
                    return true;
                }
            }
            return false;
        }

        private void checkForNextStage()
        {
            if (changeOfArduino == true && changeOfCom == true)
            {
                next_btn.Enabled = true;
            }
        }
        private void list_arduinos_SelectedIndexChanged(object sender, EventArgs e)
        {
            arduino_img.Image = arduino_imgs.Images[list_arduinos.SelectedIndex];
            changeOfArduino = true;
            checkForNextStage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list_coms.Items.Clear();
            loadAvailableComPorts();
            next_btn.Enabled = false;
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (lookAvaliableComPorts(list_coms.SelectedItem.ToString()))
            {
                this.Hide();
                Envo en = new Envo(list_coms.SelectedItem.ToString(), list_arduinos.SelectedItem.ToString());
                en.Show();
            }
            else
            {
                MessageBox.Show("Com Port is not avaliable.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void refresh_pic_btn_Click(object sender, EventArgs e)
        {
            list_coms.Items.Clear();
            loadAvailableComPorts();
        }

        private void list_coms_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeOfCom = true;
            checkForNextStage();
        }
    }
}
