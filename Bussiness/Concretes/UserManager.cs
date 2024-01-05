using Business.Abstracts;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    internal class UserManager : IUserService
    {
        public void Add(User user)
        {
            Console.WriteLine(user.Name + " Kullanıcı eklendi");
        }

        public void Delete(User user)
        {
            Console.WriteLine(user.Name + " Kullanıcı silindi");
        }

        public void Update(User user)
        {
            Console.WriteLine(user.Name + " Kullanıcı güncellendi");
        }
    }
}
