using System;
using NUnit.Framework;
using ZeroRoo.Utils;

namespace UnitTestProject
{
    [TestFixture]
    public class PinyinBuilderTests
    {
        [Test()]
        public void TestMethod1()
        {
            PinYinBuilder builder = new PinYinBuilder();
            var pinyin = builder.GetHanz2PinYinFirst("卢");
            Assert.AreEqual("L", pinyin);
        }
    }
}
