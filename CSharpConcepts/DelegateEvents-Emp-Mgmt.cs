using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class DelegateEvents_Emp_Mgmt
    {
        public void Test()
        {
            EmployeeManagement_Emp emp = new EmployeeManagement_Emp();
            Employee1 emp1 = new Employee1("John", 1000);
            Employee1 emp2 = new Employee1("Doe", 2000);
            Employee1 emp3 = new Employee1("Jane", 3000);

            emp.AddEmployee(emp1);

            emp.RemoveEmployee(emp1);
        }
    }

    public class Employee1
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public Employee1(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
    }

    public class EmployeeManagement
    {
        public delegate void EmployeeEventHandler(Employee1 emp);

        public event EmployeeEventHandler EmployeeAdded;
        public event EmployeeEventHandler EmployeeRemoved;

        public List<Employee1> Employees { get; set; }

        public EmployeeManagement()
        {
            Employees = new List<Employee1>();
        }

        public int add()
        {
            return 10;
        }
        public void AddEmployee(Employee1 emp)
        {
            Employees.Add(emp);
            Thread.Sleep(1000);
            EmployeeAdded(emp);
        }

        public void RemoveEmployee(Employee1 emp)
        {
            Employees.Remove(emp);
            Thread.Sleep(1000);
            EmployeeRemoved(emp);
        }
    }
    public class EmployeeManagement_Emp : EmployeeManagement
    {
        public EmployeeManagement_Emp() : base()
        {
            EmployeeAdded += EmployeeManagement_Emp_EmployeeAdded;
            EmployeeRemoved += EmployeeManagement_Emp_EmployeeRemoved;
        }

        private void EmployeeManagement_Emp_EmployeeAdded(Employee1 emp)
        {
            Console.WriteLine("Employee Added: " + emp.Name);
        }

        private void EmployeeManagement_Emp_EmployeeRemoved(Employee1 emp)
        {
            Console.WriteLine("Employee Removed: " + emp.Name);
        }
    }
 

}
