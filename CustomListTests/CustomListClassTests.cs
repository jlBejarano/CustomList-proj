using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTests
{
    [TestClass]
    public class CustomListClassTests
    {
        [TestMethod]
        public void AddOne_CheckCountOne()
        {
            //arange
            MyList<int> myList = new MyList<int>();
            int expected = 1;
            int actual;

            //act
            myList.Add(1);
            actual = myList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTwo_CheckCountTwo()
        {
            MyList<int> myList = new MyList<int>();
            int expected = 2;
            int actual;

            myList.Add(1);
            myList.Add(2);
            actual = myList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddThree_CheckCountThree()
        {
            MyList<int> myList = new MyList<int>();
            int expected = 3;
            int actual;

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            actual = myList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddFour_CheckCountFour()
        {
            MyList<int> myList = new MyList<int>();
            int expected = 4;
            int actual;

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            actual = myList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddFive_CheckCountFive()
        {
            MyList<int> myList = new MyList<int>();
            int expected = 5;
            int actual;

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            actual = myList.Count;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void AddOne_CheckIndexZero()
        {
            //arange
            MyList<int> myList = new MyList<int>();
            int expected = 1;
            int actual;

            //act
            myList.Add(1);
            actual = myList[0];
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTwo_CheckIndexOne()
        {
            MyList<int> myList = new MyList<int>();
            int expected = 2;
            int actual;

            myList.Add(1);
            myList.Add(2);
            actual = myList[1];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddThree_CheckIndexThree()
        {
            MyList<int> myList = new MyList<int>();
            int expected = 3;
            int actual;

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            actual = myList[2];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddFive_CheckIndexFour()
        {
            MyList<int> myList = new MyList<int>();
            int expected = 5;
            int actual;

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            actual = myList[4];

            Assert.AreEqual(expected, actual);
        }


    }
}
