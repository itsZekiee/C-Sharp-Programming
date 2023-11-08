using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenge_One_Validation
{
    internal class SignClass
    {
        public string detSignValue(int number)
        {
            if (number > 0)
            {
                return (number % 2 == 0) ? "Positive-even number" : "Positive-odd number";
            }
            else if (number < 0)
            {
                return (number % 2 == 0) ? "Negative-even number" : "Negative-odd number";
            }
            else
            {
                return "Zero";
            }
        }
    }
}
