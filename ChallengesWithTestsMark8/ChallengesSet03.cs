using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {

            for (int i = 0; i <= vals.Length - 1; i++)
            {
                //conditional statements
                if (vals[i] == false)//index i 
                {
                    return true;//this is inside the for loop
                }

            }
            return false;//need a return type inside the method 
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            var sumOfOdds = numbers.Where(x => x % 2 != 0).ToList().Sum();
            //LINQ where is filtering the odds out(things i want to work with), then printing to a list, and now adding the sum of the list 
            if (sumOfOdds % 2 != 0)// is finding if the sum of the odds is odd it will return true 
            {
                return true;

            }
            return false;// if it is even it returns false 

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var isUpper = false;
            var isLower = false;
            var isNumber = false;//this is to say any variable that does not have number,lower or upper will be false

            for (int i = 0; i <= password.Length - 1; i++)
            {
                if (char.IsUpper(password[i]))//character is uppercase method passing through password index 
                {
                    isUpper = true;
                }
                if (char.IsLower(password[i]))
                {
                    isLower = true;
                }
                if (char.IsNumber(password[i]))
                {
                    isNumber = true;
                }

            }
            if (isUpper == true && isLower == true && isNumber == true)// now if all these statements are true at the same time then you can return true
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public char GetFirstLetterOfString(string val)
        {
            //for every word in the string print the first letter only
            //tried foreach loop and failed...

            return val.First();//.First method will print the first item 


        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];//like above but has to add the count 
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            //take dividend and divide by divisor for each item
            if (divisor == 0)
            {
                return 0;
            }

            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            //for index at 0 and index at last subtract them
            return nums[nums.Length - 1] - nums[0];

        }

        public int[] GetOddsBelow100()
        {
            //iterate through the list and return only odds below 100
            //odd would be % 2 != 0 and i is > 100
            //need a list to go through
            var list = new List<int>();

            for (var i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);//if integer is odd add it to the new list 
                }

            }
            return list.ToArray();//change the list to an array 

        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            //this is asking to change each element of the word to uppercase
            for (int i = 0; i <= words.Length - 1; i++)
            {
                words[i] = words[i].ToUpper();//use method to upper for each index in words 
            }

        }
    }
}
