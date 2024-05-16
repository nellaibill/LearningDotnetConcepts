using Microsoft.AspNetCore.Mvc;
using MVCCoreCustomerApplication.DAL;
using MVCCoreCustomerApplication.Models;

namespace MVCCoreCustomerApplication.Controllers
{
    public class CustomerController : Controller
    {
        IDal dal = null;
        public CustomerController(IDal _iDal, IDal _iDal1)
        {
            dal= _iDal;
        }
   
        

        public IActionResult Add([FromServices] Customer obj)
        {
      
            return View("DisplayCustomer",obj);
        }
        public IActionResult LoadCustomer()
        {
            return View("CustomerScreen");

        }
    }
}
