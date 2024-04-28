using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
 
    public class Manager
    {
        //Worker can belong to the manager
        //Aggregation relation
        public List<Worker> workers = new List<Worker>();

        public int Salary { get; set; }

        public Manager()
        {
            Salary = 5000;
        }
        public string GetManagerName()
        {

            return "Saleem";
        }
        public void Login(SwipeCard obj)
        {
        }
        //Composition - Manager salary depends on project
        public void EvaluateProject (Project project)
        {
            if(project.Success)
            {
                Salary += 1000;
            }
            else
            {
                Salary -= 1000;
            }
        }

    }
    public class SwipeCard
    {
        public string GetCardDetails()
        {
            return "Access Card";
        }
        public void Swipe(Manager obj)
        {
        }
    }

    public class Worker
    {
        public string WorkerName = "";
    }

    public class Project
    {
        public bool Success { get; set; }
        public Project(bool success)
        {
            Success = success; 
        }
    }
}
