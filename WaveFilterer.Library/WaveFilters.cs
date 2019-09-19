using System;
using System.Collections.Generic;

namespace WaveFilterer.Library
{
    public class WaveFilters
    {
        public static int[] FilterWaves(int[] input)
        {
            var filteredValues = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < 5)
                {
                    filteredValues.Add(5);
                }

                else if (input[i] > 20)
                {
                    filteredValues.Add(20);
                }

                else
                {
                    filteredValues.Add(input[i]);
                }

            }

            return filteredValues.ToArray();
        }

    }
}
