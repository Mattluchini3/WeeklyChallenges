using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            //need to add all the even numbers in the array
            //then we need to subtract all the odd numbers
            //I would iterate through the list to find all the even numbers and add them all together
            //then do the same with the odd numbers
            //then take the even subtract the odd all together
            //.where filters through the list
            //.sum adds it all together

            return numbers.Where(num => num % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //find the shortest string
            //make a temp variable to get strings parse to int to test the length
            var temp = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };
            return temp.Min();//.Min will return the smallest string 
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            //we are dealing with numbers so it would be the same as above because they are
            //already integers but they need a list to iterate through 
            var list = new List<int>() { number1, number2, number3, number4 };
            return list.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
            //.Name set equal to TrueCoders 
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            //a triangle can have three matching side lengths
            //
            return sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1;
        }

        public bool IsStringANumber(string input)
        {
            var isANumber = double.TryParse(input, out double number);
            return isANumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length;
            var Majority = (amount / 2) + 1;

            var count = 0;

            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    count++;
                }

            }
            if (count >= Majority)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            double sum = 0;
            double count = 0;

            if (numbers == null)
            {
                return 0;
            }

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                    count++;
                }
            }


            if (count > 0)
            {
                return sum / count;
            }
            else
            {
                return 0;
            }
        }

        public int Factorial(int number)
        {
            var fact = 1;
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = number; i > 0; i--)
            {
                fact *= i;
            }
            return fact;
        }
    }
}