using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserRepository : IUserRepository
    {
        public List<User> GetAllUsers()
        {
            UserDAO userDAO = new UserDAO();
            userDAO.InitializeDataset();
            return userDAO.GetAllUsers();
        }
    }
}
