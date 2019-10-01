using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {

            if (char.IsLetter(c))
            {
                return true;
            }
            else
            {
                return false;
            }
          
        }


        public bool CountOfElementsIsEven(string[] vals)
        {
           if (vals.Length % 2 == 0)
            {
                return true;

            }
           else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {


            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;

            }
            
           
        }

        public bool IsNumberOdd(int num)
        {

            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
                return str2.Length;
        }

        public int Sum(int[] numbers)
        {

            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            int num = 0;
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Count() == 0)
            {
                return 0;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    num += numbers[i];
                }
            }
            return num;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
                return false;
            int numbersSum = numbers.Sum();
            if (numbersSum % 2 != 0)
                return true;
            else
                return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long oddcount = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    oddcount++;
                }
            }
            return oddcount;
        }
    }
}
