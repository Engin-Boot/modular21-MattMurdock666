using System;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class GetColor
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
    }
}