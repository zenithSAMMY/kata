using Microsoft.VisualStudio.TestTools.UnitTesting;
using Duplicate_Encoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// if Duplicate char in string, Encode to ")"
// if unique, Encode to "("

namespace Duplicate_Encoder.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void DuplicateEncodeTest_all_different_char()
        {
            // all different char
            Assert.AreEqual("(((((", Kata.DuplicateEncode("dinas"));
            // all the duplicate char
            Assert.AreEqual(")))))", Kata.DuplicateEncode("ddddd"));
            //some duplicate char some unique
            Assert.AreEqual(")())()))", Kata.DuplicateEncode("asdawdad"));
            //test for different letter case
            Assert.AreEqual(")())()))", Kata.DuplicateEncode("ASDawdad"));
            //test for symbol
            Assert.AreEqual("))(()()", Kata.DuplicateEncode("@ =+@/ "));
            //test for number
            Assert.AreEqual(")))()((((((()", Kata.DuplicateEncode("1312309876543"));
        }
    }
}