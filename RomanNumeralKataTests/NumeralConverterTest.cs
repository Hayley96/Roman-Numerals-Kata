using NUnit.Framework;
using FluentAssertions;
using System;

namespace RomanNumeralKataTests
{
    public class NumeralConverterTest
    {
        private NumeralConverter numConverter;
        private SetDictionaryObj dict;
        private string setting;

        [SetUp]
        public void Setup()
        {
        }

        public void setupType(string _setting)
        {
            if (_setting.Equals("Arabic"))
                numConverter = new(new ArabicToRomanConvert());
            dict = new(new ArabicToRomanDict());
            if (_setting.Equals("Roman"))
                numConverter = new(new RomanToArabicConvert());
                dict = new(new RomanToArabicDict());
        }

        [Test]
        public void RunConverter_Should_Return_I_When_1_Passed_As_Parameter_And_ArabicToRoman_Conversion_Executing()
        {
           setting = "Arabic";
           setupType(setting);
           numConverter.convertType.RunConverter("1", dict).Should().Be("I");
        }

        [Test]
        public void RunConverter_Should_Return_VI_When_6_Passed_As_Parameter_And_ArabicToRoman_Conversion_Executing()
        {
            setting = "Arabic";
            setupType(setting);
            numConverter.convertType.RunConverter("6", dict).Should().Be("VI");
        }

        [Test]
        public void RunConverter_Should_Return_MMM_When_3000_Passed_As_Parameter_And_ArabicToRoman_Conversion_Executing()
        {
            setting = "Arabic";
            setupType(setting);
            numConverter.convertType.RunConverter("3000", dict).Should().Be("MMM");
        }

        [Test]
        public void RunConverter_Should_Throw_Exception_If_Null_Passed_As_Parameter_And_ArabicToRoman_Conversion_Executing()
        {
            setting = "Arabic";
            setupType(setting);
            var exNull = Assert.Throws<ArgumentNullException>(() => numConverter.convertType.RunConverter(null, dict));
        }

        [Test]
        public void RunConverter_Should_Return_6_When_VI_Passed_As_Parameter_And_RomanToArabic_Conversion_Executing()
        {
            setting = "Roman";
            setupType(setting);
            numConverter.convertType.RunConverter("VI", dict).Should().Be("6");
        }

        [Test]
        public void RunConverter_Should_Return_23_When_XXIII_Passed_As_Parameter_And_RomanToArabic_Conversion_Executing()
        {
            setting = "Roman";
            setupType(setting);
            numConverter.convertType.RunConverter("XXIII", dict).Should().Be("23");
        }

        [Test]
        public void RunConverter_Should_Return_500_When_D_Passed_As_Parameter_And_RomanToArabic_Conversion_Executing()
        {
            setting = "Roman";
            setupType(setting);
            numConverter.convertType.RunConverter("D", dict).Should().Be("500");
        }

        [Test]
        public void RunConverter_Should_Throw_Exception_If_Null_Passed_As_Parameter_And_RomanToArabic_Conversion_Executing()
        {
            setting = "Roman";
            setupType(setting);
            var exNull = Assert.Throws<ArgumentNullException>(() => numConverter.convertType.RunConverter(null, dict));
        }
    }
}