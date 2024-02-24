using System;


namespace LooseAndTightCoupling.After
{
    class EmailService : INotfcationModel
    {
        public void Send()
        {
            Console.WriteLine("Email Send");
        }
    }
}
