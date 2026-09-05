using Microsoft.AspNetCore.Mvc;
using SecondMVCProject.Models;

namespace SecondMVCProject.Controllers
{
    public class ContactController : Controller
    {
        //defining 2 fields to pass the email and address to he View
        private readonly string email = "contact@beststore.com";
        private readonly string address = "New York , USA";


        public IActionResult Index()
        {

            //Passing email with View Data and address with ViewBag
            ViewData["EmailAddress"] = email;
            ViewBag.Address = address;
            return View();
        }


        [HttpPost]
        public IActionResult Index(ContactDto model)
        {

            //Passing email with View Data and address with ViewBag
            ViewData["EmailAddress"] = email;
            ViewBag.Address = address;

            if (!ModelState.IsValid) 
            {
                return View(model);
            }

            //store a contact data in the database
            ViewBag.SuccessMessage = "Your message is recieved successfully";
           
            return View(model);
        }
    }
}
