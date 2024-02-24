using System;

namespace OpenClosedPrinciple.Edit
{
    class WhQuestion : Question
    {
        public override void Print()
        {
            Console.WriteLine($"Title{Title},Mark{Mark}");
            Console.WriteLine("  _____________________________ ");
            Console.WriteLine("  _____________________________ ");
            Console.WriteLine("  _____________________________ ");
        }
    }

}

