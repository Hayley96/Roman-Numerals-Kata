using NUnit.Framework;
using FluentAssertions;
using System;

namespace RomanNumeralKataTests
{
    public class SetDicitonaryObjTest
    {
        private SetDictionaryObj dict;
        [SetUp]
        public void Setup()
        {           
        }

        [Test]
        public void SetDictionaryObj_Should_Accept_An_Dictionary_Object_And_Assign_To_Class_Proparty_NumDictionary()
        {
            dict = new SetDictionaryObj(new ArabicToRomanDict());
            int? expected = dict.SelectedDict.Count;
            Assert.IsTrue(expected > 0);
        }

        [Test]
        public void SetDictionaryObj_Should_Accept_A_Different_Dictionary_Object_And_Assign_To_Class_Proparty_NumDictionary()
        {
            dict = new SetDictionaryObj(new RomanToArabicDict());
            int? expected = dict.SelectedDict.Count;
            Assert.IsTrue(expected > 0);
        }
    }
}
