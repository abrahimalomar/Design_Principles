using System;
using System.Collections.Generic;



namespace LooseAndTightCoupling
{
    interface IEmployee
    {
        void Create();
    }
    public class Programmer : IEmployee
    {
        public void Create()
        {
            Console.WriteLine("Create Program");
        }
    }
    public class Designer : IEmployee
    {
        public void Create()
        {
            Console.WriteLine("Create design");
        }
    }
    public class Financial : IEmployee
    {
        public void Create()
        {
            Console.WriteLine("Create Financial");
        }
    }
    public class Manager : IEmployee
    {
        public void Create()
        {
            Console.WriteLine("Create Manager");
        }
    }

     class ServiceEmployee
    {

        //  private readonly IEmployee employee;
        private readonly List<IEmployee> employees;
        public ServiceEmployee(List<IEmployee> Iemployee)
        {
            this.employees = Iemployee;
        }
        public void Make()
        {
            foreach (var item in employees)
            {
                item.Create();
            }
        }
    }
}
