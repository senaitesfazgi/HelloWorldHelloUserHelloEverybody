using NUnit.Framework;
using System;
using System.IO;


namespace Test_HelloWorld
{
    public class Tests
    {
        public TextWriter SW { get; private set; }

        [SetUp]
        public void Setup()
        {
            HelloWorldUserEB.program.KeyPressed = ConsoleKey.Enter;
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        public void Test_HelloWorld()
        {
            String expected = "Hello World!";
            var sw = new StringWriter();
            Console.SetOut(SW);
            HelloWorldUserEB.program.main();
            var result = sw.ToString().Trim();
            Assert.AreEqual(expected, result);
        }
    }
}