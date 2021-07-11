using System.Collections.Generic;
using System.Linq;
using ConfArch.Data.Models;

namespace ConfArch.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<User> users = new List<User>
        {
            new User { Id = 3523, Name = "Fenrirus", Password = "m+KLvgP6fEPppbviSaRbnk9C2I0KBYuuxpiqExZTCHw=",
                FavoriteColor = "blue", Role = "Admin", GoogleId = "101517359495305583936" }
        };

        public User GetByGoogleId(string googleId)
        {
            var user = users.SingleOrDefault(u => u.GoogleId == googleId);
            return user;
        }

        public User GetByUsernameAndPassword(string username, string password)
        {
            var user = users.SingleOrDefault(u => u.Name == username &&
                u.Password == password.Sha256());
            return user;
        }
    }
}