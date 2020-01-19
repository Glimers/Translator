using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Validation;

namespace Final_Project
{       
    public class PigTranslator 
    {       
        private const string vowels = "^[aeiuo]$";
        private const string insideVowels = "^[aeiuoyAEIUOY]$";
        private const string lettersPresent = "^[a-zA-Z]*$";
        private const string punctuation = "^[a-zA-Z]*[.!,?']$";
        private const string contraction = "^[a-zA-Z]*['][a-zA-Z]*$";
        private const string punct = "^[.!,?]$";
        private static string lettersMoving = null;
        private const string contractionPunc = "^[a-zA-Z]*['][a-zA-Z]*[.!,?]$";
        private const string caps = "^[^a-z]*$";
        private const string doubleQuots = "^[\"][a-zA-Z]*[\"]$";
        private const string quotsPunc = "^[\"][a-zA-Z]*[\"][!.?,]$";

        /// <summary>
        /// Puts String in Array to translate
        /// </summary>
        /// <param name="text">input text that you want to translate</param>
        /// <returns>Array of text</returns>
        public string[] InArray(string text)
        {
            string[] array = null;
            array = text.Split(' ');
            return array;
        }        
        
        /// <summary>
        /// Check for Multiple Punctuation
        /// </summary>
        /// <param name="word">word to check</param>
        /// <returns>true if has ending punctuation, false if none</returns>
        public bool MultiplePunctuation(string word)
        {
            Match endingPunctuation = Regex.Match(word.Substring(word.Length - 1), punct);

            if (endingPunctuation.Success) return true;
            else return false;
        } 

        /// <summary>
        /// Check for vowel present as first letter
        /// </summary>
        /// <param name="word">word to check</param>
        /// <returns>returns true if first letter is vowel, false if not</returns>        
        public  bool VowelPresent(string word)
        {
            string firstLetter = word.Substring(0, 1);
            Match present = Regex.Match(firstLetter, vowels, RegexOptions.IgnoreCase);
            if (present.Success) return true;
            else return false;          
        }   

        /// <summary>
        /// No special characters in word
        /// </summary>
        /// <param name="word">word checked</param>
        /// <returns>true if no special characters, false if contains special characters</returns>        
        public bool NoSpecialCharsPresent(string word)
        {
            Match lettersOnly = Regex.Match(word, lettersPresent);
            if (lettersOnly.Success) return true;
            else return false;
        }

        /// <summary>
        /// Checks for punctuation
        /// </summary>
        /// <param name="word">word checked</param>
        /// <returns>true if punctuation present, false if none</returns>        
        public bool PunctuationPresent(string word)
        {
            Match puncPresent = Regex.Match(word, punctuation);
            if (puncPresent.Success) return true;
            else return false;
        }

        /// <summary>
        /// Checks for contractions
        /// </summary>
        /// <param name="word">word checked</param>
        /// <returns>true if contraction present, false if none</returns>
        public bool ContractionPresent(string word)
        {
            Match contPresent = Regex.Match(word, contraction);
            Match contPunc = Regex.Match(word, contractionPunc);
            if (contPresent.Success || contPunc.Success) return true;
            else return false;
        }

        /// <summary>
        /// Checks for quotuations present
        /// </summary>
        /// <param name="word">word checked</param>
        /// <returns>true if quotes present, false if none</returns>
        public bool QuotuationPresent(string word)
        {
            Match quotuation = Regex.Match(word, doubleQuots);
            Match quotPunctuation = Regex.Match(word, quotsPunc);

            if (quotuation.Success || quotPunctuation.Success) return true;
            else
            return false;
        }

        /// <summary>
        /// Move consonants to end of word
        /// </summary>
        /// <param name="word">i.e: test</param>
        /// <returns>i.e: test would return estt</returns>
        public string ConsonantMoving(string word)
        {             
            lettersMoving = word.Substring(0, FindVowel(word));
            return word.Substring(FindVowel(word)) + lettersMoving;
        }

        /// <summary>
        /// Finds where vowel is located in string
        /// </summary>
        /// <param name="word">word that want to find first vowel location</param>
        /// <returns>Int of where first vowel is located in string</returns>
        public int FindVowel(string word)
        {
            int count = 0;

            if (word.Substring(0, 1).Equals("y") || word.Substring(0, 1).Equals("Y"))
            {
                count = 1;
                word = word.Substring(1);
            }

            foreach (char i in word)
            {
                string b = i.ToString();
                Match letter = Regex.Match(b, insideVowels);
                if (letter.Success == false)
                {
                    count++;
                }
                else break;
            }

            Console.WriteLine(count.ToString());
            return count;
        }

        /// <summary>
        /// Checks for CASE in word
        /// </summary>
        /// <param name="word">Original word</param>
        /// <param name="newWord">word with string manipulation done</param>
        /// <returns>All letters to upper if original word is all upper</returns>
        public string CaseTranslate(string word, string newWord = "")
        {
            Match cap = Regex.Match(word, caps);
        
            if (cap.Success)
            {
                return newWord.ToUpper();
            }
            else
            {
                return newWord;
            }

        }

        /// <summary>
        /// String manipulation for vowel starting word in quotes
        /// </summary>
        /// <param name="word">word in quotes i.e: "equals"</param>
        /// <param name="add">string to add to word i.e:"way"</param>
        /// <returns>added word in quotes i.e: "equalsway"</returns>
        public string VowelQuotuation(string word, string add)
        {
            string q = word.Substring(0, 1);
            word = word.Remove(0, 1);
            word = word.Remove(word.Length - 1);
            word = word + add;
            word = word.Insert(0, q);
            word = word.Insert(word.Length, q);
            return word;
        }

        /// <summary>
        /// String manipulation for consonant starting word in quotes
        /// </summary>
        /// <param name="word">word in quotes i.e: "test"</param>
        /// <param name="add">string to add to word i.e: "ay"</param>
        /// <returns>added string into quotes i.e:"esttay"</returns>
        public string ConsonantQuot(string word, string add)
        {   
            string q = word.Substring(0, 1);
            word = word.Substring(1, word.Length - 2);
            string newWord = word;            
            word = ConsonantMoving(word) + add;
            word = CaseTranslate(newWord, word);            
            word = word.Insert(0, q);
            word = word.Insert(word.Length, q);
            return word;
        }
        

       

    }
}
