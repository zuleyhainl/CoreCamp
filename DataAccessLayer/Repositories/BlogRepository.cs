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
    public class BlogRepository : IBlogDal
    {
        public void Add(Blog blog)
        {
            using var c = new BlogContext();
            c.Add(blog);
            c.SaveChanges();
            
        }

        public void Delete(Blog blog)
        {
            using var c = new BlogContext();
            c.Remove(blog);
            c.SaveChanges();
        }

        public Blog GetById(int id)
        {
            using var c = new BlogContext();
            return c.Blogs.Find(id);
        }

        public List<Blog> ListAll()
        {
            using var c = new BlogContext();
            return c.Blogs.ToList();
        }

        public void Update(Blog blog)
        {
            using var c = new BlogContext();
            c.Update(blog);
            c.SaveChanges();
        }
    }
}
