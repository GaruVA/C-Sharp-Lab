// Create a C# console application. Consider a scenario where you are designing a system to manage employee information.
// Design a class name "Employee" with the following properties and methods.
//
//				EMPLOYEE CLASS		
//				Properties:		
//					– employeeID (int)
//					– Full Name (string)
//					– Salary (double)	
//				Methods:			
//					- Employee()				
//					- DisplayEmployeeInfo()
//
// a. Create a instance of the "Employee" class, representing an employee with an ID of 101, full name "John Doe" and a salary of 50000.
// b. Access and display the employee ID using the read-only property.
// c. Update the full name of the employee using the read-write property.
// d. Attempt to modify the salary directly from the external code (outside the class) and comment on the result.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Q02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(101, "John Doe", 50000);
            employee.DisplayEmployeeInfo();
            Console.WriteLine();
            Console.WriteLine($"Employee ID: {employee.EmployeeID}");
            employee.FullName = "Garuka Assalaarachchi";
            Console.WriteLine($"Full Name: {employee.FullName}");
            // employee.Salary = 1;   // Property 'employee.Salary' cannot be assigned to -- it is read only
            Console.WriteLine($"Salary: {employee.Salary}");
        }
    }
    public class Employee
    {
        private int employeeID;
        public int EmployeeID
        {
            get { return employeeID; }
        }
        public string FullName
        {
            get;
            set;
        }
        private double salary;
        public double Salary
        {
            get { return salary; }
        }
        public Employee(int employeeID, string fullName, double salary)
        {
            this.employeeID = employeeID;
            this.FullName = fullName;
            this.salary = salary;
        }
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}
