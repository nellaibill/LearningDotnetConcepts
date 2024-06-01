using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCCoreTraining.Models;

namespace MVCCoreTraining.Controllers
{
    [Authorize]
    public class PatientController : Controller
    {
        private PatientDbContext _db { get; }

        public PatientController(PatientDbContext db)
        {
            _db = db;
            _db.Database.EnsureCreated();   
        }
        public IActionResult Index()
        {
            return View("AddPatient");
        }
        public IActionResult AddtoDb(Patient obj)
        {
            _db.Patients.Add(obj);
            _db.SaveChanges();
            return View("PatientDisplay");
        }
    }
}
