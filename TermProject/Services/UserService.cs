using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TermProject.Models;

namespace TermProject.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _dbContext;

        public UserService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public User? user { get; set; }

        public void Login(LoginModel loginModel)
        {
            User? getUser = _dbContext.User.FirstOrDefault((user) => user.Password == loginModel.LoginPassword);
            if (getUser != null)
            {
                user = getUser;
            }
        }
    }
}