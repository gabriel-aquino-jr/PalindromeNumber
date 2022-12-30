using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            string strNum = x.ToString();
            int compareIndexLimit = 0;

            // if there is only 1 digit, it's true! :)
            if (strNum.Length == 1)
                return true;

            if (strNum.Length % 2 == 0)
                // if number of digits is even, set the comparison index limit to half of the lenght
                compareIndexLimit = strNum.Length / 2;
            else
                // if number of digits is odd, set the comparison index limit to half -1 of the lenght
                // because the digit in the middle doesn't need to be compared
                compareIndexLimit = (strNum.Length-1) / 2;

            int j = strNum.Length - 1;
            for (int i = 0; i < compareIndexLimit; i++)
            {
                if (strNum[i] != strNum[j]) return false;
                j--;
            }

            return true;
        }
    }
}
