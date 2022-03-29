using System;
using NUnit.Framework;

namespace Tests
{
    //ading comment new change
    public class ConstraintModel
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsMoreThan5AndLessthan100()
        {
            var testValue = 50;
            Assert.That(testValue, expression: Is.GreaterThan(5).And.LessThan(100));

        }

        [Test]
        public void ContainsTwoInstanceOfThree()
        {
            int[] arrayOfValues = new int[] { 1, 2, 4, 3, 3 };
            Assert.That(arrayOfValues, expression: Has.Exactly(expectedCount: 2).EqualTo(expected: 3));
        }

        [Test]
        public void ConstraintsUsingWarnings1()
        {
            //Warning with the after constraint. After - after is a delay constraint
            var isProcessed = false;
            Warn.Unless(isProcessed, Is.EqualTo(true)
                .After(delay: 1).Minutes.PollEvery(milliSeconds: 10).Seconds);
            Console.WriteLine("Still going");

        }

        [Test]
        public void ConstraintUseWarnings2() {
            Warn.If(2 + 2 != 5);
        }

        [Test]
        public void AssertpassThrowsException()
        {
            //Test fails because Assert.Pass in throws the success exception.
            Assert.That(Assert.Pass, Throws.TypeOf<AssertionException>());
        }

        [Test]
        public void AssumeConstraintModel() {
            var myString = "testAssume";
            Assume.That(myString, Is.EqualTo("Hello"));
        
        }

        [Test]
        public void WillThisMakeItThroughCodeReview()
        {
            Assert.Multiple(testDelegate: () =>
            {
                Assert.That(1, Is.EqualTo(1));
                Assert.That("maria", Is.EqualTo("maria"));
            });
        }
    }
}