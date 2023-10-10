using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject3
{
    [TestClass]
    public class UnitTestClass_0
    {
        [TestMethod]
        public void TestMethod01()
        {
        }
		[TestMethod]
        public void TestMethod02()
        {
        }
		[TestMethod]
        public void TestMethod03()
        {
        }
        
        [DataTestMethod]
        [DataRow( "Aa", "gb")]
        [DataRow( "Xx", "Yfhkdf")]
        public void MSTestDataRowTestMethod0data(string str1, string str2)
        {
        }
    }
}
