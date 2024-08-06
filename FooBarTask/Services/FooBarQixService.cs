using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBarTask.Services
{
    public class FooBarQixService
    {
        public string Transform(int number)
        {
            string result = string.Empty;

            if (number % 3 == 0)
            {
                result += "Foo";
            }
            if (number % 5 == 0)
            {
                result += "Bar";
            }
            if (number % 7 == 0)
            {
                result += "Qix";
            }

            return string.IsNullOrEmpty(result) ? number.ToString() : result;
        }
    }
}
