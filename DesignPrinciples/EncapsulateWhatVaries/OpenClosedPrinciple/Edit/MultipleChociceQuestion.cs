using System;
using System.Collections.Generic;

namespace OpenClosedPrinciple.Edit
{
    class MultipleChociceQuestion : Question
    {
        public List<string> Options = new List<string>();
        public override void Print()
        {
            foreach (var item in Options)
            {
                Console.WriteLine(item);
            }
        }
    }

}

