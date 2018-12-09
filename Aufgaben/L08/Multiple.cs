using System;

namespace L08
{
    class QuizMultiple : Quizelement
    {
        public void AnswerQuizMultiple(int score)
        {
            Quizelement quizMultiple = new Quizelement();
            quizMultiple.question = "Wer ist im Haus Gryffindor?";
            
            string[] answers = new string[6];
            answers[0] = "Malfoy";
            answers[1] = "Ron";
            answers[2] = "Hagrid";
            answers[3] = "Harry";
            answers[4] = "Voldemord";
            answers[5] = "Hermine";

            Console.WriteLine(quizMultiple.question);

            Console.WriteLine(answers[0]);
            Console.WriteLine(answers[1]);
            Console.WriteLine(answers[2]);
            Console.WriteLine(answers[3]);
            Console.WriteLine(answers[4]);
            Console.WriteLine(answers[5]);

            Console.WriteLine("Wähle die richtige Antwort:");
            
            string selectedAnswers = Console.ReadLine();
            string[] answer = selectedAnswers.Split(',');

            if (answer [0] == "2" && answer[1] == "3" && answer[2] == "5")
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