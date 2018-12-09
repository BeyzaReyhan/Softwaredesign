
using System;

namespace L08
{
    class QuizFree : Quizelement
    {
        public void AnswerQuizFree(int score)
        {
            Quizelement quizFree = new Quizelement();
            quizFree.question = "Harry Potter: Die Kammer des ...";
            
            Console.WriteLine(quizFree.question);

            Console.WriteLine("Deine Antwort ist: ");
            string rightWord = Console.ReadLine();

            if (rightWord == "Schreckens")
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