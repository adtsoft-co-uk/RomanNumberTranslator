using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace RomanNumberTranslatorTests
{
    [TestClass]
    public class RomanNumberTranslatorToTests
    {
        [TestMethod]
        public void GivenIntegerTranslateToRomanNumber64()
        {
            string expected = "LXIV";

            var result = RomanNumberTranslator.RomanNumberTranslator.To(64);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GivenIntegerTranslateToRomanNumber226()
        {
            string expected = "CCXXVI";

            var result = RomanNumberTranslator.RomanNumberTranslator.To(226);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GivenIntegerTranslateToRomanNumber900()
        {
            string expected = "CM";

            var result = RomanNumberTranslator.RomanNumberTranslator.To(900);

            Assert.AreEqual(expected, result);
        }
          
        [TestMethod]
        public void GivenIntegerTranslateToRomanNumber998()
        {
            string expected = "CMLXLVIII";

            var result = RomanNumberTranslator.RomanNumberTranslator.To(998);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GivenIntegerTranslateToRomanNumber3()
        {
            string expected = "III";

            var result = RomanNumberTranslator.RomanNumberTranslator.To(3);

            Assert.AreEqual(expected, result);
        }


    }
}
