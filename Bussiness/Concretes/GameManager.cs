using Business.Abstracts;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " Oyun eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " Oyun silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " Oyun güncellendi");
        }
    }
}
