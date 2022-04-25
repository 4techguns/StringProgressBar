using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringProgressBar;

namespace StringProgressBar.Tests
{
    [TestClass]
    public class ProgressTests
    {
        [TestMethod]
        public void FilledHalfTest()
        {
            Assert.AreEqual("■■■■■□□□□□", ProgressBar.FilledBar(5, 10, 10).ProgressString);
        }

        [TestMethod]
        public void FilledFullTest()
        {
            Assert.AreEqual("■■■■■■■■■■", ProgressBar.FilledBar(10, 10, 10).ProgressString);
        }

        [TestMethod]
        public void FilledNoneTest()
        {
            Assert.AreEqual("□□□□□□□□□□", ProgressBar.FilledBar(0, 10, 10).ProgressString);
        }

        [TestMethod]
        public void FilledQuarterTest()
        {
            Assert.AreEqual("■■□□□□□□□□", ProgressBar.FilledBar(2.5, 10, 10).ProgressString);
        }
    }
}