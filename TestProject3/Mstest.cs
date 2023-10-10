using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject3
{
    [TestClass]
		public class UnitTestClass_0
    {
        [TestMethod]
        public void TestMethod01()
        {
			Assert.AreEqual(1,2);
        }
			[TestMethod]
        public void TestMethod02()
        {
			Assert.AreEqual(1,1);
        }
		[TestMethod]
        public void TestMethod03()
        {
			Assert.AreEqual(1,2);
        }
        
        [DataTestMethod]
        [DataRow( "Aa", "gb")]
        [DataRow( "Xx", "Yfhkdf")]
        public void MSTestDataRowTestMethod0data(string str1, string str2)
        {
        }
    }
}
