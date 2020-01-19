using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Translator : PigTranslator, ITranslator
    {
        private string newWord;
        private string translatedWord;
                       

        public string Translate(string[] array, string vowelAdd, string consonantAdd)
        {
            for (int i = 0; i < array.Length; i++)
            {
                string word = array[i];

                if (NoSpecialCharsPresent(word))
                {//No Special Characters                    
                    if (VowelPresent(word))
                    {
                        //Vowel first letter no special characters 
                        newWord = word + vowelAdd;
                        word = CaseTranslate(word, newWord);
                        array[i] = word;
                    }
                    else
                    {
                        //consonant as first letter no special characters
                        newWord = ConsonantMoving(word) + consonantAdd;
                        word = CaseTranslate(word, newWord);
                        array[i] = word;
                    }
                }//End of NoSpecialCharacters

                else if (PunctuationPresent(word))
                {
                    //word has punctuation at end                    
                    string punc = word.Substring(word.Length - 1);

                    if (VowelPresent(word))
                    {
                        //Vowel with Punctuation
                        newWord = word.Substring(0, word.Length - 1) + vowelAdd;
                        word = CaseTranslate(word, newWord);
                        array[i] = word + punc;
                    }
                    else
                    {
                        //consonant with punctuation  
                        newWord = ConsonantMoving(word.Substring(0, word.Length - 1)) + consonantAdd;
                        word = CaseTranslate(word, newWord);
                        array[i] = word + punc;
                    }

                }// End of Punctuation Present

                else if (ContractionPresent(word))
                { //word has contraction
                    if (VowelPresent(word))
                    {                        
                        if (MultiplePunctuation(word))
                        {   //vowel with contraction and punctuation
                            string punc = word.Substring(word.Length - 1);
                            newWord = word.Substring(0, word.Length - 1) + vowelAdd;
                            word = CaseTranslate(word, newWord);
                            array[i] = word + punc;
                        }
                        else
                        {   //vowel with contraction
                            newWord = word + vowelAdd;
                            word = CaseTranslate(word, newWord);
                            array[i] = word;
                        }
                    }
                    else
                    { 
                        if (MultiplePunctuation(word))
                        {   //consonant with contraction and punctuation
                            string punc = word.Substring(word.Length - 1);
                            newWord = ConsonantMoving(word.Substring(0, word.Length - 1)) + consonantAdd;
                            word = CaseTranslate(word, newWord);
                            array[i] = word + punc;
                        }
                        else
                        {   //consonant with contraction 
                            newWord = ConsonantMoving(word) + consonantAdd;
                            word = CaseTranslate(word, newWord);
                            array[i] = word;
                        }


                    }
                }//End of Contraction Present
             
                else if (QuotuationPresent(word))
                {   //word has quotes around it
                    if (VowelPresent(word.Substring(1)))
                    {
                        
                        if (MultiplePunctuation(word))
                        { //vowel with quotes around it and punctuation after "ethan".
                            Console.WriteLine("punc, quot + vowel");
                            string punc = word.Substring(word.Length - 1);

                            newWord = VowelQuotuation(word.Substring(0, word.Length - 1), vowelAdd);
                            word = CaseTranslate(word, newWord);

                            array[i] = word + punc;
                        }
                        else
                        {   //vowel with quotes
                            newWord = VowelQuotuation(word, vowelAdd);
                            word = CaseTranslate(word, newWord);
                            array[i] = word;
                        }
                    }
                    else
                    { 
                        if (MultiplePunctuation(word))
                        {   //consonant with quotes around it and punctuation after "test".
                            string punc = word.Substring(word.Length - 1);
                            word = ConsonantQuot(word.Substring(0, word.Length - 1), consonantAdd);
                            array[i] = word + punc;
                        }
                        else
                        {   //consonant with quotes
                            word = ConsonantQuot(word, consonantAdd);
                            array[i] = word;
                        }
                    }
                }//end of quots present

                else
                {
                    Console.WriteLine("Inside specialCharacters present no '");
                    array[i] = word;
                    Console.WriteLine(array[i]);
                }//end of else

                 translatedWord += array[i] + " ";
            }//End of For Loop              

            return translatedWord;
        } //end of translate

    

    }
}
