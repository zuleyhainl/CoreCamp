using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Add(T entity)
        {
            using (BlogContext context = new BlogContext())//using bitince gbc ile bellekten atılır
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (BlogContext context = new BlogContext())//using bitince gbc ile bellekten atılır
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }
        public void Update(T entity)
        {
            using (BlogContext context = new BlogContext())
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }
        public T GetById(int id)
        {
            using (BlogContext context = new BlogContext())
            {
                return context.Set<T>().Find(id);
            }
        }
        public List<T> ListAll()
        {
            using (BlogContext context = new BlogContext())
            {
                return context.Set<T>().ToList();
            }
        }
    }
}
