using System;
using static System.Console;

namespace ch4
{
    class Employee{
        private string _name;

        // Getter & Setter
        public string Name
        {
            get { return _name.ToUpper();}
            set { _name = value + " (Name changed. Someone quit!)";}
        }
        
        // Constructor
        public Employee(string name){
            _name = name;
        }

        // Write employee name
        public string getIntro(){
            return String.Format("Name of employee is {0}.", Name);
        }
    }

    class Program
    {
        static void DemoClass(){
           // Create employee object
           Employee e = new Employee("James");
           e.Name = "Rey";
           WriteLine(e.getIntro());  
        }
        static void Main(string[] args)
        {
            DemoClass();
        }
    }
}
