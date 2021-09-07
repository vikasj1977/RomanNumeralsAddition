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

        //Following three test methods check if right output is given if one or both of the input
        //Roman numerals is empty
        [TestMethod]
        public void Solution_FirstStringEmpty_ReturnInvalid()
        {
            var result = RomanNumeralsAdd.Solution("", "DCCL");
            Assert.AreEqual("invalid", result);
        }

        [TestMethod]
        public void Solution_SecondStringEmpty_ReturnInvalid()
        {
            var result = RomanNumeralsAdd.Solution("XXI", "");
            Assert.AreEqual("invalid", result);
        }

        [TestMethod]
        public void Solution_BothStringsEmpty_ReturnInvalid()
        {
            var result = RomanNumeralsAdd.Solution("", "");
            Assert.AreEqual("invalid", result);
        }

        //Following three test methods check if right output is given if one or both of the input
        //Roman numerals is invalid (has an invalid Roman numeral character)
        [TestMethod]
        public void Solution_FirstRomanNumeralInvalid_ReturnInvalid()
        {
            var result = RomanNumeralsAdd.Solution("XXSI", "DCCL");
            Assert.AreEqual("invalid", result);
        }

        [TestMethod]
        public void Solution_SecondRomanNumeralInvalid_ReturnInvalid()
        {
            var result = RomanNumeralsAdd.Solution("XXI", "Dijkl");
            Assert.AreEqual("invalid", result);
        }

        [TestMethod]
        public void Solution_BothRomanNumeralsInvalid_ReturnInvalid()
        {
            var result = RomanNumeralsAdd.Solution("DCSVI", "8798sCSDV");
            Assert.AreEqual("invalid", result);
        }

    }
}
