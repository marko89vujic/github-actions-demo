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
        public void TestAddMethodCalculator()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(2, 2);

            Assert.AreEqual(result,4);
        }
    }
}
