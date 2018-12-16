using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Globalization;
using Newtonsoft.Json.Converters;


namespace L09
{
    class QuizSingle : Quizelement
    {
        [JsonProperty("answers")]
        public Answer[] answers { get; set; }

        public QuizSingle (String question, Answer[] answers)
        {
            this.question = question;
            this.answers = answers;
            this.callToAction = "Gib' die Zahl der richtigen Antwort ein:\n\n";
            this.type = "Single";
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
            int currentChoice = Int32.Parse(choice);
            if (answers[currentChoice - 1].isTrue == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}