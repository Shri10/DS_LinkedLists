using System.Collections.Generic;
using DS_LinkedLists;

namespace LinkedListTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SearchedNodeWithValue()
        {
            LinkedList LList = new LinkedList();
            LList.AddNode(56);
            LList.AddNode(30);
            LList.AddNode(70);

            var result = LList.Search(30);
            Assert.AreEqual(30, result.Data);
        }

        [TestMethod]
        public void InsertedAfterGivenValue()
        {
            LinkedList LList = new LinkedList();
            LList.AddNode(56);
            LList.AddNode(30);
            LList.AddNode(70);
            LList.InsertAfter(30, 40);

            var resultAfter30 = LList.Search(30).Next;
            Assert.AreEqual(40, resultAfter30.Data);
        }

        [TestMethod]
        public void WhenValueDeletedSizeDecrease()
        {
            LinkedList LList = new LinkedList();
            LList.AddNode(56);
            LList.AddNode(30);
            LList.AddNode(70);
            LList.InsertAfter(30, 40);
            LList.DeleteWithValue(40);

            int size = LList.Size();
            Assert.AreEqual(3, size);
        }


    }
}