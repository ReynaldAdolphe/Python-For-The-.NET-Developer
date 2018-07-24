using System;
using static System.Console;
using System.Collections.Generic;

namespace ch5
{
    // Step 1 - Create abstract base class
    public abstract class Employee{
        public abstract void DetermineWeeklySalary(int weeklyHours, int wage);
    }

    // Step 2 - Inherit from base & define calculation for permanent employee
    public class Permanent : Employee{
        public override void DetermineWeeklySalary(int weeklyHours, int wage){
            var salary = 40 * wage;
            WriteLine("\nThis ANGRY EMPLOYEE worked {0} hrs. " + 
                              "Paid for 40 hrs (no overtime) at $ {1}" +
                              "/hr = ${2} \n", weeklyHours, wage, salary);
            WriteLine("---------------------------------------------\n");
        }
    }
    // Step 3 - Inherit from base & define calculation for contractor 
    public class Contractor : Employee{
        public override void DetermineWeeklySalary(int weeklyHours, int wage)
        {
            var salary = weeklyHours * wage;
            WriteLine("\nThis CONTRACTOR worked {0} hrs. " + 
                                "Paid for {0} hrs (w/ overtime) at $ {1}" +
                                "/hr = ${2} ", weeklyHours, wage, salary);
        }      
    }
    class Program
    {
        // Step 4 - Create permanent / contractor objects & list 
        private static List<Employee> GetEmployees(){
            var somePermanentEmployee = new Permanent();
            var someContractor = new Contractor();
            var everyone = new List<Employee>{ somePermanentEmployee,
                                                someContractor};
            return everyone;
        }

        static void Main(string[] args)
        {
            // Step 5 - Polymorphically calculate salaries
            const int hours = 50, wage = 70;
            List<Employee> employees = GetEmployees();

            foreach (var e in employees)
            {
                e.DetermineWeeklySalary(hours, wage);
            }
        }
    }
}
