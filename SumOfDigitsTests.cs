using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sum_of_Digits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Digits.Tests
{
    [TestClass()]
    public class NumberTests
    {
        [TestMethod()]
        public void DigitalRootTest()
        {
            var num = new Number();
            // test one digit
            Assert.AreEqual(9, num.DigitalRoot(9));
            // test many digits
            Assert.AreEqual(7, num.DigitalRoot(16));
            // test many digits sum over 9
            Assert.AreEqual(6, num.DigitalRoot(456));
            // test int max
            Assert.AreEqual(1, num.DigitalRoot(2147483647));
            // test long
            Assert.AreEqual(3, num.DigitalRoot(3333333333));
            // test long max
            Assert.AreEqual(7, num.DigitalRoot(9223372036854775807));
        }
    }
}