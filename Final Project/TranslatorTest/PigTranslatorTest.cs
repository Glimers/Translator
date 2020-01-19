using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Final_Project;
using Validation;

namespace TranslatorTest
{
    [TestClass]
    public class PigTranslatorTest
    {
        PigTranslator greek = new PigGreekTranslator("word");
        
        
        [TestMethod]
        public void MultiPunc_TRUE()
        {            
            Assert.IsTrue(greek.MultiplePunctuation("ethan's."));
        }

        [TestMethod]
        public void MultiPunc_FALSE()
        {
            Assert.IsFalse(greek.MultiplePunctuation("ethan's"));
        }

        [TestMethod]
        public void VowelPres_TRUE()
        {
            Assert.IsTrue(greek.VowelPresent("ethan"));
        }

        [TestMethod]
        public void VowelPres_FALSE()
        {
            Assert.IsFalse(greek.VowelPresent("nathan"));
        }

        [TestMethod]
        public void NoSpecPresent_TRUE()
        {
            Assert.IsTrue(greek.NoSpecialCharsPresent("Ethan"));
        }

        [TestMethod]
        public void NoSpecPresent_FALSE()
        {
            Assert.IsFalse(greek.NoSpecialCharsPresent("Ethan'"));
        }

        [TestMethod]
        public void PuncPresent_TRUE()
        {
            Assert.IsTrue(greek.PunctuationPresent("Ethan."));
        }

        [TestMethod]
        public void PuncPresent_FALSE()
        {
            Assert.IsFalse(greek.PunctuationPresent("Ethan"));
        }

        [TestMethod]
        public void ContractionPresent_TRUE()
        {
            Assert.IsTrue(greek.ContractionPresent("Ain't"));
        }

        [TestMethod]
        public void ContractionPresent_False()
        {
            Assert.IsFalse(greek.ContractionPresent("Aint"));
        }

        [TestMethod]
        public void ConsonantsMoving_Y_AsVowel()
        {
            Assert.IsTrue(greek.ConsonantMoving("wyoming") == "yomingw");
        }

        [TestMethod]
        public void ConsonantsMoving_Y_AsConsonant()
        {
            Assert.IsTrue(greek.ConsonantMoving("yawning") == "awningy");
        }

        [TestMethod]
        public void CaseTranslate_Caps()
        {
            Assert.IsTrue(greek.CaseTranslate("ETHAN", "ETHAN") == "ETHAN");
        }

        [TestMethod]
        public void CaseTranslate_noCaps()
        {
            Assert.IsTrue(greek.CaseTranslate("ethan", "ethan") == "ethan");
        }
        
        [TestMethod]
        public void ConsonantQuot_SUCCESS()
        {
            Assert.IsTrue(greek.ConsonantQuot("\"test\"", "omatos") == "\"esttomatos\"");
        }

        [TestMethod]
        public void VowelQuot_Success()
        {
            Assert.IsTrue(greek.VowelQuotuation("\"ethan\"", "oi") == "\"ethanoi\"");
        }

        [TestMethod]
        public void QuotuationPresent_True()
        {
            Assert.IsTrue(greek.QuotuationPresent("\"word\"") == true);
        }

        [TestMethod]
        public void QuotuationPresent_False()
        {
            Assert.IsFalse(greek.QuotuationPresent("word"));
        }
    } //End of PigTranslate Test

    [TestClass]
    public class PigGreekTest
    {
       
        [TestMethod]
        public void PigGreekTranslatorTest()
        {
            PigGreekTranslator pigGreek = new PigGreekTranslator("ethan");
            Assert.IsTrue(pigGreek.Translate() == "ethanoi ");
        }
    }//End of PigGreekTest

    [TestClass]
    public class PigLatinTest
    {
        [TestMethod]
        public void PigLatinTranslatorTest()
        {
            PigLatinTranslator pigLatin = new PigLatinTranslator("ethan");
            Assert.IsTrue(pigLatin.Translate() == "ethanway ");
        }
        
    }//End of PigLatinTest

    [TestClass]
    public class TranslatorTest
    {      
      
        [TestMethod]
        public void NoSpecialConsonant()
        {
            PigGreekTranslator pigGreek = new PigGreekTranslator("word");
            Assert.IsTrue(pigGreek.Translate() == "ordwomatos ");
        }

        [TestMethod]
        public void VowelPunc()
        {
            PigLatinTranslator pigLatin = new PigLatinTranslator("ethan!");
            Assert.IsTrue(pigLatin.Translate() == "ethanway! ");
        }

        [TestMethod]
        public void ConsonsantPunc()
        {
            PigLatinTranslator pigLatin = new PigLatinTranslator("latin?");
            Assert.IsTrue(pigLatin.Translate() == "atinlay? ");
        }

        [TestMethod]
        public void ContractionVowel()
        {
            PigLatinTranslator pigLatin = new PigLatinTranslator("ethan's");
            Assert.IsTrue(pigLatin.Translate() == "ethan'sway ");
        }

        [TestMethod]
        public void ContractionPuncVowel()
        {
            PigLatinTranslator pigLatin = new PigLatinTranslator("ethan's.");
            Assert.IsTrue(pigLatin.Translate() == "ethan'sway. ");
        }

        [TestMethod]
        public void ContractionConsonsant()
        {
            PigLatinTranslator pigLatin = new PigLatinTranslator("latin's");
            Assert.IsTrue(pigLatin.Translate() == "atin'slay ");
        }

        [TestMethod]
        public void ContractionPuncConsonsant()
        {
            PigLatinTranslator pigLatin = new PigLatinTranslator("latin's.");
            Assert.IsTrue(pigLatin.Translate() == "atin'slay. ");
        }

        [TestMethod]
        public void QuotVowelPunc()
        {
            PigLatinTranslator pigLatin = new PigLatinTranslator("\"ethan\".");
            Assert.IsTrue(pigLatin.Translate() == "\"ethanway\". ");
        }

        [TestMethod]
        public void QuotVowel()
        {
            PigLatinTranslator pigLatin = new PigLatinTranslator("\"ethan\"");
            Assert.IsTrue(pigLatin.Translate() == "\"ethanway\" ");
        }

        [TestMethod]
        public void QuotConsonantPunc()
        {
            PigLatinTranslator pigLatin = new PigLatinTranslator("\"latin\".");
            Assert.IsTrue(pigLatin.Translate() == "\"atinlay\". ");
        }

        [TestMethod]
        public void QuotConsonant()
        {
            PigLatinTranslator pigLatin = new PigLatinTranslator("\"latin\"");
            Assert.IsTrue(pigLatin.Translate() == "\"atinlay\" ");
        }

        [TestMethod]
        public void SpeicalCharacters()
        {
            PigLatinTranslator pigLatin = new PigLatinTranslator("123ethan");
            Assert.IsTrue(pigLatin.Translate() == "123ethan ");
        }


    }//end of translatortest

    [TestClass]
    public class ValidateTest
    {
        [TestMethod]
        public void ValidationTest_SUCCESS()
        {
            Assert.IsTrue(Validator.IsPresent("test") == true);
        }

        [TestMethod]
        public void ValidationTest_Fail()
        {            
            Assert.IsFalse(Validator.IsPresent(""));
        }
    }
}
