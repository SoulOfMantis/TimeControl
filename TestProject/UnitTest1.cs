using System.Linq.Expressions;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestNegative()
        {
            Assert.That(Program.findPythogoreanTriple(-1) == (-1, -1));
        }
        [Test]
        public void TestZero()
        {
            Assert.That(Program.findPythogoreanTriple(0) == (-1, -1));
        }
        [Test]
        public void TestFirstPrimes()
        {
            Assert.That(Program.findPythogoreanTriple(2) == (-1, -1));
            Assert.That(Program.findPythogoreanTriple(3) == (-1, -1));
            Assert.That(Program.findPythogoreanTriple(4) == (3, 5));
        }

    }
}
