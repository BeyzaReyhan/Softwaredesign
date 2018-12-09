using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L08
{
    class Program
    {
        public int score = 0;

        static void Main(string[] args)
        {
            
            Program p = new Program();
            p.QuizMenu(p.score);

            IntroGreeting();

            List<Question> question = new List<Question> {
                
                new Question("Wer hat Harry im 2. Teil gegen die Kammer des Schreckens geholfen?", new string[] { "Dumbledore", "Snape", "Dobby", "George" }, Question.multipleChoice, 3),
                new Question("Wer ist im Haus Gryffindor?", new string[] { "Malfoy", "Ron", "Hagrid", "Harry", "Voldemord", "Hermine" }, Question.multipleChoice, 3),
                new Question("Snape ist Harrys Vater.", new string[] { "Ja", "Nein" }, Question.multipleChoice, 2),
                new Question("Schätze, wie viele Schüler in Hogwards sind", new string[] { "1888", "2500", "2342", "7698", "100", "2698" }, Question.multipleChoice, 4),
                new Question("Harry Potter : Die Kammer des ...", new string[] { "Schreckens", "Schmetterlings", "Todes", "siebten Himmels", "Lebenden" }, Question.multipleChoice, 0),
            };



            for (int i = 0; i < question.Count; i++)
            {
                Console.WriteLine("Question #" + (1 + i).ToString());
                if (question[i].Ask())
                {
                    Results.AddResult(question[i]);
                    Console.WriteLine("Drücke eine beliebige Taste um fortzufahren");
                }
                else
                {
                    Results.AddResult(question[i]);
                }
                Console.Clear();
            }

            int tempScore = 0;

            for (int i = 0; i < Results.firstResults.Count; i++)
            {
                if (Results.firstResults[i].isCorrect)
                {
                    tempScore++;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Dein jetziger Punktestand beträgt: " + tempScore + "/" + Results.firstResults.Count.ToString());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Drücke eine beliebige Taste um fortzufahren...");
            Console.ReadKey();

            Results.RunSecondAttempt();

            Console.WriteLine("Ende!");

            int tempFinalScore = 0;

            for (int i = 0; i < Results.finalResults.Count; i++)
            {
                if (Results.finalResults[i].isCorrect)
                {
                    tempFinalScore++;
                }
            }

            Console.WriteLine("Dein engültiger Punktestand beträgt: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(tempFinalScore + "/" + Results.finalResults.Count.ToString());
            Console.ForegroundColor = ConsoleColor.White;
            if (tempFinalScore > 5)
            {
                Console.WriteLine("Gut!");
            }
            else
            {
                Console.WriteLine("Versuche es erneut...");
            }
            Console.WriteLine("Drücke eine beliebige Taste um zu beenden...");
            Console.ReadKey();
        }

        public void QuizMenu(int score)
        {

            int choice = int.Parse(Console.ReadLine());

            if(choice == 1)
            {
                ChooseQuestionType(score);
            }
            
            if(choice == 2)
            {
                Program p = new Program();
                p.AddNewQuestion();
            }

            else
            {
                Console.WriteLine("Auf Wiedersehen.");
            }
        }


        public static void IntroGreeting()
        {

            Console.WriteLine("Es gibt fünf Fragen zu beantworten.");
            Console.WriteLine("Wenn du die Frage beim ersten Mal falsch beantwortest, bekommst du einen zweiten Versuch.");
            Console.WriteLine("Du musst nur die Fragen erneut beantworten, die du falsch beantwortet hast.");
            Console.WriteLine("Bist du bereit?");
            Console.WriteLine("Drücke eine beliebige Taste um das Quiz zu starten...");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }

    }
}