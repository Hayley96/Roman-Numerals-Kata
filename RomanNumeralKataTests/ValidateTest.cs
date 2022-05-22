using NUnit.Framework;
using FluentAssertions;
using System;

namespace RomanNumeralKataTests
{
    public class ValidateTest
    {
        private NumeralConverter numConverter;
        private SetDictionaryObj dict;
        private string setting;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void isValidArabicNumRange_Should_Return_True_When_1_Passed_As_Parameter()
        {
           Validate.isValidArabicNumRange(1).Should().Be(true);
        }

        [Test]
        public void isValidArabicNumRange_Should_Return_True_When_2340_Passed_As_Parameter()
        {
            Validate.isValidArabicNumRange(2340).Should().Be(true);
        }

        [Test]
        public void isValidArabicNumRange_Should_Return_False_When_6000_Passed_As_Parameter()
        {
            Validate.isValidArabicNumRange(6000).Should().Be(false);
        }

        [Test]
        public void isValidArabicNumRange_Should_Return_False_When_3001_Passed_As_Parameter()
        {
            Validate.isValidArabicNumRange(3001).Should().Be(false);
        }

        [Test]
        public void isValidArabicNum_Should_Return_True_When_3000_Passed_As_Parameter()
        {
            Validate.isValidArabicNum("3000").Should().Be(true);
        }

        [Test]
        public void isValidArabicNum_Should_Return_True_When_22_Passed_As_Parameter()
        {
            Validate.isValidArabicNum("22").Should().Be(true);
        }

        [Test]
        public void isValidArabicNum_Should_Return_False_When_HUSBLK_Passed_As_Parameter()
        {
            Validate.isValidArabicNum("HUSBLK").Should().Be(false);
        }

        [Test]
        public void isValidArabicNum_Should_Return_False_When_uiahlf_Passed_As_Parameter()
        {
            Validate.isValidArabicNum("uiahlf").Should().Be(false);
        }

        [Test]
        public void isValidArabicNum_Should_Return_False_When_123yahdsg_Passed_As_Parameter()
        {
            Validate.isValidArabicNum("123yahdsg").Should().Be(false);
        }       

        [Test]
        public void isValidRomanNum_Should_Return_True_When_MMM_Passed_As_Parameter()
        {
            Validate.isValidRomanNum("MMM").Should().Be(true);
        }

        [Test]
        public void isValidRomanNum_Should_Return_True_When_MMCV_Passed_As_Parameter()
        {
            Validate.isValidRomanNum("MMCV").Should().Be(true);
        }

        [Test]
        public void isValidRomanNum_Should_Return_False_When_ICMM_Passed_As_Parameter()
        {
            Validate.isValidRomanNum("ICMM").Should().Be(false);
        }

        [Test]
        public void isValidRomanNum_Should_Return_False_When_ywhsdf_Passed_As_Parameter()
        {
            Validate.isValidRomanNum("ywhsdf").Should().Be(false);
        }
    }
}