using NUnit.Framework;
using Problems;

namespace Tests
{
    public class Tests
    {
        string out1 = "5,1:hello", out2 = "0,0:", out3 = "22,5:what ... did you say??";
    
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(out1, Program.Prefix("hello"));
        }

        public void Test2()
        {
            Assert.AreEqual(out2, Program.Prefix(""));
        }

        public void Test3()
        {
             Assert.AreEqual(out3, Program.Prefix("what ... did you say??"));
        }
    }
}