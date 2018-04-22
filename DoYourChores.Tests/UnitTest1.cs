using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoYourChores.WebJob;

namespace DoYourChores.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeadlineIsNotNull()
        {
            var deadline = CheckCatBox.GetDeadline();
            Assert.IsNotNull(deadline);
        }
    }
}
