﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arduino_to_envo_desktop
{
    class Device_Factory
    {
        static public Device_Interface getDevice(string deviceName, string comPort)
        {
            Device_Interface di = null;
            if (deviceName == "Arduino Uno R3")
            {
                di = new Arduino_Uno();
                di.device_Com_Port = comPort;
                return di;
            }
            else if (deviceName == "Arduino Mega 2560")
            {
                di = new Arduino_Mega();
                di.device_Com_Port = comPort;
                return di;
            }
            else
            {
                return di;
            }
        }
    }
}