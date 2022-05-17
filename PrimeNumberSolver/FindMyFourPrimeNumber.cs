using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumberSolver
{

    /* A class to handle solving the Exercise 2 question
     * 
     * Variable : arrayOfPrimeNumbers - used to store the given array of prime numbers
     * Methods  : FindMyFourPrimeNumber - Goes through the whole array of prime numbers that meets the requirment 
     *                                    and returns solution
     *                                    
     *            SeqConditionCheck - checks if the given number meets the requirment
     */
    class FindMyFourPrimeNumber
    {
        int[] arrayOfPrimeNumbers;

        //constructor
        public FindMyFourPrimeNumber(int[] n)
        {
            arrayOfPrimeNumbers = n;
        }

        // Method used to check every prime number in the given array and multiply with 4 prime number.
        // The result of the mulitpling the four prime number will be checked with the sequential condition check method.
        //
        // Output: The final four integer solution inside the array type of int
        public int[] FindFourSolution()
        {
            int[] resultPrimeNumbers = new int[4];

            for (int p1 = 0; p1 < arrayOfPrimeNumbers.Length; p1++)
            {
                for (int p2 = p1 + 1; p2 < arrayOfPrimeNumbers.Length; p2++)
                {
                    for (int p3 = p2 + 1; p3 < arrayOfPrimeNumbers.Length; p3++)
                    {
                        for (int p4 = p3 + 1; p4 < arrayOfPrimeNumbers.Length; p4++)
                        {
                            if (SeqConditionCheck((long)arrayOfPrimeNumbers[p1] * arrayOfPrimeNumbers[p2] * arrayOfPrimeNumbers[p3] * arrayOfPrimeNumbers[p4]))
                            {
                                return resultPrimeNumbers = new int[] { arrayOfPrimeNumbers[p1], arrayOfPrimeNumbers[p2], arrayOfPrimeNumbers[p3], arrayOfPrimeNumbers[p4] }; // the time is based on when it finds the answer
                            }


                        }
                    }
                }
            }
            return resultPrimeNumbers;
        }

        //Method used to check if the given input meets the required condition.
        //The condition being: length of 12 , sequential in ascending order or same as previous digit.
        //
        //Input  : a number of type long
        //Output : returns true of false based on result.
        public bool SeqConditionCheck(long n)
        {
            string longToStr = n.ToString();

            //length check
            if (longToStr.Length == 12)
            {

                for (int i = 0; i < longToStr.Length - 1; i++)
                {
                    // same as previous digit check
                    if (longToStr[i] != longToStr[i + 1]) 
                    {
                        // sequential in ascending order check
                        if (longToStr[i + 1] != longToStr[i] + 1) // it will also compare the ASCII decimal value and char
                        {
                            return false;
                        }
                    }
                }

                return true;
            }

            return false;
        }


    }
}
