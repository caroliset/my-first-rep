using System;
using System.Threading.Tasks;
using NUnit.Framework;


namespace PrimeService.Tests
{
    public class PrimeServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        /*[Test]
        public async Task Test1()
        {
            Console.WriteLine("See you in the test output!");
            Assert.True(condition: true);
        }*/


        [Test]
        public static void StaticTest()
        {
            Assert.False(condition: false);

        }

        [Test]
        [Description("Description of the test")]
        [Author("Carol Jaimes", "carol.jaimes@endava.com")]
        [Platform(Exclude ="Win10")]
        [Category("First Course NUnit")]
        public void classicAreEqual() {

            //Equal Assertion
            //Assert.AreEqual(expected: "expected", actual: "expected");
            Assert.That(actual: "actual", expression: Is.EqualTo(expected: "expected"), "Using Constraint Model");

        }

        [Test]
        [Ignore(reason:"The test is ignored, and shows a warning", Until ="2022-02-19 11:38:00Z")]
        public void classicAreEqualWithDescription() {
            //Equal Assertion with description
            Assert.AreEqual(expected: "expected", actual: "actual", "Meaning of this");

        }

        [Test]
        public void classicAreEqualStringDes() {
            Assert.AreEqual("expected", "actual", "What does {0} mean to {1}", "TESTING", "YOU");
        }

        [Test]
        public void classicAreequalsNum() {
            Assert.AreEqual(1, 2);
        }

        [Test]
        public void classicAreEqualsNumDifType() {
            Assert.AreEqual(2, 2d);
        }

        [Test]
        public void classicAreEqualsWithinTolerance() {
            Assert.AreEqual(expected: 2, actual: 21, delta: 0.5);
        }

        [Test]
        public void classicAreEqualArrays() {
            var expected = new int[] { 1, 2, 3 };
            var actual = new int[] { 1, 3, 2 };
            Array.Sort(actual);
            Assert.AreEqual(expected, actual, "Arrays compared");
        }

        [Test]
        public void classicAreSameObjects() {
            var obj1 = new object();
            var obj2 = obj1;
            //If you don't need assert reference equality
            Assert.AreSame(expected:obj1, actual:obj2);
        }

        [Test]
        public void classicStringAsserts()
        {
            //special classes 
            StringAssert.Contains(expected: "AA", actual: "CAAramba");
        }
        
    }
}