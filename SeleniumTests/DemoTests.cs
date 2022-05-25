using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests
{
    [TestFixture]
    internal class DemoTests
    {
        [SetUp]
        public void TestSetUpMethod()
        {
            Console.WriteLine("TestSetUpMethod..");
        }
        [TearDown]
        public void TestTearDownMethod()
        {
            Console.WriteLine("TestsTearDownMethod..");
        }

        [OneTimeSetUp]
        public void OneTimeSetUpMethod()
        {
            Console.WriteLine("OneTimeSetUpMethod..");
        }
        [OneTimeTearDown]
        public void OneTimeTearDownMethod()
        {
            Console.WriteLine("OneTimeTearDownMethod..");
            Console.ReadLine();
        }
        [Test]
        public void Test1()
        {
            Console.WriteLine("Test1 is executing");
            Assert.That(1, Is.EqualTo(1));
        }
        [Test]
        public void Test2()
        {
            Console.WriteLine("Test2 is executing");
            Assert.That(1, Is.EqualTo(1));
        }
        [Test]
        public void Test3()
        {
            Console.WriteLine("Test2 is executing");
            Assert.That(1, Is.EqualTo(1));
        }

    }
}
