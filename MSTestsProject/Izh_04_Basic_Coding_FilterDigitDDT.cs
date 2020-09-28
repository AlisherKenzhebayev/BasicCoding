using Microsoft.VisualStudio.TestTools.UnitTesting;
using Izh_04_Basic_Coding;
using System;

namespace MSTestProject
{
    [TestClass]
    public class Izh_04_Basic_Coding_FilterDigitDDT
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [DeploymentItem("MSTestsProject\\XML_FilterDigit.xml")]
        [DataSource("MyExcelDataSource")]
        [TestMethod()]
        public void TestInsertNumber()
        {
            int x = Convert.ToInt32(TestContext.DataRow["A1"]);
            int y = Convert.ToInt32(TestContext.DataRow["A2"]);
            int i = Convert.ToInt32(TestContext.DataRow["A3"]);
            int j = Convert.ToInt32(TestContext.DataRow["A4"]);
            int result = Int32.Parse((string)TestContext.DataRow["Result"]);

            var v = new Izh04BasicCodingTests().InsertNumber(x, y, i, j);
            Assert.AreEqual(v, result);
        }
    }
}
