using NUnit.Framework;

namespace CityHash.Tests
{
    [TestFixture]
    public class CityHashTests
    {
        [Test]
        public void Hash32_Returns_32bit_Hash()
        {
            Assert.AreEqual(1345029333, CityHash.Hash32("cityhash"));
        }

        [Test]
        public void Hash64_Returns_64bit_Hash()
        {
            Assert.AreEqual(3346788433605131494, CityHash.Hash64("cityhash"));
        }

        [Test]
        public void Hash64_With_Seed_Returns_64bit_Hash()
        {
            Assert.AreEqual(1961180563844271331, CityHash.Hash64("cityhash", 111));
        }

        [Test]
        public void Hash64_With_Two_Seeds_Returns_64bit_Hash()
        {
            Assert.AreEqual(6458902890889381262, CityHash.Hash64("cityhash", 111, 222));
        }
    }
}
