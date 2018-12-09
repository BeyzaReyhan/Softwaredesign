using System;

namespace L08
{
    class QuizGuess : Quizelement
    {
        public void AnswerQuizGuess(int score)
        {
            Quizelement quizGuess = new Quizelement();
            quizGuess.question = "Schätze, wie viele Schüler in Hogwards sind.";
            
            Console.WriteLine(quizGuess.question);
            Console.WriteLine("Gib eine Zahl ein:");
            double number = double.Parse(Console.ReadLine());

            double toleranceMin = 1 * 2500;
            double toleranceMax = 1.1 * 2500;

            if (number >= toleranceMin && number <= toleranceMax)
            {
                Console.WriteLine("Korrekt");
                score++;
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