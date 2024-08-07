using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBarTask.Services
{
    public class InfQixFooService
    {
        public string Transform(int number)
        {
            string result = string.Empty;
            if (number % 8 == 0)
            {
                result += "Inf;";
            }
            if (number % 7 == 0)
            {
                result += "Qix;";
            }
            if (number % 3 == 0)
            {
                result += "Foo;";
            }

            string numberString = number.ToString();
            foreach (char digit in numberString)
            {
                if (digit == '3')
                {
                    result += "Foo";
                }
                else if (digit == '8')
                {
                    result += "Inf";
                }
                else if (digit == '7')
                {
                    result += "Qix";
                }
            }

            int digitSum = numberString.Select(n => int.Parse(n.ToString())).Sum();
            if (digitSum % 8 == 0)
            {
                result += "Inf";
            }

            if (result.EndsWith(";"))
            {
                result = result.TrimEnd(';');
            }

            return string.IsNullOrEmpty(result) ? numberString : result;
        }
    }
}
