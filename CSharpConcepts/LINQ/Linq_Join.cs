using CSharpConcepts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.LINQ
{
    public class Linq_Join
    {
        public void LoadData()
        {
            List<Employee> lstEmployee = new List<Employee>()
        {
            new Employee()
            {
                Name ="Raja",
                DepartmentId=1
            },
            new Employee()
            {
                DepartmentId = 2,
                Name="Kiran"
            }
        };

            List<Department> departmentList = new List<Department>()
        {
            new Department() { DepartmentId = 1,DepartmentName="CSC"},
            new Department() { DepartmentId=2,DepartmentName="IT"}
        };


            var result=   lstEmployee.Join
                (departmentList,
                el => el.DepartmentId,
                dl => dl.DepartmentId,
                (el, dl) => new
                {
                    el.Name,
                    dl.DepartmentName
                });


            List<string> lstCountries = new List<string>() { "India", "Australia","US" };
                        Console.WriteLine(lstCountries.First());
            Console.WriteLine(lstCountries.Last());
            Console.WriteLine(lstCountries.FirstOrDefault(x=>x.Equals("Canada")));
            Console.WriteLine(lstCountries.LastOrDefault(x => x.Equals("Canada")));
            Console.WriteLine(lstCountries.SingleOrDefault(x => x.Equals("Canada")));

            IEnumerable<string> enumCountries= lstCountries.Where((count, index) => index == 2);

            IEnumerable<Employee>  enumEmpl = lstEmployee.Where((lst,index)=>index== 1);

        }
      
    }
}
