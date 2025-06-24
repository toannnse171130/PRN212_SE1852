using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository iUserRepository;
        public UserService()
        {
            iUserRepository = new UserRepository();
        }
        public List<User> GetAllUsers()
        {
            return iUserRepository.GetAllUsers();
        }
    }
}
