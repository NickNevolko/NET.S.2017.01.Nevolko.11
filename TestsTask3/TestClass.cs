using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using static Task3.Task3;
using System.Text;
using System.Threading.Tasks;

namespace TestsTask3
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestTask3()
        {
            Dictionary<string, int> x = GetWords(@"file.txt");
            Assert.AreEqual(x["ipsum"],3);
            Assert.AreEqual(x["dolor"], 1);
            Assert.AreEqual(x["lorem"], 1);
            Assert.AreEqual(x["amet"], 2);
            Assert.AreEqual(x["abcd"], 1);
        }
    }
}