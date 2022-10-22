using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        /* [HttpPost]
         [Route("/user/add")]
         public IActionResult Add()
         {
             return View();
         }*/

        [HttpPost]
        [Route("/user/add")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (verify != newUser.Password)
            {
                return View("Add");
            }

            ViewBag.Name = newUser.Username;

            return View("Index");

        }
    }
}
