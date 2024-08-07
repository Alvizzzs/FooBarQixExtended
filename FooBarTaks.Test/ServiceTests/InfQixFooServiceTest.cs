using FooBarTask.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBarTask.Test.ServiceTests
{
    public class InfQixFooServiceTest
    {
        private readonly InfQixFooService _service;

        public InfQixFooServiceTest()
        {
            _service = new InfQixFooService();
        }

        //Test For Multiples
        [Fact]
        public void InfQixFooService_ReturnInf_WhenMultipleOf8()
        {
            var number = 16;
            var expected = "Inf";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void InfQixFooService_ReturnQix_WhenMultipleOf7()
        {
            var number = 14;
            var expected = "Qix";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void InfQixFooService_ReturnFoo_WhenMultipleOf3()
        {
            var number = 9;
            var expected = "Foo";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void InfQixFooService_ReturnInfQix_WhenMultipleOf8and7()
        {
            var number = 56;
            var expected = "Inf;Qix";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void InfQixFooService_ReturnInfFoo_WhenMultipleOf8and3()
        {
            var number = 24;
            var expected = "Inf;Foo";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void InfQixFooService_ReturnQixFoo_WhenMultipleOf7and3()
        {
            var number = 21;
            var expected = "Qix;Foo";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void InfQixFooService_ReturnInfQixFoo_WhenMultipleOf8And7And3()
        {
            var number = 168;
            var expected = "Inf;Qix;Foo;Inf";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void InfQixFooService_ReturnNumberAsString_WhenNotMultipleOrOccurrence()
        {
            var number = 1;
            var expected = "1";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        //Test For Digit Occurances
        [Fact]
        public void InfQixFooService_ReturnInf_WhenNumberContains8()
        {
            var number = 28;
            var expected = "Inf";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void InfQixFooService_ReturnQix_WhenNumberContains7()
        {
            var number = 27;
            var expected = "Qix";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void InfQixFooService_ReturnFoo_WhenNumberContains3()
        {
            var number = 13;
            var expected = "Foo";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void InfQixFooService_ReturnInfQix_WhenNumberContains8and7()
        {
            var number = 87;
            var expected = "InfQix";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void InfQixFooService_ReturnInfFoo_WhenNumberContain8and3()
        {
            var number = 83;
            var expected = "InfFoo";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void InfQixFooService_ReturnQixFoo_WhenNumberContains7and3()
        {
            var number = 37;
            var expected = "QixFoo";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }

        // Test for both multiples and digit occurrences
        [Fact]
        public void InfQixFooService_ReturnFooInfQixFoo_WhenMultipleAndContains()
        {
            var number = 378;
            var expected = "Foo;InfQixFoo";

            var result = _service.Transform(number);

            Assert.Equal(expected, result);
        }
    }
}
