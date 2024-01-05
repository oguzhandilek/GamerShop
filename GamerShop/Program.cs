using Business.Abstracts;
using Business.Concretes;
using Business.Validations;
using Entity;
using GamerShop.Business.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace GamerShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Category category = new Category();
            User user = new User();

            category.CategoryId = 1;
            category.Name = "Action";
            game.Id = 1;
            game.Name = "Counter Strike";
            game.Price = "100 tl";
            user.Id = 1;
            user.Name = "Oğuzhan";
            user.LastName = "Dilek";
            user.BirthDate = "1992";
            user.NationalityNumber = "12345678910";

            CategoryManager categoryManager = new CategoryManager();
            categoryManager.Add(category);

            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            Console.WriteLine("--------Oyun Veritabanına Eklendi-----");

            UserManager userManager = new UserManager();
            MernisValidationManager mernisValidationManager = new MernisValidationManager();
            if (mernisValidationManager.Query())
            {
            userManager.Add(user);
                Console.WriteLine("--------Kullanıcı Veritabanına Eklendi-----");
            }
            else
            {
                Console.WriteLine("Mernis doğrulaması yapılamadı");
            }

            BuyManager buyManager = new BuyManager();
            Console.WriteLine("--------Satın alınma işlemi-----");
            buyManager.Buy(category, game, user);

            Console.ReadLine();
        }
    }
}
