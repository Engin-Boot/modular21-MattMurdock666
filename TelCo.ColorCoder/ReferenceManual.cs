using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    public class ReferenceManual
    {
        private static int majorMapLength = ColorCoder.colorMapMajor.Length;
        private static int minorMapLength = ColorCoder.colorMapMinor.Length;

        public static void PrintMapping(ILogger logger)
        {
            int pairNumber = 1;

            for(int i = 0; i < majorMapLength; i++)
            {
                for(int j = 0; j < minorMapLength; j++)
                {
                    logger.Log("Major Color : " + ColorCoder.colorMapMajor[i] + " Minor Color : " + ColorCoder.colorMapMinor[i] + " Pair Number : " + pairNumber);
                    pairNumber++;
                }
            }
        }
    }
}