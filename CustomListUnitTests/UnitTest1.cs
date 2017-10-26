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
            Marbles<int> intList = new Marbles<int>();
            Marbles<Marbles<int>> marbInt = new Marbles<Marbles<int>>();
            marbInt.Add(intList);
            //assert
            Assert.AreEqual(intList, marbInt[0]);
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
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
        public void RemoveInt()
        {
            Marbles<int> list = new Marbles<int>() { 1, 2, 3 };
            int input = 2;
            list.Remove(input);
            //assert
            Assert.AreEqual(list[1], 3);
        }
        [TestMethod]
        public void RemoveIntFalseReturn()
        {
            Marbles<int> list = new Marbles<int>() { 1, 2, 3 };
            int input = 4;
            bool result = list.Remove(input);
            //assert
            Assert.AreNotEqual(result, true);
        }
            
        [TestMethod]
        public void RemoveDouble()
        {
            Marbles<double> list = new Marbles<double>() { 1.1, 2.2, 3.3 };
            double input = 2.2;
            list.Remove(input);
            //assert
            Assert.AreEqual(list[1], 3.3);
        }
        [TestMethod]
        public void RemoveString()
        {
            Marbles<string> list = new Marbles<string>() { "apple", "banana", "mango" };
            string input = "banana";
            list.Remove(input);
            //assert
            Assert.AreEqual(list[1], "mango");
        }
        [TestMethod]
        public void RemoveNegativeint()
        {
            Marbles<int> list = new Marbles<int>() { -1, -2, -3 };
            int input = -2;
            list.Remove(input);
            //assert
            Assert.AreEqual(list[1], -3);
        }
        [TestMethod]
        public void RemoveBool()
        {
            Marbles<bool> list = new Marbles<bool>() { true, false, true };
            bool input = false;
            list.Remove(input);
            //assert
            Assert.AreEqual(list[1], true);
        }
        [TestMethod]
        public void RemoveList()
        {
            Marbles<int> list1 = new Marbles<int>() { 1, 2, 3 };
            Marbles<int> list2 = new Marbles<int>() { 4, 5, 6 };
            Marbles<int> list3 = new Marbles<int>() { 7, 8, 9 };
            Marbles<Marbles<int>> listOfLists = new Marbles<Marbles<int>>() { list1, list2, list3 };
            Marbles<int> input = list2;
            listOfLists.Remove(input);
            //assert
            Assert.AreEqual(listOfLists[1], list3);
        }
        [TestMethod]
        public void ToStringInt()
        {
            Marbles<int> list = new Marbles<int>();
            list.Add(4);
            list.Add(5);
            int input = 5;
            list.ToString();
            //assert
            Assert.AreEqual(list[1], input);
        }
        [TestMethod]
        public void ToStringBool()
        {
            Marbles<bool> list = new Marbles<bool>();
            list.Add(false);
            list.Add(false);
            bool input = false;
            list.ToString();
            //assert
            Assert.AreEqual(list[0], input);
        }
        [TestMethod]
        public void ToStringString()
        {
            Marbles<string> list = new Marbles<string>();
            list.Add("banana");
            list.Add("mango");
            string input = "mango";
            list.ToString();
            //assert
            Assert.AreEqual(list[1], input);
        }
        [TestMethod]
        public void ToStringList()
        {
            Marbles<double> list1 = new Marbles<double>() { 1, 2, 3, 4, 5, };
            Marbles<Marbles<double>> list2 = new Marbles<Marbles<double>>();
            string expectedBanana = "12345";
            list2.Add(list1);
            string banana = list2.ToString();
            //assert
            Assert.AreEqual(banana, expectedBanana);
        }
        [TestMethod]
        public void AddOverloadInt()
        {
            Marbles<int> list1 = new Marbles<int>() { 1, 2, 3 };
            Marbles<int> list2 = new Marbles<int>() { 4, 5, 6 };
            Marbles<int> list3 = new Marbles<int>();
            Marbles<int> banana = new Marbles<int>() { 1, 2, 3, 4, 5, 6 };
            list3 = list1 + list2;
            
            //assert
            Assert.AreEqual(banana[0], list1[0]);
        }
        [TestMethod]
        public void AddOverloadIntEndCheck()
        {
            Marbles<int> list1 = new Marbles<int>() { 1, 2, 3 };
            Marbles<int> list2 = new Marbles<int>() { 4, 5, 6 };
            Marbles<int> list3 = new Marbles<int>();
            Marbles<int> banana = new Marbles<int>() { 1, 2, 3, 4, 5, 6 };
            list3 = list1 + list2;

            //assert
            Assert.AreEqual(banana[5], list2[2]);
        }
        [TestMethod]
        public void AddOverloadStringCount()
        {
            Marbles<int> list1 = new Marbles<int>() { 1, 2, 3 };
            Marbles<int> list2 = new Marbles<int>() { 4, 5, 6 };
            Marbles<int> list3 = new Marbles<int>();
            Marbles<int> banana = new Marbles<int>() { 1, 2, 3, 4, 5, 6 };
            list3 = list1 + list2;

            //assert
            Assert.AreEqual(banana.Count, 6);
        }
        [TestMethod]
        public void SubtractOverloadInt()
        {
            Marbles<int> list1 = new Marbles<int>() { 1, 2, 3 };
            Marbles<int> list2 = new Marbles<int>() { 4, 5, 6 };
            Marbles<int> list3 = new Marbles<int>();
            Marbles<int> banana = new Marbles<int>() { 1, 2, 3, 4, 5, 6 };
            list3 = list1 - list2;

            //assert
            Assert.AreEqual(banana[0], list1[0]);
        }
        [TestMethod]
        public void SubtractOverloadIntEndCheck()
        {
            Marbles<int> list1 = new Marbles<int>() { 1, 2, 3 };
            Marbles<int> list2 = new Marbles<int>() { 4, 1, 6 };
            Marbles<int> list3 = new Marbles<int>();
            Marbles<int> banana = new Marbles<int>() { 1, 2, 3, 4, 5, 6 };
            list3 = list1 - list2;

            //assert
            Assert.AreEqual(banana[5], list2[2]);
        }
        [TestMethod]
        public void SubtractOverloadStringCount()
        {
            Marbles<int> list1 = new Marbles<int>() { 1, 2, 3 };
            Marbles<int> list2 = new Marbles<int>() { 4, 5, 6 };
            Marbles<int> list3 = new Marbles<int>();
            Marbles<int> banana = new Marbles<int>() { 1, 2, 3, 4, 5, 6 };
            list3 = list1 - list2;

            //assert
            Assert.AreEqual(banana.Count, 6);
        }
        [TestMethod]
        public void CountList()
        {
            Marbles<int> list = new Marbles<int>() { 1, 2, 3, 4, 5, 6 };

            int howManyElements = list.Count;
        }
        [TestMethod]

        public void ZipTwoListsOfInts()
        {
            Marbles<int> listOdds = new Marbles<int>() { 1, 3, 5, 7, 9 };
            Marbles<int> listEvens = new Marbles<int>() { 2, 4, 6, 8, 10 };
            Marbles<int> list = new Marbles<int>();
            Marbles<int> expectedList = new Marbles<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

             Marbles<int> result = list.ZipTwoLists(listOdds, listEvens);
            //assert
            Assert.AreEqual(expectedList, result);
        }
        [TestMethod]

        public void ZipTwoListsOfObjects()
        {
            Marbles<ExtraList<int>> listOfObjects1 = new Marbles<ExtraList<int>>();
            Marbles<ExtraList<int>> listOfObjects2 = new Marbles<ExtraList<int>>();
            
        }



    }
}

