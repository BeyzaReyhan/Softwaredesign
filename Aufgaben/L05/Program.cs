using System;
using System.Collections.Generic;
using System.Linq;

namespace L05
{
    class Program
    {
        public static String result;
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte einen kleinen Satz eingeben");
            Console.Write("> ");
            var text = Console.ReadLine();
            string letters = reverseLetters(text);
            string words = reverseWords(text);
            string sentence = reverseSentence(text);
            Console.WriteLine(sentence + "\n" + words + "\n" + letters);
        }

        public static String reverseLetters(String text)                    //esäK tssirf suaM eiD
        {
            List<String> letters = new List<String>();
            letters.Add(text);
            foreach (var letter in letters)
            {
                result = String.Join("", letter.ToString().Reverse());
            }
            return result;
        }

        public static String reverseWords(String text)                      //Käse frisst Maus Die
        {
            string[] words = text.Split(' ');
            Array.Reverse(words);
            text = String.Join(" ", words);
            return text;
        }

        public static String reverseSentence(String text)                   //eiD suaM tssirf esäK
        {
            var reversedWords = string.Join(" ", text.Split(' ')
            .Select(x => new String(x.Reverse().ToArray()))
            .ToArray());
            return reversedWords;
        }
    }
}