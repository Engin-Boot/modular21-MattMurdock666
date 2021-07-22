using System;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class GetPair
    {
        private static int GetIndex(Color[] arr, Color c){
            for(int i = 0; i < arr.Length; i++){
                if(arr[i] == c){
                    return i;
                }
            }
            return -1;
        }
        public static int GetPairNumberFromColor(ColorPair pair){
            int majorIndex = GetIndex(ColorCoder.colorMapMajor, pair.majorColor);
            int minorIndex = GetIndex(ColorCoder.colorMapMinor, pair.minorColor);
           
            if (majorIndex == -1 || minorIndex == -1){
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            return (majorIndex * ColorCoder.colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}    