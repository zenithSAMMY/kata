using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bit_Counting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Counting.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void CountBitsTest()
        {
            // test for 0
            Assert.AreEqual(0, Kata.CountBits(0));
            // test for little number
            Assert.AreEqual(5, Kata.CountBits(31));
            // test for big number
            Assert.AreEqual(15, Kata.CountBits(115370965));
            //test for int max 
            Assert.AreEqual(31, Kata.CountBits(2147483647));
        }
    }
}