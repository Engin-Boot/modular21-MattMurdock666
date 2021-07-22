using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// Test code for the class
    /// </summary>
        
    class Test{
         
        /// <param name="args"></param> 
        private static void Main(string[] args)
        {
            TestAllPairs();

            ReferenceManual.PrintMapping(new ConsoleLogger());
            
        }

        public static void TestAllPairs()
        {
            int actualPairNumber = 1;

            for(int i = 0; i < ColorCoder.colorMapMajor.Length; i++)
            {
                for(int j = 0; j < ColorCoder.colorMapMinor.Length; j++)
                {
                    var colorPair = GetColor.GetColorFromPairNumber(actualPairNumber);
                    Debug.Assert(colorPair.majorColor == ColorCoder.colorMapMajor[i]);
                    Debug.Assert(colorPair.minorColor == ColorCoder.colorMapMinor[i]);

                    colorPair = new ColorPair
                    {
                        majorColor = ColorCoder.colorMapMajor[i],
                        minorColor = ColorCoder.colorMapMinor[i]
                    };

                    int expectedPairNumber = GetPair.GetPairNumberFromColor(colorPair);

                    Debug.Assert(actualPairNumber == expectedPairNumber);

                    actualPairNumber++;

                }
            }
        }
    }
}   