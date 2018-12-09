
using System;

namespace L08
{
    class QuizBinary : Quizelement
    {
        public void AnswerQuizBinary(int score)
        {
            Quizelement quizBinary = new Quizelement();
            quizBinary.question = "Snape ist Harrys Vater.";
            
            Console.WriteLine(quizBinary.question);

            Console.WriteLine("Beantworte die Frage mit J bzw N");
            string UserInput = Console.ReadLine();

            if (UserInput == "J")
            {
                Console.WriteLine("Falsch");
                score++;
            }

            else
            {
                Console.WriteLine("Korrekt");
            }

            Program p = new Program();
            p.QuizMenu(score);
        }
    }
}