using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerShop.Business.Abstracts
{
    public interface IBuyService
    {
        void Buy(Category category, Game game, User user);
    }
}
