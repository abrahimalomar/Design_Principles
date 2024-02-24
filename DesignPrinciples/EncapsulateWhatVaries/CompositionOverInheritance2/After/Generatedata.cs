using CompositionOverInheritance2.After;
using System.Collections.Generic;

namespace CompositionOverInheritance2.After
{
    class Generatedata
    {
        public List<IEmployee> Generat()
        {
            return new List<IEmployee>()
            {
                new DailyEmployee
            {
                FirstName = "Ibrahim",
                LastName = "Alomar",
                DaysWorked = 99,
                DailyPrice = 4.5m,

            },
          new HourlyEmployee
            {
                FirstName = "Ibrahim",
                LastName = "Alomar",
                HourlyRate = 10,
                HoursWorked = 70,
            },
          new PartTimeEmployee
          {
              FirstName = "Ibrahim",
                LastName = "Alomar",
                HourlyRate = 10,
                HoursWorked = 12,
          },
          new ContractEmployee
          {
              FirstName = "Ibrahim",
                LastName = "Alomar",
                BaseSalary = 200,
                ContractDuration = 90,
          },
            };
        }
    }
}
