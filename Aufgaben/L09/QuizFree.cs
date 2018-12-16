using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Globalization;
using Newtonsoft.Json.Converters;


namespace L09
{
    class QuizFree : Quizelement
    {

        [JsonProperty("correct")]
        public string correct { get; set; }

        public QuizFree (String question, String correct)
        {
            this.question = question;
            this.correct = correct;
            this.callToAction = "Gib' die richtieg Antwort ein:\n\n";
            this.type = "Free";
        }
        public override void Show()
        {
            Console.WriteLine(question);
            Console.WriteLine(callToAction);
        }
       public override bool IsChoiceCorrect(string choice)
        {
            if (choice == correct)
            {
                return true;
            } else {
                return false;
            }
        }
    }
}