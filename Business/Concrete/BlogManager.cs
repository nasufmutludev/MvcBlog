using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BlogManager:IBlogService
    {
        private IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> ListAllBlog()
        {
            return _blogDal.GetAll();
        }

        public void AddBlog(Blog blog)
        {
            _blogDal.Add(blog);
        }

        public void DeleteBlog(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public void UpdateBlog(Blog blog)
        {
            _blogDal.Update(blog);
        }

        public Blog GetById(int id)
        {
            return _blogDal.Get(x => x.Id == id);
        }
    }
}
