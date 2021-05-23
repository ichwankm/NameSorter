using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Name_Sorter;

namespace UnitTest_NameSorter
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodExecuteProgram()
        {
            string input = "name-sorter ./unsorted-names-list.txt";

            var output = SortingName.ExecuteCommand(input);

            var expectedoutput = false;

            Assert.AreEqual(expectedoutput, output);
        }

        [TestMethod]
        public void TestMethodOrderList()
        {
            string input = "Ichwan Kurnia Meidiandrianto";

            var output = SortingName.OrderbyLastName(input);

            var expectedoutput = "Meidiandrianto";

            Assert.AreEqual(expectedoutput, output);
        }
    }
}
