using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_PersistentBugger
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_0_Should_Be_0()
        {
            Assert.AreEqual(0, Persist.Persistence(0));
        }

        [TestMethod]
        public void Mutiply_Input_0_Should_Be_0()
        {
            Assert.AreEqual(0, Persist.DigitMutiply(0));
        }

        [TestMethod]
        public void DigitMutiply_Input_1_Should_Be_1()
        {
            Assert.AreEqual(1, Persist.DigitMutiply(1));
        }

        [TestMethod]
        public void DigitMutiply_Input_11_Should_Be_1()
        {
            Assert.AreEqual(1, Persist.DigitMutiply(11));
        }

        [TestMethod]
        public void DigitMutiply_Input_23_Should_Be_6()
        {
            Assert.AreEqual(6, Persist.DigitMutiply(23));
        }

        [TestMethod]
        public void DigitMutiply_Input_123_Should_Be_6()
        {
            Assert.AreEqual(6, Persist.DigitMutiply(123));
        }

        [TestMethod]
        public void Input_11_Should_Be_1()
        {
            Assert.AreEqual(1, Persist.Persistence(11));
        }

    }

    public class Persist
    {
        public static int Persistence(long n)
        {
            return 0;
        }

        public static int DigitMutiply(long n)
        {
            var result = Convert.ToInt32(n.ToString()[0].ToString());
            for (int i = 1; i < n.ToString().Length; i++)
            {
                result *= Convert.ToInt32(n.ToString()[i].ToString());
            }
            return result;
        }
    }
}
