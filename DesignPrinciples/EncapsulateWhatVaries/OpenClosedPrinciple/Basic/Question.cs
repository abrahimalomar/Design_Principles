using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.Basic
{
    class Question
    {
        public string Title { get; set; }

        public int Mark { get; set; }

        public QuestionType QuestionType { get; set; }

        public List<string> Choices { get; set; } = new List<string>();
    }
}
