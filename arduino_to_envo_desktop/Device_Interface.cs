using System.Drawing;

namespace arduino_to_envo_desktop
{
    public interface Device_Interface
    {
        string device_Com_Port { get; set; }
        string name { get; set; }
        int[] analogPins { get; set; }
        bool[] digitalPins { get; set; }
        int[,] positionsOfDigitPinsImage { get; set; }
        int[,] positionOfAnalogTexts { get; set; }
        Image img { get; set; }
    }
}
