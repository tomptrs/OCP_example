using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_example
{
    class Quiz
    {
        List<Question> questions;

        public Quiz()
        {
            questions = new List<Question>();
        }
        public void AddQuestion(Question question)
        {
            questions.Add(question);
        }
        public void PrintQuiz()
        {
            questions.ForEach(question => {
                switch (question.QuestionType)
                {
                    case QuestionType.boolean:
                        Console.WriteLine(question.Description + "True or False");
                        break;

                    case QuestionType.multiplechoice:
                        Console.WriteLine(question.Description + "Make a choice");
                        break;

                    case QuestionType.open:
                        Console.WriteLine(question.Description + "write your answer");
                        break;
                }
            });
        }
    }
}
