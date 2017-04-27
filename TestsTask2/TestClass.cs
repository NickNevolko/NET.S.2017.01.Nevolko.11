using NUnit.Framework;
using System;
using static Task2.Task2;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsTask2
{
    [TestFixture]
    public class TestClass
    {
        [TestCase(null, "abcd")]
        [TestCase(new string[] { "1", "2", "3", "4", "5" }, null)]
        public void BinSearch_Test_ArgumentNullException(string[] arr, string item)
        {
            Assert.Throws<ArgumentNullException>(() => BinarySearch(arr, item));
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 3, ExpectedResult = 2)]
        [TestCase(new int[] { 141, 245, 441, 760}, 245, ExpectedResult = 1)]
        [TestCase(new int[] { 1412, 2456, 44123, 760870 }, 760870, ExpectedResult = 3)]
        public int BinSearch_Int_Test(int[] arr, int item)
        {
            return BinarySearch(arr, item);
        }

        [TestCase(new string[] { "abcd", "bcde", "www", "zxy" }, "abcd", ExpectedResult = 0)]
        [TestCase(new string[] { "Glen", "John", "Mike", "Phil", "Sandy" }, "Phil", ExpectedResult = 3)]
        public int BinSearch_String_Test(string[] arr, string item)
        {
            return BinarySearch(arr, item);
        }
    }
}
