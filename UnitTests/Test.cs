using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestApp;

namespace UnitTests
{
    [TestFixture]
    class Test
    {
        [Test]
        [TestCase(2, 2, 4)]
        [TestCase(3, 2, 5)]
        [TestCase(3, 3, 6)]
        public void TestAddMethodCalculator(int num1, int num2, int expectedValue)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(num1, num2);

            Assert.AreEqual(result,expectedValue);
        }
    }
}
