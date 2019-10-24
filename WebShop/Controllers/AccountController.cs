using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.Logic;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public IActionResult SignIn(UserModel modelIN)
        {
            if (ModelState.IsValid)
            {

                if (modelIN.GetByEmailAndPassword(string email, string password) != null)
                {
                    ModelState.AddModelError("error", "Email already exists!");
                }

                else
                {
                    
                    {
                        Email = modelIN.Email,
                        Password = modelIN.Password,

                    });

                    return View();
                }
                public IActionResult SignUp()
                {
                    return View();
                }
            }

        [HttpPost]
        public IActionResult SignUp(UserModel model)
        {

            if (ModelState.IsValid)
            {
                UserManager manager = new UserManager();

                if (manager.GetByEmail(model.Email) != null)
                {
                    ModelState.AddModelError("error", "Email already exists!");
                }
                else
                {
                    manager.Create(new Logic.User()
                    {
                        Email = model.Email,
                        Password = model.Password,

                    });

                    TempData["message"] = "Account created!";
                    return RedirectToAction("SignIn");

                }
            }
                return View();
           
        }
    }
}