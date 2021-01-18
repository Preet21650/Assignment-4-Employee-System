using System;

namespace Assignment_4_Employee_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Preet = new Employee("Preet", new DateTime(2004, 6, 17), "Student", 12000);
            Console.WriteLine(Employee.GetNumberOfEmployees());
            Console.WriteLine(Preet.GetMonthlySalary());
            Console.WriteLine(Preet.isBirthday());
            Console.WriteLine(Preet.GetYearsUntilRetirement());
            Console.WriteLine(Preet.GetInformation());
            Employee Preet2 = new Employee("Preet2", new DateTime(2004, 6, 17), "Student", 10000);
            Console.WriteLine(Employee.GetNumberOfEmployees());
        }
    }
}
