using System;
using NUnit.Framework;

namespace DynamicArray
{
    [TestFixture]
    class Test
    {
        private CCArray<int> Test1;
        private CCArray<string> Test2;

        private void Initialiaze()
        {
            Test1 = new CCArray<int>();
            Test2 = new CCArray<string>();
            Test1.Add(1);
            Test1.Add(2);
            Test1.Add(3);
            Test2.Add("CodeCool");
            Test2.Add("Miskolc");
            Test2.Add("2017");
        }

        [Test]
        public void TestAddWithoutIndex()
        {
            Test1 = new CCArray<int>();
            Test2 = new CCArray<string>();
            Test1.Add(1);
            Assert.AreEqual(new int[] { 1 }, Test1.GetArray());
            Test1.Add(2);
            Assert.AreEqual(new int[] { 1, 2 }, Test1.GetArray());
            Test1.Add(3);
            Assert.AreEqual(new int[] { 1, 2, 3 }, Test1.GetArray());
            Test2.Add("CodeCool");
            Assert.AreEqual(new string[] { "CodeCool" }, Test2.GetArray());
            Test2.Add("Miskolc");
            Assert.AreEqual(new string[] { "CodeCool", "Miskolc" }, Test2.GetArray());
            Test2.Add("2017");
            Assert.AreEqual(new string[] { "CodeCool", "Miskolc", "2017" }, Test2.GetArray());
        }

        [Test]
        public void TestAddWithIndex()
        {
            Test1 = new CCArray<int>();
            Test2 = new CCArray<string>();
            Test1.Add(0, 0);
            Assert.AreEqual(new int[] { 0 }, Test1.GetArray());
            Test1.Add(1, 0);
            Assert.AreEqual(new int[] { 1, 0 }, Test1.GetArray());
            Test1.Add(2, 2);
            Assert.AreEqual(new int[] { 1, 0, 2 }, Test1.GetArray());
            Assert.Throws<IndexOutOfRangeException>(() => Test1.Add(3, 4));
            Test2.Add("CodeCool", 0);
            Assert.AreEqual(new string[] { "CodeCool" }, Test2.GetArray());
            Test2.Add("Miskolc", 0);
            Assert.AreEqual(new string[] { "Miskolc", "CodeCool" }, Test2.GetArray());
            Test2.Add("2017", 1);
            Assert.AreEqual(new string[] { "Miskolc", "2017", "CodeCool" }, Test2.GetArray());
            Assert.Throws<IndexOutOfRangeException>(() => Test2.Add("Coding", 4));
        }

        [Test]
        public void TestGet()
        {
            Initialiaze();
            Assert.AreEqual(1, Test1.Get(0));
            Assert.AreEqual(3, Test1.Get(2));
            Assert.Throws<IndexOutOfRangeException>(() => Test1.Get(3));
            Assert.AreEqual("CodeCool", Test2.Get(0));
            Assert.AreEqual("2017", Test2.Get(2));
            Assert.Throws<IndexOutOfRangeException>(() => Test2.Get(3));
        }

        [Test]
        public void TestReplace()
        {
            Initialiaze();
            Test1.Replace(4, 0);
            Assert.AreEqual(new int[] { 4, 2, 3 }, Test1.GetArray());
            Test1.Replace(10, 1);
            Assert.AreEqual(new int[] { 4, 10, 3 }, Test1.GetArray());
            Test1.Replace(2, 2);
            Assert.AreEqual(new int[] { 4, 10, 2 }, Test1.GetArray());
            Assert.Throws<IndexOutOfRangeException>(() => Test1.Replace(20, 10));
            Test2.Replace("Codeing", 0);
            Assert.AreEqual(new string[] { "Codeing", "Miskolc", "2017" }, Test2.GetArray());
            Test2.Replace("Codecool", 1);
            Assert.AreEqual(new string[] { "Codeing", "Codecool", "2017" }, Test2.GetArray());
            Test2.Replace("2016", 2);
            Assert.AreEqual(new string[] { "Codeing", "Codecool", "2016" }, Test2.GetArray());
            Assert.Throws<IndexOutOfRangeException>(() => Test2.Replace("test", 3));
        }

        [Test]
        public void TestRemove()
        {
            Initialiaze();
            Test1.Remove(0);
            Assert.AreEqual(new int[] { 2, 3 }, Test1.GetArray());
            Test1.Remove(1);
            Assert.AreEqual(new int[] { 2 }, Test1.GetArray());
            Assert.Throws<IndexOutOfRangeException>(() => Test1.Remove(3));
            Test2.Remove(1);
            Assert.AreEqual(new string[] { "CodeCool", "2017" }, Test2.GetArray());
            Test2.Remove(1);
            Assert.AreEqual(new string[] { "CodeCool", }, Test2.GetArray());
            Assert.Throws<IndexOutOfRangeException>(() => Test1.Remove(3));
        }

        [Test]
        public void TestToString()
        {
            Initialiaze();
            Assert.AreEqual("[ 1, 2, 3 ]", Test1.ToString());
            Assert.AreEqual("[ CodeCool, Miskolc, 2017 ]", Test2.ToString());
        }
    }
}
