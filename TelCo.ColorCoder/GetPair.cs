using System;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class GetPair
    {
        public static int GetPairNumberFromColor(ColorPair pair){
            int majorIndex = -1;
            int minorIndex = -1;
            for (int i = 0; i < ColorCoder.colorMapMajor.Length; i++){
                if (ColorCoder.colorMapMajor[i] == pair.majorColor){
                    majorIndex = i;
                    break;
                }
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