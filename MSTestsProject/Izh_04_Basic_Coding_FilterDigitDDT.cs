using Microsoft.VisualStudio.TestTools.UnitTesting;
using Izh_04_Basic_Coding;
using System;
using System.Xml;
using System.Linq;
using System.IO;
using System.Xml.Linq;

namespace MSTestProject
{
    [TestClass]
    public class Izh_04_Basic_Coding_FilterDigitDDT
    {
        public TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "XML_FilterDigit.xml", "Digit", DataAccessMethod.Sequential)]
        [TestMethod()]
        public void TestFilterDigit()
        {
            string input = (string)TestContext.DataRow["array"];
            string[] tokens = input.Split(',');
            int[] array = Array.ConvertAll<string, int>(tokens, int.Parse);
            int digit = Int32.Parse((string)TestContext.DataRow["digit"]);
            string input2 = (string)TestContext.DataRow["result"];
            string[] tokens2 = input2.Split(',');
            int[] result = Array.ConvertAll<string, int>(tokens2, int.Parse);

            var v = new Izh04BasicCodingTests().CheckDigitFiltering(array, digit);
            Assert.IsTrue(Enumerable.SequenceEqual(v, result), "Not Equals");
        }
    }
}
