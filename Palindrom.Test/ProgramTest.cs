using NUnit.Framework;

namespace Palindrom.Test
{
    using System;

    public class ProgramTest
    {
        [TestCase("kajak", true)]
        [TestCase("sedes", true)]
        [TestCase("zakopaneNaPokaz", true)]
        [TestCase("     ZaKoPanE   NA   poKaZ   ", true)]
        public void Palindrom_returns_correct_value(string value, bool exptectedString)
        {
            var instance = new PalindromSDP(); //arrange

            var result = instance.IsPalindrom(value); //act

            Assert.AreEqual(exptectedString, result);
        }


        [TestCase("sedes", true)]
        [TestCase("sedes1", false)]
        [TestCase("Akta ge  ne    ra³a ma ma³a Rene  gatka", true)]
        public void Palindrom_returns_correct_value_using_LINQ(string value, bool exptectedString)
        {
            var instance = new PalindromSDP(); //arrange

            var result = instance.IsBetterPalindrom(value); //act

            Assert.AreEqual(exptectedString, result);
        }
    }
}