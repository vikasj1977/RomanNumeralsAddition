using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralsAddition;

namespace RomanNumeralsAddition.UnitTests
{
    [TestClass]
    public class RomanNumeralsAddTests
    {
        //Following five test methods check if right output is given when two valid Roman numerals are entered
        [TestMethod]
        public void Solution_ValidRomanNumeral1_ReturnCorrectRomanNumeralSum()
        {
            var result = RomanNumeralsAdd.Solution("XX", "IV");
            Assert.AreEqual("XXIV", result);
        }

        [TestMethod]
        public void Solution_ValidRomanNumeral2_ReturnCorrectRomanNumeralSum()
        {
            var result = RomanNumeralsAdd.Solution("XXIV", "XXXV");
            Assert.AreEqual("LIX", result);
        }

        [TestMethod]
        public void Solution_ValidRomanNumeral3_ReturnCorrectRomanNumeralSum()
        {
            var result = RomanNumeralsAdd.Solution("DCCXCIV", "CCLXI");
            Assert.AreEqual("MLV", result);
        }

        [TestMethod]
        public void Solution_ValidRomanNumeral4_ReturnCorrectRomanNumeralSum()
        {
            var result = RomanNumeralsAdd.Solution("MMMCCCLXXXIX", "MMDCCXXVI");
            Assert.AreEqual("MMMMMMCXV", result);
        }

        [TestMethod]
        public void Solution_ValidRomanNumeral5_ReturnCorrectRomanNumeralSum()
        {
            var result = RomanNumeralsAdd.Solution("MMMXLVII", "DCCL");
            Assert.AreEqual("MMMDCCXCVII", result);
        }
    
    }
}
