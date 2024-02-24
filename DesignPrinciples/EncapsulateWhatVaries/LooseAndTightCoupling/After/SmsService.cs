using System;


namespace LooseAndTightCoupling.After
{
    class SmsService : INotfcationModel
    {
        public void Send()
        {
            Console.WriteLine("SMS Send");
        }
    }
}
