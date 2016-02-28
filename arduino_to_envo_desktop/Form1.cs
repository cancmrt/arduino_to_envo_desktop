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
    public partial class Form1 : Form
    {
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


        private void list_arduinos_SelectedIndexChanged(object sender, EventArgs e)
        {
            arduino_img.Image = arduino_imgs.Images[list_arduinos.SelectedIndex];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            com_ports_checker.Start();
        }
        private void com_ports_checker_Tick(object sender, EventArgs e)
        {
            list_coms.Items.Clear();
            loadAvailableComPorts();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Envo en = new Envo(list_coms.SelectedItem.ToString(),list_arduinos.SelectedItem.ToString());
            en.Show();
        }
    }
}
