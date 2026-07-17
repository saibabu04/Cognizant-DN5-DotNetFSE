using System;

namespace EncapsulationDemo
{
    class Employee
    {
        // Private Fields
        private int employeeId;
        private string employeeName;
        private double salary;

        // Properties
        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("Salary cannot be negative.");
                }
            }
        }

        // Display Method
        public void Display()
        {
            Console.WriteLine("Employee ID   : " + EmployeeId);
            Console.WriteLine("Employee Name : " + EmployeeName);
            Console.WriteLine("Salary        : " + Salary);
        }
    }
}