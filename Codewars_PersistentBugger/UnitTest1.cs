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
    }

    public class Persist
    {
        public static int Persistence(int n)
        {
            return 0;
        }
    }
}
