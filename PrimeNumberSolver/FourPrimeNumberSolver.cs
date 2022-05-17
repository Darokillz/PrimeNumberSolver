using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeNumberSolver
{
    /* Exercise 2
     * 
     * This class is to solve the Question: I have four different prime numbers all under 1000, find the product of these
     * primes is a 12 digit who is either sequential in ascending order or the same as previous digit.
     * 
     * The four prime number was: 313 563 811 863
     * The produt of these 4 prime number is : 123334444567
     * 
     * In terms of performance, it takes ~1.5sec excluding printing results
     * 
     */
    class FourPrimeNumberSolver
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            int[] finalArrayOfNumber = FindAllPrimeNumber.SieveOfEratosthenes(1000);
            FindMyFourPrimeNumber solution = new FindMyFourPrimeNumber(finalArrayOfNumber);
            int[] finalAnswers= solution.FindFourSolution();

            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

            long mulitplyAnswer = 1;
            Console.Write("The four prime numbers are : ");
            foreach (int aNumber in finalAnswers)
            {
                mulitplyAnswer *= aNumber;
                Console.Write(aNumber + " ");
            }
            Console.Write("The result answer: " + mulitplyAnswer);

        }
    }
}
