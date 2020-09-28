using Microsoft.VisualStudio.TestTools.UnitTesting;
using Izh_04_Basic_Coding;

namespace MSTestProject
{
    [TestClass]
    public class Izh_04_Basic_Coding_InsertNumber
    {
        [DataTestMethod]
        [DataRow(15, 15, 0, 0, 15)]
        [DataRow(8, 15, 0, 0, 9)]
        [DataRow(8, 15, 3, 8, 120)]
        public void TestInsertNumber(int x, int y, int i, int j, int result)
        {
            var v = new Izh04BasicCodingTests().InsertNumber(x, y, i, j);
            Assert.AreEqual(v, result);
        }
    }
}
