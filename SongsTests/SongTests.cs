using Microsoft.VisualStudio.TestTools.UnitTesting;
using Songs;

namespace SongsTests
{
    [TestClass]
    public class SongTests
    {
        [TestMethod]
        public void ValidateConstructo()
        {
            Song song = new Song("song 1", "artist 1", 100000);
            string expectedArtist = "artist 1";
            Assert.AreEqual(expectedArtist, song.GetArtist());
        }

        [TestMethod]
        public void GetAwardWithMinus1CopySold()
        {
            Song song = new Song("song 1", "artist 1", -1);
            string expectedAward = null;
            Assert.AreEqual(expectedAward, song.GetCertification());
        }

        [TestMethod]
        public void GetNullAward()
        {
            Song song = new Song("song 1", "artist 1", 100000);
            string expectedAward = null;
            Assert.AreEqual(expectedAward, song.GetCertification());
        }

        [TestMethod]
        public void GetSilverAward()
        {
            Song song = new Song("song 1", "artist 1", 250000);
            string expectedAward = "Silver";
            Assert.AreEqual(expectedAward, song.GetCertification());
        }

        [TestMethod]
        public void GetGoldAward()
        {
            Song song = new Song("song 1", "artist 1", 500000);
            string expectedAward = "Gold";
            Assert.AreEqual(expectedAward, song.GetCertification());
        }

        [TestMethod]
        public void GetPlatinumAward()
        {
            Song song = new Song("song 1", "artist 1", 1000000);
            string expectedAward = "Platinum";
            Assert.AreEqual(expectedAward, song.GetCertification());
        }
    }
}
