using System.Drawing;


namespace arduino_to_envo_desktop
{
    public class Arduino_Uno:Device_Interface
    {
        public string device_Com_Port { get; set; }
        public string name { get; set; }
        public int[] analogPins { get; set; }
        public bool[] digitalPins { get; set; }
        public int[,] positionsOfDigitPinsImage { get; set; }
        public int[,] positionOfAnalogTexts { get; set; }
        public Image img { get; set; }

        public Arduino_Uno()
        {
            device_Com_Port = "";
            name = "Arduino Uno R3";
            img = arduino_to_envo_desktop.Properties.Resources.arduino_uno;
            analogPins = new int[6];
            digitalPins = new bool[14];
            positionsOfDigitPinsImage = new int[14, 14];
            positionOfAnalogTexts = new int[6, 6];

            int point = 308;
            for (int i = 13; i >= 8; i--)
            {
                positionsOfDigitPinsImage[0, i] = point;
                positionsOfDigitPinsImage[1, i] = 224;
                point = point + 16;
            }
            point = 417;
            for (int i = 7; i >= 0; i--)
            {
                positionsOfDigitPinsImage[0, i] = point;
                positionsOfDigitPinsImage[1, i] = 224;
                point = point + 16;
            }
            int pointX = 50;
            int pointY = 90;
            //Analog textlerin pozisyonları
            for (int i = 1; i <= analogPins.Length; i++)
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
