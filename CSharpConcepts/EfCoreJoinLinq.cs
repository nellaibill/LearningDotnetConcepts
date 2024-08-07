﻿using CSharpConcepts.Models;

namespace CSharpConcepts
{

    internal class EfCoreJoinLinq
    {
        List<Employee> Employees = new List<Employee>
                {
                    new Employee { EmployeeId = 1, Name = "John", DepartmentId = 1 },
                    new Employee { EmployeeId = 2, Name = "Jane", DepartmentId = 2 },
                    new Employee { EmployeeId = 3, Name = "Sam", DepartmentId = null },
                    new Employee { EmployeeId = 4, Name = "Sue", DepartmentId = 1 }
                };

        List<Department> departments = new List<Department>
                {
                    new Department { DepartmentId = 1, DepartmentName = "HR" },
                    new Department { DepartmentId = 2, DepartmentName = "IT" },
                    new Department { DepartmentId = 3, DepartmentName = "Finance" }
                };
        public void getData()
        {
            var result = from e in Employees
                         join d in departments
                         on e.DepartmentId equals d.DepartmentId into ed
                         from d in ed.DefaultIfEmpty()
                         select new
                         {
                             EmployeeName = e.Name,
                             DepartmentName = d?.DepartmentName ?? "No Department"
                         };
            foreach (var e in result)
            {
                Console.WriteLine(e.EmployeeName + " : " + e.DepartmentName);
            }
        }
    }

}
