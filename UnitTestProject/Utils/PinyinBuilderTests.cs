using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZeroRoo.Utils;

namespace UnitTestProject
{
    [TestClass]
    public class PinyinBuilderTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            PinYinBuilder builder = new PinYinBuilder();
            var pinyin = builder.GetHanz2PinYinFirst("卢");
            Assert.AreEqual("L", pinyin);
        }
    }
}
