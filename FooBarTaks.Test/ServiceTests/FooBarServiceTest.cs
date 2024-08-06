using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBarTaks.Test.ServiceTests
{
    public class FooBarServiceTest
    {
        [Fact]
        public void FooBarService_ReturnFoo_WhenMultipleOf3()
        {
            var number = 9;
            var expected = "Foo";
            var service = new FooBarService();

            var result = service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FooBarService_ReturnFoo_WhenMultipleOf5()
        {
            var number = 10;
            var expected = "Bar";
            var service = new FooBarService();

            var result = service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FooBarService_ReturnFoo_WhenMultipleOf3and5()
        {
            var number = 15;
            var expected = "FooBar";
            var service = new FooBarService();

            var result = service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FooBarService_ReturnFoo_WhenNotMultipleOf3or5()
        {
            var number = 7;
            var expected = "7";
            var service = new FooBarService();

            var result = service.Transform(number);

            Assert.Equal(expected, result);
        }
    }
}