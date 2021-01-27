using System;

namespace Arrays
{
    public class TwoDArrayDS
    {
        public TwoDArrayDS()
        {

        }

        public int GetLargestHourGlassValue(int[][] arr)
        {
            int size = arr.Length;
            int hourglassSum = 0, localHourglass;

            for (int i = 1; i < (size - 1); i++)
            {
                for (int j = 1; j < (size - 1); j++)
                {
                    localHourglass = arr[i - 1][j - 1] + arr[i - 1][j] + arr[i - 1][j + 1] + arr[i][j] + arr[i + 1][j - 1] + arr[i + 1][j] + arr[i + 1][j + 1];
                    if (i == 1 && j == 1)
                    {
                        hourglassSum = localHourglass;
                    }
                    if (localHourglass > hourglassSum)
                    {
                        hourglassSum = localHourglass;
                    }
                }
            }
            return hourglassSum;
        }
    }
}
