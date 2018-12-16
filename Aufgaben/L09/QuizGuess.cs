using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Globalization;
using Newtonsoft.Json.Converters;

namespace L09
{
    class QuizGuess : Quizelement
    {

        [JsonProperty("correct")]
        public int correct { get; set; }

        public QuizGuess (String question, int correct)
        {
            this.question = question;
            this.correct = correct;
            this.callToAction = "Wie lautet Deine Schätzung?\n\n";
            this.type = "Guess";

        }

        public override void Show()
        {
            Console.WriteLine(question);
            Console.WriteLine(callToAction);
        }

        public override bool IsChoiceCorrect(string choice)
        {
            int currentChoice = Int32.Parse(choice);
            if (currentChoice == correct)
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