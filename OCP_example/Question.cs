using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_example
{
    enum QuestionType
    {
        open,
        multiplechoice,
        boolean
    }
    class Question
    {
        public QuestionType QuestionType { get; set; }
        public string Description { get; set; }
    }
}
