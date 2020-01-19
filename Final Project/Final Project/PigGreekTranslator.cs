using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Validation;



namespace Final_Project
{
    public class PigGreekTranslator : Translator
    {
        private static string vowelAdd = "oi";
        private static string consonantAdd = "omatos";
        private string[] array;    
       
        public PigGreekTranslator(string text)
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
