using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation;

namespace Final_Project
{
    public class PigLatinTranslator : Translator
    {
        private static string vowelAdd = "way";
        private static string consonantAdd = "ay";
        private string[] array;

        public PigLatinTranslator(string text)
        {
            this.Array = this.InArray(text);
        }

        public string[] Array { get => array; set => array = value; }

        public string Translate()
        {
            Translator translator = new Translator();
            return translator.Translate(this.Array, vowelAdd, consonantAdd);
            
        }
                     
    }
}
