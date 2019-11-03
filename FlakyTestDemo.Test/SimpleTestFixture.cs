using NUnit.Framework;
using System;
using NUnit.Framework.Constraints;

namespace FlakyTestDemo.Test
{
    [TestFixture]
    public class SimpleTestFixture
    {
        [Test]
        public void DeliberateFlakyTest()
        {
            var randomNumber = new Random().Next();
            var result = randomNumber % 5;

            Assert.That(result, Is.Not.EqualTo(0));
        }

        [Test]
        public void NotFlakyTest()
        {
            Assert.That(0, Is.EqualTo(0));
        }
    }
}
