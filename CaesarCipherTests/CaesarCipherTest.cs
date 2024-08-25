namespace CaesarCipherTests
{
    [TestClass]
    public class CaesarCipherTest
    {
        [TestMethod]
        public void StandardInputStandardShift()
        {
            var message = "Lorem ipsum.";
            var shift = 7;
            var encodedMessage = "Svylt pwzbt.";

            Assert.AreEqual(encodedMessage, CaesarCipher.CaesarCipher.Encode(message, shift));
            Assert.AreEqual(message, CaesarCipher.CaesarCipher.Decode(encodedMessage, shift));
        }

        [TestMethod]
        public void ShiftBiggerThan26()
        {
            var message = "Lorem ipsum.";
            var shift = 30;
            var encodedMessage = "Psviq mtwyq.";

            Assert.AreEqual(encodedMessage, CaesarCipher.CaesarCipher.Encode(message, shift));
            Assert.AreEqual(message, CaesarCipher.CaesarCipher.Decode(encodedMessage, shift));
        }

        [TestMethod]
        public void SpecialCharackersAndSpaces()
        {
            var message = ",.;'-=   ";
            var shift = 7;
            var encodedMessage = ",.;'-=   ";

            Assert.AreEqual(encodedMessage, CaesarCipher.CaesarCipher.Encode(message, shift));
            Assert.AreEqual(message, CaesarCipher.CaesarCipher.Decode(encodedMessage, shift));
        }

        [TestMethod]
        public void NegativeValueShift()
        {
            var message = "Lorem ipsum.";
            var shift = -7;
            var encodedMessage = "Ehkxf bilnf.";

            Assert.AreEqual(encodedMessage, CaesarCipher.CaesarCipher.Encode(message, shift));
            Assert.AreEqual(message, CaesarCipher.CaesarCipher.Decode(encodedMessage, shift));
        }
    }
}