using System;
using System.Collections.Generic;
using LooseAndTightCoupling.After;
namespace LooseAndTightCoupling
{
    class Program
    {
        
        static void Main(string[] args)
        {

            //List<IEmployee> employees = new List<IEmployee>
            //{
            //    new Programmer(),
            //    new Designer(),
            //    new Financial(),
            //    new Manager()
            //};
            //ServiceEmployee serviceEmployee = new ServiceEmployee(employees);
            //serviceEmployee.Make();
            //Console.ReadKey();



            var service = NotficationModeFactory.Create(NotficationMode.SMS);
            NotfcationService notfcationService = new NotfcationService(service);
            notfcationService.Notify();
        }
    }
}
