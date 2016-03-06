using System;
using System.ComponentModel;
using System.IO.Ports;


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
            port.DtrEnable = true;
            port.Open();
            BackgroundWorker backPortListener = new BackgroundWorker();
            backPortListener.DoWork += BackPortListener_DoWork;
            backPortListener.RunWorkerCompleted += BackPortListener_RunWorkerCompleted;
            backPortListener.RunWorkerAsync();
            
        }

        private void BackPortListener_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            flagOfStart = false;
            port.Close();
        }

        private void BackPortListener_DoWork(object sender, DoWorkEventArgs e)
        {
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
                    else if(parsedMesage[0] == "A")
                    {
                        eventParse(Int32.Parse(parsedMesage[1]), parsedMesage[2]);
                    }
                    else
                    {
                        eventParse(-1, comingMessage);
                    }
                }
                catch
                {
                    eventParse(-1, comingMessage);
                }
            }
            
        }
        private void eventParse(int pin,string status)
        {
            if (serialPortEvent != null)
            {
                ap = new ArgPins(status, pin);
                serialPortEvent(this, ap);
            }
            
        }
        public void stopEngine()
        {
            flagOfStart = false;
            port.Close();
        }
    }
    
}
