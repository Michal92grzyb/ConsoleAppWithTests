using NUnit.Framework;
using consoleTestApp;

namespace consoleTestApp.Tests
{
    public class Tests
    {
        private FizzBuzz fb;

        [SetUp]
        public void Setup()
        {
            fb = new FizzBuzz();
        }

        [Test]
        public void CheckNormalNumber()
        {
            int[] number = new int[] { 1 };
            var retVal = fb.GenerateFizzBuzz(number);

            Assert.AreEqual(retVal[0], "1");
        }

        [Test]
        public void CheckFizz()
        {
            int[] number = new int[] { 3 };
            var retVal = fb.GenerateFizzBuzz(number);

            Assert.AreEqual(retVal[0], "Fizz");
        }

        [Test]
        public void CheckBuzz()
        {
            int[] number = new int[] { 5 };
            var retVal = fb.GenerateFizzBuzz(number);

            Assert.AreEqual(retVal[0], "Buzz");
        }

        [Test]
        public void CheckFizzBuzz()
        {
            int[] number = new int[] { 15 };
            var retVal = fb.GenerateFizzBuzz(number);

            Assert.AreEqual(retVal[0], "FizzBuzz");
        }

        [Test]
        public void ManyNumbers()
        {
            {
                int[] number = new int[] { 1, 3, 5, 15 };
                var retVal = fb.GenerateFizzBuzz(number);

                Assert.AreEqual(retVal[0], "1");
                Assert.AreEqual(retVal[1], "Fizz");
                Assert.AreEqual(retVal[2], "Buzz");
                Assert.AreEqual(retVal[3], "FizzBuzz");
            }
        }

        [Test]
        public void NoNumbers()
        {
            int[] number = new int[0];
            var retVal = fb.GenerateFizzBuzz(number);

            Assert.That(retVal.Length == 0);
        }

        [Test]
        public void NegativeNumber()
        {
            int[] number = new int[] { -15 };
            var retVal = fb.GenerateFizzBuzz(number);

            Assert.AreEqual(retVal[0], "FizzBuzz");
        }

        //[Test]
        //public void NullArray()
        //{
        //    int[] number = null;
        //    fb.GenerateFizzBuzz(number);

        //    Assert.Throws(typeof(System.NullReferenceException));

        //}

    }
}