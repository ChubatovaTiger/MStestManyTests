using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject3
{
    [TestClass]
    public class UnitTestClass_0
    {
        [TestMethod]
        public void TestMethod0()
        {
        }
        
        [DataTestMethod]
        [DataRow( "Aa", "gb")]
        [DataRow( "Xx", "Yfhkdf")]
        public void MSTestDataRowTestMethod0(string str1, string str2)
        {
        }
    }
}
