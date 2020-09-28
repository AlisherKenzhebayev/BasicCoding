// <copyright file="Izh_04_Basic_Coding_FindNextBiggerNumber.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace NUnitTestProject
{
    using System;
    using Izh_04_Basic_Coding;
    using NUnit.Framework;

    [TestFixture]
    public class Izh_04_Basic_Coding_FindNextBiggerNumber
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(12, ExpectedResult = 21)]
        [TestCase(513, ExpectedResult = 531)]
        [TestCase(2017, ExpectedResult = 2071)]
        [TestCase(414, ExpectedResult = 441)]
        [TestCase(144, ExpectedResult = 414)]
        [TestCase(1234321, ExpectedResult = 1241233)]
        [TestCase(1234126, ExpectedResult = 1234162)]
        [TestCase(3456432, ExpectedResult = 3462345)]
        [TestCase(10, ExpectedResult = -1)]
        [TestCase(20, ExpectedResult = -1)]
        public int TestFindNextBiggerNumber(int x)
        {
            var v = new Izh04BasicCodingTests().FindNextBiggerNumber(x);
            return v;
        }

        [TestCase(1234321, true, 1241233)]
        [TestCase(513, false, 531)]
        public void TestFindNextBiggerNumber(int x, bool requestTime, int retval)
        {
            Tuple<int, TimeSpan?> v = new Izh04BasicCodingTests().FindNextBiggerNumber(x, requestTime);
            Assert.AreEqual(v.Item1, retval);
        }
    }
}
