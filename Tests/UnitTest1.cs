using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using ProjCharGenerator;
using System.Text.RegularExpressions;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(File.Exists(@"Sources\Bigrams.txt"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(File.Exists(@"Sources\WordsFreq.txt"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(File.Exists(@"Sources\Pairs.txt"));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Random r = new Random();
            Bigrams test = new Bigrams(r);
            string res1 = test.GetText(1000);
            int count1 = Regex.Matches(res1, "��").Count;
            int count2 = Regex.Matches(res1, "��").Count;
            Assert.IsTrue(count1 > count2);
        }
        [TestMethod]
        public void TestMethod5()
        {
            Random r = new Random();
            Bigrams test = new Bigrams(r);
            string res1 = test.GetText(1000);
            int count1 = Regex.Matches(res1, "��").Count;
            int count2 = Regex.Matches(res1, "��").Count;
            Assert.IsTrue(count1 > count2);
        }
        [TestMethod]
        public void TestMethod6()
        {
            Random r = new Random();
            Bigrams test = new Bigrams(r);
            string res1 = test.GetText(1000);
            int count = Regex.Matches(res1, "��").Count;
            Assert.IsTrue(count == 0);
        }

        [TestMethod]
        public void TestMethod7()
        {
            Random r = new Random();
            Words test = new Words(r);
            string res1 = test.GetText(1000);
            int count1 = Regex.Matches(res1, "�").Count;
            int count2 = Regex.Matches(res1, "���").Count;
            Assert.IsTrue(count1 > count2);
        }

        [TestMethod]
        public void TestMethod8()
        {
            Random r = new Random();
            Words test = new Words(r);
            string res1 = test.GetText(1000);
            int count1 = Regex.Matches(res1, "��").Count;
            int count2 = Regex.Matches(res1, "���").Count;
            Assert.IsTrue(count1 > count2);
        }
        [TestMethod]
        public void TestMethod9()
        {
            Random r = new Random();
            WordPairs test = new WordPairs(r);
            string res1 = test.GetText(1000);
            int count1 = Regex.Matches(res1, "������ ���").Count;
            int count2 = Regex.Matches(res1, "� �����").Count;
            Assert.IsTrue(count1 > count2);
        }

        [TestMethod]
        public void TestMethod10()
        {
            Random r = new Random();
            WordPairs test = new WordPairs(r);
            string res1 = test.GetText(1000);
            int count1 = Regex.Matches(res1, "� ��").Count;
            int count2 = Regex.Matches(res1, "����� �������").Count;
            Assert.IsTrue(count1 > count2);
        }
        [TestMethod]
        public void TestMethod11()
        {
            Random r = new Random();
            Bigrams test = new Bigrams(r);
            string res1 = test.GetText(1000);
            test.WriteToFile(@"Output\BigramsOutput.txt", res1);
            Assert.IsTrue(File.Exists(@"Output\BigramsOutput.txt"));
        }
        [TestMethod]
        public void TestMethod12()
        {
            Random r = new Random();
            Words test = new Words(r);
            string res1 = test.GetText(1000);
            test.WriteToFile(@"Output\WordGen.txt", res1);
            Assert.IsTrue(File.Exists(@"Output\WordGen.txt"));
        }

        [TestMethod]
        public void TestMethod13()
        {
            Random r = new Random();
            WordPairs test = new WordPairs(r);
            string res1 = test.GetText(1000);
            test.WriteToFile(@"Output\PairsGen.txt", res1);
            Assert.IsTrue(File.Exists(@"Output\PairsGen.txt"));
        }
    }
}
