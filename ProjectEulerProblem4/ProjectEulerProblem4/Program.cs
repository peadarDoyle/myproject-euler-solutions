using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerProblem4
{
    class Program
    {
        //A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        //Find the largest palindrome made from the product of two 3-digit numbers.
        static void Main(string[] args)
        {
            int product = 999 * 999;
            bool isPalindrome, hasThreeDigitFactors;

            do
            {
                isPalindrome = false; 
                hasThreeDigitFactors = false;

                isPalindrome = CheckIfPalindrome(product);

                if (isPalindrome)
                {
                    hasThreeDigitFactors = CheckIfHasThreeDigitFactors(product);
                }

                if (!isPalindrome || !hasThreeDigitFactors)
                {
                    product--;
                }

            } while (!isPalindrome || !hasThreeDigitFactors);

            Console.WriteLine("The largest palindrome made from the product of two 3-digit numbers is: " + product);
            Console.ReadLine();

        }

        static bool CheckIfPalindrome(int product)
        {
            String stringProduct = product.ToString();
            int stringLength = stringProduct.Length;
            int lastElement = stringProduct.Length - 1;
            bool isPalindrome = true;

            for (int index = 0; index < stringLength / 2; index++)
            {
                if (stringProduct.ElementAt(index) != stringProduct.ElementAt(lastElement - index))
                {
                    return !isPalindrome;
                }
            }

            return isPalindrome;
        }

        static bool CheckIfHasThreeDigitFactors(int product)
        {
            bool hasThreeDigitFactors = false;

            for(int factor = 100; factor <= 999; factor++)
            {
                if (product % factor == 0)
                {
                    if(product/factor >= 100 && product/factor <= 999)
                    {
                        return !hasThreeDigitFactors;
                    }
                }
            }

            return hasThreeDigitFactors;
        }

        
    }
}
