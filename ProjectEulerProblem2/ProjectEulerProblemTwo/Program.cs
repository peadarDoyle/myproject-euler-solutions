using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerProblemTwo
{
    // giving correct answer
    class Program
    {
        // generate the sum of even terms of the fibonacci series less than 4m where the seed terms are 1 and 2 
        static void Main(string[] args)
        {
            // 1. specify seed values, next term in series and upper threshold (4m)
            int lowSeed = 1, highSeed = 2, nextTerm = 0, uppThresh = 4000000;

            // 2. create the sum of the terms
            int fibSum = 0;

            
            do
            {
                // 3. add the second seed to the sum (if even)
                if(highSeed % 2 == 0)
                {
                    fibSum += highSeed;
                }

                // 4. generate the next term
                nextTerm = lowSeed + highSeed;

                // 5. make the higher seed the lower seed and make the generated term the new higher seed
                lowSeed = highSeed;
                highSeed = nextTerm;
            }
            // 6. check if the latter term is greater or equal to 4m
            while (nextTerm < uppThresh);

            // 7. print the sum
            Console.WriteLine("The fibonnaci series sum for even terms less than 4m is: " + fibSum);
            Console.ReadLine();
        }
    }
}
