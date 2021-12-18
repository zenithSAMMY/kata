using Microsoft.VisualStudio.TestTools.UnitTesting;
using Find_the_divisors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_divisors.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void DivisorsTest()
        {
            // zero divisor
            Assert.AreEqual(null, Kata.Divisors(13));
            // one divisor
            CollectionAssert.AreEqual(new int[] { 5 }, Kata.Divisors(25));
            // // // two prime numbers divisors
            CollectionAssert.AreEqual(new int[] { 11, 23 }, Kata.Divisors(253));
            // // many divisors
            CollectionAssert.AreEqual(new int[] { 2, 3, 4, 6, 8, 12 }, Kata.Divisors(24));
        }
    }
}