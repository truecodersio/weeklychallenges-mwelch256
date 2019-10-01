using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool answer = false;
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    answer = true;
                }
            }
            return answer;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
                return false;
            int numbersSum = numbers.Sum();
            if (numbersSum % 2 != 0)
                return true;
            else
                return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool answer = false;
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber))
            {
                answer = true;
            }
            return answer;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            decimal num1 = dividend / divisor;
            return num1;
        }

        public int LastMinusFirst(int[] nums)
        {
            int last = nums.Length - 1;
            return nums[last] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] MyArray = new int[50];
            int i = 0;
            for (int odd = 1; odd < 100; odd += 2)
            {
                {
                    MyArray[i] = odd;
                    i++;
                }
            }
            return MyArray;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++) 
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
