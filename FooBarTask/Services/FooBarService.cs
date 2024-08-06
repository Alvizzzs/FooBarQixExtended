using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBarTask.Services
{
    public class FooBarService
    {
        public string Transform(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FooBar";
            }
            else if (number % 3 == 0)
            {
                return "Foo";
            }
            else if (number % 5 == 0)
            {
                return "Bar";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}
