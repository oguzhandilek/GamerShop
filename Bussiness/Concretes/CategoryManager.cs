using Business.Abstracts;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        public void Add(Category category)
        {
            Console.WriteLine(category.Name+" Kategori eklendi");
        }

        public void Delete(Category category)
        {
            Console.WriteLine(category.Name + " Kategori Silindi");
        }

        public void Update(Category category)
        {
            Console.WriteLine(category.Name + " Kategori Güncllendi");
        }
    }
}
