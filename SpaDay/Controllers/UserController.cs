using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModels;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);
        }

        /* [HttpPost]
         [Route("/user/add")]
         public IActionResult Add()
         {
             return View();
         }*/

        [HttpPost]
        [Route("/user/add")]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {

            if (ModelState.IsValid)
            {
                /*if (addUserViewModel.Password != addUserViewModel.VerifyPassword)
                {
                    return View(addUserViewModel);
                }*/
                User newUser = new User
                {
                    UserName = addUserViewModel.UserName,
                    Password = addUserViewModel.Password,
                    VerifyPassword = addUserViewModel.VerifyPassword,
                    Email = addUserViewModel.Email,
                };

                return View("Index", addUserViewModel);
            }

            return View(addUserViewModel);
            

        }
    }
}
