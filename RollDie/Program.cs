using System;

namespace RollDie
{
    class RollDie
    {
        static void Main()
        {
            Random randomNumbers = new Random();// Random number Generator

            int frequency1 = 0; // Count of 1's rolled
            int frequency2 = 0; // Count of 2's rolled
            int frequency3 = 0; // Count of 3's rolled
            int frequency4 = 0; // Count of 4's rolled
            int frequency5 = 0; // Count of 5's rolled
            int frequency6 = 0; // Count of 6's rolled

            //Summerize results of 60,000,000
            for(int roll = 1; roll <= 60000000; ++roll)
            {
                int face = randomNumbers.Next(1, 7); //Numbers 1 to 6

                // Determine value 1-6 and increment appropriate counter
                switch (face)
                {
                    case 1:
                        ++frequency1; // increment the 1's counter
                        break;
                    case 2:
                        ++frequency2; // increment the 2's counter
                        break;
                    case 3:
                        ++frequency3; // increment the 3's counter
                        break;
                    case 4:
                        ++frequency4; // increment the 4's counter
                        break;
                    case 5:
                        ++frequency5; // increment the 5's counter
                        break;
                    case 6:
                        ++frequency6; // increment the 6's counter
                        break;
                }
            }
            Console.WriteLine("Face\tFrequency"); // Output headers
            Console.WriteLine($"1\t{frequency1}\n2\t{frequency2}");
            Console.WriteLine($"3\t{frequency3}\n4\t{frequency4}");
            Console.WriteLine($"5\t{frequency5}\n6\t{frequency6}");
        }
    }
}
