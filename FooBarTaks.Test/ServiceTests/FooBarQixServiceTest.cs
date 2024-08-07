using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FooBarTask.Services;

namespace FooBarTaks.Test.ServiceTests
{
    public class FooBarQixServiceTest
    {
        private readonly FooBarQixService _service;

        public FooBarQixServiceTest()
        {
            _service = new FooBarQixService();
        }

        //Test For Multiples
        [Fact]
        public void FooBarService_ReturnFoo_WhenMultipleOf3()
        {
            var number = 9;
            var expected = "Foo";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FooBarService_ReturnBar_WhenMultipleOf5()
        {
            var number = 10;
            var expected = "Bar";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FooBarService_ReturnFooBar_WhenMultipleOf3and5()
        {
            var number = 15;
            var expected = "FooBarBar";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FooBarService_ReturnQix_WhenMultipleOf7()
        {
            var number = 7;
            var expected = "QixQix";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FooBarService_ReturnFooQix_WhenMultipleOf3and7()
        {
            var number = 21;
            var expected = "FooQix";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FooBarService_ReturnBarQix_WhenMultipleOf5and7()
        {
            var number = 140;
            var expected = "BarQix";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FooBarService_ReturnFooBarQix_WhenMultipleOf3and5and7()
        {
            var number = 105;
            var expected = "FooBarQixBar";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        //Test For Digit Occurances
        [Fact]
        public void FooBarService_ReturnFoo_WhenNumberContains3()
        {
            var number = 13;
            var expected = "Foo";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FooBarService_ReturnBar_WhenNumberContains5()
        {
            var number = 52;
            var expected = "Bar";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FooBarService_ReturnQix_WhenNumberContains7()
        {
            var number = 71;
            var expected = "Qix";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FooBarService_ReturnFooBar_WhenNumberContains3and5()
        {
            var number = 35;
            var expected = "BarQixFooBar";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FooBarService_ReturnFooQix_WhenNumberContains3and7()
        {
            var number = 37;
            var expected = "FooQix";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FooBarQixService_ReturnBarQix_WhenNumberContains5and7()
        {
            var number = 57;
            var expected = "FooBarQix";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        // Test For No Digit Occurances or Multiples
        [Fact]
        public void FooBarService_ReturnNumberAsString_WhenNotMultipleOrOccurance()
        {
            var number = 1;
            var expected = "1";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

    }
}