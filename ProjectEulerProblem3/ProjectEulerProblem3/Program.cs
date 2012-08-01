using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerProblem3
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 600851475143;

            long nextHighestFactor, nextLowestFactor = 1;

            bool notPrime;

            do
            {
                notPrime = false;

                do
                {
                    nextLowestFactor++;
                } while(number % nextLowestFactor != 0);

                nextHighestFactor = number/nextLowestFactor;

                Console.WriteLine(nextHighestFactor);

                for (int index = 2; index < nextHighestFactor; index++)
                {
                    if (nextHighestFactor % index == 0)
                    {
                        notPrime = true;
                        break;
                    }
                }

            } while (notPrime);

            Console.WriteLine("Heighest prime factor of 600851475143 is: " + nextHighestFactor);
            Console.ReadLine();
        }

    }
}
