using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Globalization;
using Newtonsoft.Json.Converters;

namespace L09
{
    class QuizBinary : Quizelement
    {
        [JsonProperty("correct")]
        bool correct { get; set; }

        public QuizBinary (String question, bool isTrue)
        {
            this.question = question;
            this.correct = isTrue;
            this.callToAction = "Gib' Ja ('j') oder Nein ('n') ein:\n\n";
            this.type = "Binary";

        }
        public override void Show()
        {
            Console.WriteLine(question);
        }
        public override bool IsChoiceCorrect(string choice)
        {
            bool theAnswer = (choice == "j");
            if (theAnswer == correct)
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