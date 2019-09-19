using System;
using WaveFilterer.Library;
namespace FullWaveFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int[] inputArray = new int[number];
            Console.WriteLine("Enter size of index array:");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine("Enter a number for {0}. number, {1} remaining:", i.ToString(), (number - (i)).ToString());
                    int indexNumber = 0;
                    if (int.TryParse(Console.ReadLine(), out indexNumber))
                    {
                        inputArray[i] = indexNumber;
                    }
                }
                Console.WriteLine("---------");
            }

            WaveFilters.FilterWaves(inputArray);
        }
    }

}
