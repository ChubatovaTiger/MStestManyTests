using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject3
{
    [TestClass]
    public class UnitTest1_pr3
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
