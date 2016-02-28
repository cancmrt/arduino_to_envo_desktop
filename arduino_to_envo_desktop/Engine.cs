using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace arduino_to_envo_desktop
{
    public class ArgPins : EventArgs
    {
        public string STATUS { get; set; }
        public int PIN { get; set; }

        public ArgPins(string stat, int p)
        {
            this.STATUS = stat;
            this.PIN = p;
        }
    }
    public class Engine
    {
        private SerialPort port = null;
        private bool flagOfStart = true;
        private string comingMessage = "";
        public event EventHandler<ArgPins> serialPortEvent;
        public ArgPins ap;
        public Engine(string com)
        {
            port = new SerialPort(com, 9600);
            BackgroundWorker backPortListener = new BackgroundWorker();
            backPortListener.DoWork += BackPortListener_DoWork;
            backPortListener.RunWorkerCompleted += BackPortListener_RunWorkerCompleted;
            backPortListener.RunWorkerAsync();
            
        }

        private void BackPortListener_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            flagOfStart = false;
            throw new NotImplementedException();
        }

        private void BackPortListener_DoWork(object sender, DoWorkEventArgs e)
        {
            port.Open();
            while(flagOfStart)
            {
                try
                {
                    comingMessage = port.ReadLine();
                    comingMessage = comingMessage.Replace("\n", String.Empty);
                    comingMessage = comingMessage.Replace("\r", String.Empty);
                    comingMessage = comingMessage.Replace("\t", String.Empty);
                    string[] parsedMesage = comingMessage.Split('_');
                    if (parsedMesage[0] == "D")
                    {
                        string statmes = "";
                        if(parsedMesage[2] == "1")
                        {
                            statmes = "ON";
                        }
                        else
                        {
                            statmes = "OFF";
                        }
                        eventParse(Int32.Parse(parsedMesage[1]),statmes);
                    }
                }
                catch
                {
                    
                }
            }
            throw new NotImplementedException();
        }
        private void eventParse(int pin,string status)
        {
            if (serialPortEvent != null)
            {
                ap = new ArgPins(status, pin);
                serialPortEvent(this, ap);
            }
            
        }
    }
    
}
