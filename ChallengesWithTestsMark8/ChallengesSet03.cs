using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            // iterate through each element of the array
            for (int i = 0; i < vals.Length; i++)
            {
                // check if current element is false
                if (vals[i] == false)
                {
                    // return true that array contains false value
                    return true;
                }
            }

            // return false if array doesn't contain false value
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            // if 'numbers' collection is null or equal to 0
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            // calculate the sum of all numbers in 'numbers' collection
            var sum = numbers.Sum();

            // if sum of 'numbers' is odd, return true, otherwise false
            return (sum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            // checks if 'password' string is not null or empty
            if (!string.IsNullOrEmpty(password))
            {
                // initialized boolean values to false
                bool isUpper = false;
                bool isLower = false;
                bool isNumber = false;

                // iterate through length of 'password' string's elements
                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsUpper(password[i]))
                    {
                        isUpper = true;
                    }
                    else if (char.IsLower(password[i]))
                    {
                        isLower = true;
                    }
                    else if (char.IsNumber(password[i]))
                    {
                        isNumber = true;
                    }
                }

                // return true if all 3 conditions are found true
                return isUpper && isLower && isNumber;
            }

            // if 'password' string is null or empty, return false
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            // this method returns the first element of 'val'
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            // val.Length accesses index of last character
            // subtract 1 because of zero index
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            // check if divisor is zero
            if (divisor == 0)
            {
                // return 0 because of assumption in line 154 of ChallengesSet03Tests.cs
                return 0;
            }

            // if divisor not 0, do division, return answer
            return dividend / divisor;
        }

        // last element minus first element
        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            // initialize new list to store odd numbers
            List<int> odds = new List<int>();

            // iterate through numbers 1 to 99 (below 100)
            for (int i = 1; i < 100; i ++)
            {
                // if odd
                if (i % 2 != 0)
                {
                    // add to list
                    odds.Add(i);
                }
            }

            // convert list to array
            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            // iterate through each element in the array
            for (int i = 0; i < words.Length; i ++)
            {
                // convert current element to uppercase, update it in array
                words[i] = words[i].ToUpper();
            }
        }
    }
}