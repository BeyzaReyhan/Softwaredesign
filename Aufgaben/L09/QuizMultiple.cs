using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Globalization;
using Newtonsoft.Json.Converters;

namespace L09
{
    class QuizMultiple : Quizelement
    {
        [JsonProperty("answers")]
        public Answer[] answers { get; set; }

        public QuizMultiple (String question, Answer[] answers)
        {
            this.question = question;
            this.answers = answers;
            this.callToAction = "Gib die Zahlen der richtigen Antworten ein:\n\n";
            this.type = "Multiple";
        }

        public override void Show()
        {
            Console.WriteLine(question);
            for (int i = 0; i < this.answers.Length; i++)
            {
                int questionNumber = i + 1;
                Console.WriteLine(questionNumber + ") " + this.answers[i].text);
            }
            Console.WriteLine(callToAction);
        }

        public override bool IsChoiceCorrect(string choice)
        {
            string[] parts = Array.ConvertAll(choice.Split(','), p => p.Trim());
            int[] pickedAnswers = Array.ConvertAll(parts, int.Parse);

            int numberOfCorrectAnswers = 0;
            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i].isTrue == true)
                {
                    numberOfCorrectAnswers++;
                }
            }

            if (numberOfCorrectAnswers != pickedAnswers.Length)
            {
                Console.WriteLine("Leider falsch!");
                return false;
            }
            else
            {
                for (int i = 0; i < parts.Length; i++)
                {
                    if (answers[pickedAnswers[i] - 1].isTrue == false)
                    {
                        Console.WriteLine("Leider falsch!");
                        return false;
                    }
                }
            }
            return true;
        }
    }
}