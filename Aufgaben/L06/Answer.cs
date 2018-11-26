using System;

namespace L06
{
    class Answer
    {
        public string answer;
        public Boolean correct;
        public Answer (String answer, Boolean correct) { //Konstruktor
            this.answer = answer;
            this.correct = correct;
        }

        public Boolean IsCorrect() // Warum boolean? 
        {
          return correct;
        }
    }

}
