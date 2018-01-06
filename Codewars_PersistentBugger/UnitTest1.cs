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

        [TestMethod]
        public void Input_28_Should_Be_2()
        {
            Assert.AreEqual(2, Persist.Persistence(28));
        }

        [TestMethod]
        public void Input_39_Should_Be_3()
        {
            Assert.AreEqual(3,Persist.Persistence(39));
        }

        [TestMethod]
        public void Input_999_Should_Be_4()
        {
            Assert.AreEqual(4,Persist.Persistence(999));
        }

        [TestMethod]
        public void Input_25_Should_Be_2()
        {
            Assert.AreEqual(2,Persist.Persistence(25));
        }

    }

    public class Persist
    {
        public static int Persistence(long n)
        {
            var result = 0;
            while (n > 9)
            {
                n = DigitMutiply(n);
                result++;
            }
            return result;
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
