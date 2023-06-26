using System.Collections.Generic;
using DS_LinkedLists;

namespace LinkedListTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            LinkedList LList = new LinkedList();
            LList.AddNode(56);
            LList.AddNode(30);
            LList.AddNode(70);

            var result = LList.Search(30);
            Assert.AreEqual(30, result.Data);
        }
    }
}