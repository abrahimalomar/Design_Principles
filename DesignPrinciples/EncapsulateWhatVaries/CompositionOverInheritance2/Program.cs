

using System;

namespace CompositionOverInheritance2.After
{
    class Program
    {
        static void Main(string[] args)
        {
                Employee employee = new Employee();
                Generatedata dataGenerator = new Generatedata();
                employee.AddEmployee(dataGenerator.Generat());
                employee.PrintData();
                Console.WriteLine($"Total Salary: {employee.CalculateTotalSalary()}");



                Console.ReadKey();
            }
        }
 
        
    }

