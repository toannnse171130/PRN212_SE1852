using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
namespace DataAccessLayer
{
    public class UserDAO
    {
        static List<User> users = new List<User>();
        public void InitializeDataset()
        {
            users.Add(new User() { Name = "Tèo", Phone = "0983242351", Email = "teo@gmail.com" });
            users.Add(new User() { Name = "Tý", Phone = "0983486349", Email = "ty@gmail.com" });
            users.Add(new User() { Name = "Bin", Phone = "0983486343", Email = "bin@gmail.com" });
            users.Add(new User() { Name = "Bo", Phone = "0983776349", Email = "bo@gmail.com" });
            users.Add(new User() { Name = "Bẹo", Phone = "0983896349", Email = "beo@gmail.com" });

        }
        public List<User> GetAllUsers()
        {   
            return users;
        }
    }
}
