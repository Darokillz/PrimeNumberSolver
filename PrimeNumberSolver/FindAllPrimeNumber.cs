using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumberSolver
{
    /* A class to find all the prime numbers under the specified ammount
    * Methods  : SieveOfEratosthene - The Sieve of Eratosthenes algorithm 
    */
    public class FindAllPrimeNumber
    {

        // Time complexity: 0(n*log(log(n)))
        // A method using the SieveOfEratosthenes algorithm to use 
        // the given number n to final all primes smaller than or equal to n
        // Input    : interger n
        // Output   : a array of prime numbers of the type int
       public static int[] SieveOfEratosthenes(int n)
        {
            // Create a boolean array
            // "prime[0..n]" and
            // initialize all entries
            // it as true. A value in
            // prime[i] will finally be
            // false if i is Not a
            // prime, else true.

            int counter = 0;

            bool[] prime = new bool[n + 1];

            for (int i = 0; i <= n; i++)
                prime[i] = true;

            for (int p = 2; p * p <= n; p++)
            {
                // If prime[p] is not changed,
                // then it is a prime
                if (prime[p] == true)
                {
                    // Update all multiples of p
                    int iteration = p * 2;
                    while(iteration < n+1)
                    {
                        prime[iteration] = false;
                        iteration += p;
                    }


                }
            }

            // Get the size of array to initalise
            for (int i = 2; i <= n; i++)
            {
                if (prime[i] == true)
                    counter++;
            }

            int[] finalPrimeNumbers = new int[counter];
            int increment = 0;

            // Add all prime numbers into a list
            for (int i = 2; i <= n; i++)
            {
                if (prime[i] == true)
                {
                    finalPrimeNumbers[increment] = i;
                    increment++;
                }
            }

            return finalPrimeNumbers;
        }
    }
}
