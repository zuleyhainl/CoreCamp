using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        BlogContext C = new BlogContext();
        public void Add(Category category)
        {
            C.Add(category);
            C.SaveChanges();
        }

        public void Delete(Category category)
        {
            C.Remove(category);
            C.SaveChanges();
        }

        public Category GetById(int id)
        {
            return C.Categories.Find(id);
        }

        public List<Category> ListAll()
        {
            return C.Categories.ToList();
        }

        public void Update(Category category)
        {
            C.Update(category);
            C.SaveChanges();
        }
    }
}
