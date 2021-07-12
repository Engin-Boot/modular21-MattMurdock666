using System;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class ColorCoderUtil
    {
        public static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            int minorSize = ColorCoder.colorMapMinor.Length;
            int majorSize = ColorCoder.colorMapMajor.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize){
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }
            
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;

            ColorPair pair = new ColorPair() { majorColor = ColorCoder.colorMapMajor[majorIndex],
                minorColor = ColorCoder.colorMapMinor[minorIndex] };

            return pair;
        }

        public static int GetPairNumberFromColor(ColorPair pair){
            int majorIndex = -1;
            for (int i = 0; i < ColorCoder.colorMapMajor.Length; i++){
                if (ColorCoder.colorMapMajor[i] == pair.majorColor){
                    majorIndex = i;
                    break;
                }
            }
            int minorIndex = -1;
            for (int i = 0; i < ColorCoder.colorMapMinor.Length; i++){
                if (ColorCoder.colorMapMinor[i] == pair.minorColor){
                    minorIndex = i;
                    break;
                }
            }
            if (majorIndex == -1 || minorIndex == -1){
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            return (majorIndex * ColorCoder.colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}    