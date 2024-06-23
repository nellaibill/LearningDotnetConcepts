using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class CustomerLibrary
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }

        public IEnumerable LoadCustomersWithIEnumerable()
        {
            ArrayList temp = new ArrayList();
            CustomerLibrary cust1 = new CustomerLibrary();
            cust1.CustomerCode = "101";
            cust1.CustomerName = "Saleem";
            temp.Add(cust1);
            cust1 = new CustomerLibrary();
            cust1.CustomerCode = "102";
            cust1.CustomerName = "Fathima";
            temp.Add(cust1);
            return temp;
        }
        public ICollection LoadCustomersWithICollection()
        {
            ArrayList temp = new ArrayList();
            CustomerLibrary cust1 = new CustomerLibrary();
            cust1.CustomerCode = "101";
            cust1.CustomerName = "Saleem";
            temp.Add(cust1);
            cust1 = new CustomerLibrary();
            cust1.CustomerCode = "102";
            cust1.CustomerName = "Fathima";
            temp.Add(cust1);
            return temp;
        }
        public IList LoadCustomersWithIList()
        {
            ArrayList temp = new ArrayList();
            CustomerLibrary cust1 = new CustomerLibrary();
            cust1.CustomerCode = "101";
            cust1.CustomerName = "Saleem";
            temp.Add(cust1);
            cust1 = new CustomerLibrary();
            cust1.CustomerCode = "102";
            cust1.CustomerName = "Fathima";
            temp.Add(cust1);
            return temp;
        }
        public IDictionary LoadCustomersWithIDictionary()
        {
            Hashtable temp = new Hashtable();
            CustomerLibrary cust1 = new CustomerLibrary();
            cust1.CustomerCode = "101";
            cust1.CustomerName = "Saleem";
            temp.Add(cust1.CustomerCode,cust1);
            cust1 = new CustomerLibrary();
            cust1.CustomerCode = "102";
            cust1.CustomerName = "Fathima";
            temp.Add(cust1.CustomerCode,cust1);
            return temp;
        }

        public IEnumerable LoadYears()
        {
            List<int> years = new List<int>();
            years.Add(2000);
            years.Add(2001);
            years.Add(2002);
            years.Add(2003);
            years.Add(2004);
            years.Add(2005);
            years.Add(2006);
            years.Add(2007);
            return years;
        }
    }
    public class testDelegate
    {

        public delegate void addnum(int x, int y);

        public void sum(int a, int b)
        {
            Console.WriteLine(a + b); ;
        }   
       

    }
}
