using System;


namespace Aufgabe05
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string!");
            string inputString = Console.ReadLine();
            Console.Write("\n");
            ReverseWhole(inputString);
            ReversePosition(inputString);
            ReverseLettersinWords(inputString);
        }

        static void ReverseWhole(string input)
        {
            char[] reverse = input.ToCharArray();
            Array.Reverse(reverse);
            input = String.Join("", reverse);
            Console.Write(input + "\n");
        }

        static void ReversePosition(string input)
        {
            string[] words = input.Split(' ');
            Array.Reverse(words);
            input = String.Join(" ", words);
            Console.Write(input + "\n");
        }

        static void ReverseLettersinWords(string input)
        {
            string reversed = "";
            string[] word = input.Split(' ');
            for (int i = 0; i < word.Length; i++)
            {
                string tempString = word[i];
                char[] tempArray = tempString.ToCharArray();
                Array.Reverse(tempArray);
                input = String.Join("", tempArray);
                reversed += input + " ";
            }
            Console.Write(reversed);
        }


    }
}