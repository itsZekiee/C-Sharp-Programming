using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenge_One_Validation
{
    internal class ValidationClass
    {
        public bool isEmptyValue(string input)
        {
            // Check if the input is empty
            return string.IsNullOrWhiteSpace(input);
        }

        public bool isNonNumericValue(string input)
        {
            // Check if the input contains non-numeric characters
            foreach (char c in input)
            {
                if (!char.IsDigit(c) && c != '-')
                {
                    return true;
                }
            }
            return false;
        }

        public bool isNonIntegerValue(string input)
        {
            // Check if the input contains decimal points
            if (input.Contains("."))
            {
                return true;
            }
            return false;
        }
    }
}
