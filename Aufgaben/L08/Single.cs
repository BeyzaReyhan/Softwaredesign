using System;

namespace L08
{
    class QuizSingle : Quizelement
    {


       public void AnswerQuizSingle(int score)
       {
           Quizelement quizSingle = new Quizelement();
           quizSingle.question = "Wer hat Harry im 2. Teil gegen die Kammer des Schreckens geholfen?";

            string[] answers = new string[4];
            answers[0] = "Dumbledore";
            answers[1] = "Snape";
            answers[2] = "Dobby";
            answers[3] = "George";

           Console.WriteLine(quizSingle.question);

           Console.WriteLine(answers[0]);
           Console.WriteLine(answers[1]);
           Console.WriteLine(answers[2]);
           Console.WriteLine(answers[3]);

           Console.WriteLine("Bitte wähle die richtige Antwort:");
           int answerChoice = int.Parse(Console.ReadLine());

           if (answerChoice == 3)
           {
               Console.WriteLine("Korrekt");
               score ++;
           }

           else
           {
               Console.WriteLine("Falsch");
           }
           
           Program p = new Program();
           p.QuizMenu(score);
       }
    }
}