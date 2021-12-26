using Microsoft.VisualStudio.TestTools.UnitTesting;
using Build_a_pile_of_Cubes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_a_pile_of_Cubes.Tests
{
    [TestClass()]
    public class ASumTests
    {
        [TestMethod()]
        public void findNbTest()
        {
            // 1 digit
            Assert.AreEqual(5, ASum.findNb(225));
            Assert.AreEqual(-1, ASum.findNb(226));
            // 2 digits
            Assert.AreEqual(17, ASum.findNb(23409));
            Assert.AreEqual(-1, ASum.findNb(23410));
            // 3 digits
            Assert.AreEqual(123, ASum.findNb(58155876));
            Assert.AreEqual(-1, ASum.findNb(58155877));
            // 4 digits
            Assert.AreEqual(2022, ASum.findNb(4183059834009));
            Assert.AreEqual(-1, ASum.findNb(4183059834010));
            // 5 digits
            Assert.AreEqual(55100, ASum.findNb(2304422822859502500));
            Assert.AreEqual(-1, ASum.findNb(2304422822859502501)); 
            //near long edge case
            Assert.AreEqual(77777, ASum.findNb(9148627114713081009));
            Assert.AreEqual(-1, ASum.findNb(9148627114713081010));
        }
    }
}