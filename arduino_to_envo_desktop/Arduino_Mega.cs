using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace arduino_to_envo_desktop
{
    class Arduino_Mega:Device_Interface
    {
        public string device_Com_Port { get; set; }
        public string name { get; set; }
        public int[] analogPins { get; set; }
        public int[,] positionsOfDigitPinsImage { get; set; }
        public bool[] digitalPins { get; set; }
        public int[,] positionOfAnalogTexts { get; set; }
        public Image img { get; set; }

        public Arduino_Mega()
        {
            device_Com_Port = "";
            name = "Arduino Mega 2560";
            img = Properties.Resources.arduino_mega_rev_3_bb;
            analogPins = new int[16];
            digitalPins = new bool[54];
            positionsOfDigitPinsImage = new int[54, 54];
            positionOfAnalogTexts = new int[16, 16];

            //Green red imageların pozsiyonları

            int point = 303;
            for (int i = 7; i >= 0; i--)
            {
                positionsOfDigitPinsImage[0, i] = point;
                positionsOfDigitPinsImage[1, i] = 238;
                point = point + 15;
            }
            point = 205;
            for (int i = 13; i >= 8; i--)
            {
                positionsOfDigitPinsImage[0, i] = point;
                positionsOfDigitPinsImage[1, i] = 238;
                point = point + 15;
            }
            point = 435;
            for (int i = 14; i <= 21; i++)
            {
                positionsOfDigitPinsImage[0, i] = point;
                positionsOfDigitPinsImage[1, i] = 238;
                point = point + 15;
            }
            point = 250;
            for(int i=22; i<=52; i=i+2)
            {
                positionsOfDigitPinsImage[0, i] = 583;
                positionsOfDigitPinsImage[1, i] = point;
                point = point + 15;
            }
            point = 250;
            for (int i = 23; i <= 53; i = i + 2)
            {
                positionsOfDigitPinsImage[0, i] = 599;
                positionsOfDigitPinsImage[1, i] = point;
                point = point + 15;
            }
            int pointX = 50;
            int pointY = 90;
            //Analog textlerin pozisyonları
            for(int i = 1; i<=analogPins.Length; i++)
            {
                positionOfAnalogTexts[0, i - 1] = pointX;
                positionOfAnalogTexts[1, i - 1] = pointY;
                if (i % 3 == 0)
                {
                    pointX = pointX + 150;
                    pointY = 90;
                }
                else
                {
                    pointY = pointY + 30;
                }

            }

        }
    }
}
