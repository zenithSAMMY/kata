using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    [TestClass()]
    public class KataTests
    {
        int[] Test1 = new int[] { 0, 0, 0, 0 };
        int[] Test2 = new int[] { 1, 1, 1, 1 };
        int[] Test3 = new int[] { 0, 1, 1, 0 };
        int[] Test4 = new int[] { 0, 1, 0, 1 };
        private Kata kata = new Kata();
        [TestMethod()]
        public void BinaryArrayToNumberTest()
        {
            Assert.AreEqual(0, kata.BinaryArrayToNumber(Test1));
            Assert.AreEqual(15, kata.BinaryArrayToNumber(Test2));
            Assert.AreEqual(6, kata.BinaryArrayToNumber(Test3));
            Assert.AreEqual(5, kata.BinaryArrayToNumber(Test4));
        }
    }
}