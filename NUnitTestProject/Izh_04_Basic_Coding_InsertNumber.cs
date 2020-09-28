// <copyright file="Izh_04_Basic_Coding_InsertNumber.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace NUnitTestProject
{
    using Izh_04_Basic_Coding;
    using NUnit.Framework;

    [TestFixture]
    public class Izh_04_Basic_Coding_InsertNumber
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(15, 15, 0, 0, ExpectedResult = 15)]
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(8, 15, 3, 8, ExpectedResult = 120)]
        public int TestInsertNumber(int x, int y, int i, int j)
        {
            var v = new Izh04BasicCodingTests().InsertNumber(x, y, i, j);
            return v;
        }
    }
}
