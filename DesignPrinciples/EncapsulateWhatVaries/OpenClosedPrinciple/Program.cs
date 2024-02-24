using B=OpenClosedPrinciple.Basic;
using E=OpenClosedPrinciple.Edit;
using System;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            B.Quiz quiz = new B.Quiz(B.QuestionBank.Generate());
            quiz.Print();


            
        }
    }
}
