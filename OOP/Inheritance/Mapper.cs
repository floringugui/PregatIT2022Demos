using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    internal class Mapper
    {
        public UserBl MapUserDal(UserDal userDal)
        {
            return new UserBl
            {
                Firstname = userDal.Firstname,
                Lastname = userDal.Lastname,
                Username = userDal.Username,
                Id= userDal.Id.ToString()
            };
        }

        public UserDal MapUserBl(UserBl userBl)
        {
            return new UserDal
            {
                Firstname = userBl.Firstname,
                Lastname = userBl.Lastname,
                Username = userBl.Username,
                Id = GetInt(userBl)
            };
        }

        private static int GetInt(UserBl userBl)
        {
            return int.Parse(userBl.Id);
        }
    }

    public class UserDal
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public int Id { get; set; }
    }

    public class UserBl
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Id { get; set; }

        public bool ValidateUsername()
        {
            if(string.IsNullOrEmpty( Username))
            {
                return false;
            }

            return true;
        }
    }
}
