using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class LeftRotation
    {
        public int[] rotLeft(int[] a, int d)
        {
            int[] Temp = new int[a.Length];
            int myPosition;
            for (int i = 0; i <= (a.Length - 1); i++)
            {
                if ((d + i) >= a.Length)
                {
                    myPosition = (d + i) - (a.Length);
                    Temp[i] = a[myPosition];
                }
                else
                {
                    Temp[i] = a[(i + d)];
                }
            }
            return Temp;
        }
    }
}
