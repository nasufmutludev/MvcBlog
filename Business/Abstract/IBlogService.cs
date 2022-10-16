using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBlogService
    {
        List<Blog> ListAllBlog();
        void AddBlog(Blog blog);
        void DeleteBlog(Blog blog);
        void UpdateBlog(Blog blog);
        Blog GetById(int id);
    }
}
