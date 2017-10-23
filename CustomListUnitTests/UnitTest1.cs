using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTests
{
    [TestClass]
    public class UnitTest1 
    {


        [TestMethod]
        public void AddPositiveInt()
        {
            Marbles<int> marbInt = new Marbles<int>();
            int input = 5;
            marbInt.Add(input);
            //assert 
            Assert.AreEqual(marbInt[0], input);
        }
        [TestMethod]
        public void AddString()
        {
            Marbles<string> marbInt = new Marbles<string>();
            string input = "5";
            marbInt.Add(input);
            //assert
            Assert.AreEqual(marbInt[0], input);
        }
        [TestMethod]
        public void AddBool()
        {
            Marbles<bool> marbInt = new Marbles<bool>();
            bool input = true;
            marbInt.Add(input);
            //assert
            Assert.AreEqual(marbInt[0], input);
        }
        [TestMethod]
        public void AddNegativeInt()
        {
            Marbles<int> marbInt = new Marbles<int>();
            int input = -5;
            marbInt.Add(input);
            //assert
            Assert.AreEqual(marbInt[0], input);
        }
        [TestMethod]
        public void AddDouble()
        { 
            Marbles<double> marbInt = new Marbles<double>();
            double input = 5.55;
            marbInt.Add(input);
            //assert
            Assert.AreEqual(marbInt[0], input);
        }
        [TestMethod]
        public void AddList()
        {
            //ExtraList<ExtraList<int>> foo = new ExtraList<ExtraList<int>>();
            //ExtraList<int> intList = new ExtraList<int>();
            Marbles<int> intList = new Marbles<int>();
            Marbles<Marbles<int>> marbInt = new Marbles<Marbles<int>>();
            intList.Add(1);
            marbInt.Add(intList);
            //assert
            Assert.AreEqual(marbInt[0], 1);
        }
        [TestMethod]
        public void AddNegativeDouble()
        {
            Marbles<double> marbInt = new Marbles<double>();
            double input = -5.55;
            marbInt.Add(input);
            //assert
            Assert.AreEqual(marbInt[0], input);
        }
        [TestMethod]
        public void ConfirmListOrderIndex0()
        {
            Marbles<double> marbInt = new Marbles<double>();
            double input1 = 1;
            double input2 = 2;
            double input3 = 3;
            double input4 = 4;
            marbInt.Add(input1);
            marbInt.Add(input2);
            marbInt.Add(input3);
            marbInt.Add(input4);
            //assert
            Assert.AreEqual(marbInt[0], input1);
        }
        public void ConfirmListOrderIndex1()
        {
            Marbles<double> marbInt = new Marbles<double>();
            double input1 = 1;
            double input2 = 2;
            double input3 = 3;
            double input4 = 4;
            marbInt.Add(input1);
            marbInt.Add(input2);
            marbInt.Add(input3);
            marbInt.Add(input4);
            //assert
            Assert.AreEqual(marbInt[1], input2);
        }
        public void ConfirmListOrderIndex2()
        {
            Marbles<double> marbInt = new Marbles<double>();
            double input1 = 1;
            double input2 = 2;
            double input3 = 3;
            double input4 = 4;
            marbInt.Add(input1);
            marbInt.Add(input2);
            marbInt.Add(input3);
            marbInt.Add(input4);
            //assert
            Assert.AreEqual(marbInt[2], input3);
        }
        public void ConfirmListOrderIndex3()
        {
            Marbles<double> marbInt = new Marbles<double>();
            double input1 = 1;
            double input2 = 2;
            double input3 = 3;
            double input4 = 4;
            marbInt.Add(input1);
            marbInt.Add(input2);
            marbInt.Add(input3);
            marbInt.Add(input4);
            //assert
            Assert.AreEqual(marbInt[3], input4);
        }
    }
}

