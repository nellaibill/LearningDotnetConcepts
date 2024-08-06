using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{

    public class usecase_abstractclass_interface
    {
        
        public abstract class AbstractEmployeeDetails
        {
             
            
            public void LogInOut()
            {
                Console.WriteLine("In Out");
            }
            public abstract void GetSalary(int salary);
        }
        public class TraineeEmployee : AbstractEmployeeDetails
        {
            public override void GetSalary(int salary)
            {
                Console.WriteLine(salary + 100);
            }
        }
        public class TeamLeader : AbstractEmployeeDetails
        {
            public override void GetSalary(int salary)
            {
                Console.WriteLine(salary + 200);
            }
        }
        public class Manager : AbstractEmployeeDetails
        {
        

            public override void GetSalary(int salary)
            {

                Console.WriteLine(salary + 300);
            }
        }

  
    }

}
