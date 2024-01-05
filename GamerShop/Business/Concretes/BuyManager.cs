using Entity;
using GamerShop.Business.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerShop.Business.Concretes
{
    internal class BuyManager : IBuyService
    {
        public void Buy(Category category, Game game, User user)
        {
            Console.WriteLine(category.Name+" Kategorisinde bulunan "+ game.Name+" Adındaki oyun "+game.Price+" fiyata "+user.Name+" "+user.LastName+" tarafından satına alındı");
        }
    }
}
