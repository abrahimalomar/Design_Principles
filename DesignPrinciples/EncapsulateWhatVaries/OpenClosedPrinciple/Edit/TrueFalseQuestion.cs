using System;

namespace OpenClosedPrinciple.Edit
{
    class TrueFalseQuestion : Question
    {
        public override void Print()
        {
            Console.WriteLine($"Tile{Title},Mark{Mark}");
            Console.WriteLine("1 True");
            Console.WriteLine("2 False");
        }
    }

}

