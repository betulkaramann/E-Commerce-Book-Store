using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TermProject.Entities;
using TermProject.Models;
using TermProject.Services;

namespace TermProject.Controllers
{
    public class DAccountController : Controller
    {
        private readonly AppDbContext _dbContext;

        private readonly IUserService userService;


        public DAccountController(IUserService userService, AppDbContext dbContext)
        {
            this.userService = userService;
            this._dbContext = dbContext;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login([FromForm] LoginModel loginModel)
        {
            User? user = _dbContext.User.FirstOrDefault((user) => user.Password == loginModel.LoginPassword);
            if (user != null)
            {

            }
            else
            {
                Console.WriteLine("Failed");
            }
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }

    }


}