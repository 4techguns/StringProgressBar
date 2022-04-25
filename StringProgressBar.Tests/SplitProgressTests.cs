using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringProgressBar;

namespace StringProgressBar.Tests
{
    [TestClass]
    public class SplitProgressTests
    {
        [TestMethod]
        public void OneTest()
        {
            Assert.AreEqual("•▬▬▬▬▬▬▬▬▬", ProgressBar.SplitBar(1, 10, 10).ProgressString);
        }

        [TestMethod]
        public void HalfTest()
        {
            Assert.AreEqual("▬▬▬▬•▬▬▬▬▬", ProgressBar.SplitBar(5, 10, 10).ProgressString);
        }

        [TestMethod]
        public void FullTest()
        {
            Assert.AreEqual("▬▬▬▬▬▬▬▬▬•", ProgressBar.SplitBar(10, 10, 10).ProgressString);
        }
    }
}