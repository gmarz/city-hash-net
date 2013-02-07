using NUnit.Framework;

namespace CityHash.Tests
{
    [TestFixture]
    public class CityHashTests
    {
        [Test]
        public void Hash32_Returns_32bit_Hash()
        {
            Assert.AreEqual(1345029333, "cityhash".GetCityHash32());
        }

        [Test]
        public void Hash64_Returns_64bit_Hash()
        {
            Assert.AreEqual(3346788433605131494, "cityhash".GetCityHash64());
        }

        [Test]
        public void Hash64_With_Seed_Returns_64bit_Hash()
        {
            Assert.AreEqual(1961180563844271331, "cityhash".GetCityHash64(111));
        }

        [Test]
        public void Hash64_With_Two_Seeds_Returns_64bit_Hash()
        {
            Assert.AreEqual(6458902890889381262, "cityhash".GetCityHash64(111, 222));
        }
    }
}
