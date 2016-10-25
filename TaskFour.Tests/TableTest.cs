using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaskFour.Tests
{
    [TestClass]
    public class TableTest
    {
        Table<int> _table;

        [TestInitialize]
        public void Initialize()
        {
            // 1 4 7
            // 2 5 8
            // 3 6 9
            _table = new Table<int>(3, 3);

            _table[0, 0] = 1;
            _table[0, 1] = 2;
            _table[0, 2] = 3;

            _table[1, 0] = 4;
            _table[1, 1] = 5;
            _table[1, 2] = 6;

            _table[2, 0] = 7;
            _table[2, 1] = 8;
            _table[2, 2] = 9;
        }

        [TestMethod]
        public void IndexatorTest()
        {
            Assert.AreEqual(1, _table[0, 0]);
            Assert.AreEqual(2, _table[0, 1]);
            Assert.AreEqual(8, _table[2, 1]);
            Assert.AreEqual(9, _table[2, 2]);
        }

        [TestMethod]
        public void InsertEmptyRowTest()
        {
            _table.InsertEmptyRow(1);

            Assert.AreEqual(1, _table[0, 0]);
            Assert.AreEqual(4, _table[1, 0]);
            Assert.AreEqual(7, _table[2, 0]);

            Assert.AreEqual(0, _table[0, 1]);
            Assert.AreEqual(0, _table[1, 1]);
            Assert.AreEqual(0, _table[2, 1]);

            Assert.AreEqual(2, _table[0, 2]);
            Assert.AreEqual(5, _table[1, 2]);
            Assert.AreEqual(8, _table[2, 2]);
        }

        [TestMethod]
        public void InsertEmptyColumnTest()
        {
            _table.InsertEmptyColumn(1);

            Assert.AreEqual(1, _table[0, 0]);
            Assert.AreEqual(2, _table[0, 1]);
            Assert.AreEqual(3, _table[0, 2]);

            Assert.AreEqual(0, _table[1, 0]);
            Assert.AreEqual(0, _table[1, 1]);
            Assert.AreEqual(0, _table[1, 2]);

            Assert.AreEqual(7, _table[3, 0]);
            Assert.AreEqual(8, _table[3, 1]);
            Assert.AreEqual(9, _table[3, 2]);
        }
    }
}
