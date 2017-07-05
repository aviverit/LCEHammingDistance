using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCEHammingDistance
{
    class Solution
    {
        public int HammingDistance(int x, int y)
        {
            int counter = 0;

            String binaryX = Convert.ToString(x, 2);
            String binaryY = Convert.ToString(y, 2);

            if (binaryX.Length != binaryY.Length) {
                if (binaryX.Length > binaryY.Length) {
                    while (binaryX.Length != binaryY.Length) {
                        binaryY=binaryY.Insert(0, "0");
                    }
                } else {
                    while (binaryX.Length != binaryY.Length)
                    {
                        binaryX=binaryX.Insert(0, "0");
                    }
                }
            }

            for (int i = 0; i < binaryX.Length; i++) {
                if (binaryX[i] != binaryY[i]) {
                    counter++;
                }
            }

            return counter;
        }
    }
}
