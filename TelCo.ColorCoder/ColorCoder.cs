using System;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class ColorCoder
    {
        public static Color[] colorMapMajor;
        public static Color[] colorMapMinor;
       
        static ColorCoder()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }
    }
}
