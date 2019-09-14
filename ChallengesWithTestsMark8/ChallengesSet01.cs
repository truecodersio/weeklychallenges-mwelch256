using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {


            if (num1 == num2)
            {
                return true;
            }
            
            else
            {
                return false;
            }

        }


        public double Subtract(double minuend, double subtrahend)
        {
         
            double ans = minuend - subtrahend;

            return ans;
        }

        public int Add(int number1, int number2)
        {
            int ans = number1 + number2;

            return ans;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }

        }

        public long Multiply(long factor1, long factor2)
        {
            long ans = factor1 * factor2;

            return ans;
        }

        public string GetGreeting(string nameOfPerson)
        {
           
            
            return nameOfPerson == "" ?  "Hello!" : $"Hello, {nameOfPerson}!" ; 

            
        }

        public string GetHey()
        {

            string x = "HEY!";
            string j = "JugaThen";
            return x + j;
        }
    }
}
