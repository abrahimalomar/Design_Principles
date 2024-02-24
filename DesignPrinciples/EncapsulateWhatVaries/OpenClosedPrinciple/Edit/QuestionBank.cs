
using System.Collections.Generic;


namespace OpenClosedPrinciple.Edit
{
    public static class QuestionBank { 
    internal static List<Question> Generate()
    {
            return new List<Question>
            {
                new WhQuestion
                {
                    Title = "What are the four pillars of OOP?",

                    Mark = 8
                },
                new MultipleChociceQuestion
                {
                    Title = "Which of the following are value types?",

                    Mark = 6,
                    Options = new List<string>
                    {
                        "A: Integer",
                        "B: Array",
                        "C: Single",
                        "D: String",
                        "E: Long",
                    }
                },
               new TrueFalseQuestion
                {
                    Title = "Earth is Bigger than sun?",

                    Mark = 4
                },
                new MultipleChociceQuestion
                {
                    Title = "Which of the following is an 8-byte Integer?",

                    Mark = 6,
                    Options = new List<string>
                    {
                       "A.  Char",
                       "B.  Long",
                       "C.  Short",
                       "D.  Byte",
                       "E.  Integer"
                    }
                },
                new MatchQuestion
                {
                    Title = "Match Column A with Column B",
                    Mark=10,
                    Options =new Dictionary<string, string>
                    {
                        {"A", "B"},
                        {"C", "D" },
                        {"L", "P"}

                    }

                },

            };
    }
}
}
