namespace Kata.CodeWars.LargeFactorial.Test
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("1", Kata.Factorial(1));
            Assert.AreEqual("120", Kata.Factorial(5));
            Assert.AreEqual("362880", Kata.Factorial(9));
            Assert.AreEqual("1307674368000", Kata.Factorial(15));
            Assert.AreEqual("14872707060906857289084508911813048098675809251055070300508818286592035566485075754388082124671571841702793317081960037166525246368924700537538282948117301741317436012998958826217903503076596121600000000000000000000000000000000", Kata.Factorial(133));
        }
    }
}