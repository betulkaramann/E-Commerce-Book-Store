using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TermProject.Models;

namespace TermProject.Services
{
    public interface IUserService
    {
        public User? user { get; set; }

        public void Login(LoginModel loginModel);
    }
}