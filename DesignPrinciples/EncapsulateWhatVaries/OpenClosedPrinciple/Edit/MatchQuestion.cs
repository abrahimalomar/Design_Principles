using System.Collections.Generic;
using System;

namespace OpenClosedPrinciple.Edit
{
    class MatchQuestion : Question
    {
        public Dictionary<string, string> Options = new Dictionary<string, string>();
        public override void Print()
        {
            foreach (var item in Options)
            {
                Console.WriteLine($"{item.Key}                 {item.Value}");
            }
         
        }
    }

}

